using ImGuiNET;
using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace ModLoader;

public static class Program
{
    public static void Main(string[] Argv) {
        GenerateBindingInterface(typeof(ImGui), "ImGuiContainer", "./ImGuiContainer.cs");
        GenerateBindingWrapper(typeof(ImGui), "ImGuiContainer", "./ImGuiContainerImpl.cs");
        GenerateInstanceWrapper(typeof(ImGui), "ImGui", "ImGuiStatic.cs");

        Console.WriteLine(typeof(ImGui).AssemblyQualifiedName);
    }

    private static void GenerateInstanceWrapper(Type t, string className, string file) {
        Console.WriteLine($"Starting interface generation for {className}");
        CodeCompileUnit compileUnit = new CodeCompileUnit();
        CodeNamespace samples = new CodeNamespace("ModLoader.API");
        compileUnit.Namespaces.Add(samples);

        CodeTypeDeclaration BindingInterface = new CodeTypeDeclaration($"I{className}");
        BindingInterface.Attributes = MemberAttributes.Public;

        foreach (var m in t.GetMethods())
        {
            Console.WriteLine($"Generating wrapper member for {m.Name}");
            var member = new CodeMemberMethod();
            member.Attributes = MemberAttributes.Public;
            member.Attributes |= MemberAttributes.Static;
            member.Name = m.Name;
            member.ReturnType = new CodeTypeReference(m.ReturnType);
            var attr = new CodeAttributeDeclaration(new CodeTypeReference(typeof(MethodImplAttribute)));
            attr.Arguments.Add(new CodeAttributeArgument(new CodeSnippetExpression("MethodImplOptions.AggressiveInlining")));
            member.CustomAttributes.Add(attr);
            if (m.ReturnType.Name.Contains("Ptr") || m.ReturnType.Name.Contains("*"))
            {
                continue;
            }
            var data = "";
            if (!m.ReturnType.Name.ToLowerInvariant().Contains("void"))
            {
                data += "return ";
            }
            data += $"ImGuiInstanceContainer.singleton.{m.Name}(";
            bool bailOut = false;
            foreach (var p in m.GetParameters())
            {
                var typename = p.ParameterType.Name;
                var name = p.Name;
                if (typename.Contains("&"))
                {
                    typename = typename.Replace("&", "");
                    typename = $"ref {typename}";
                    name = $"ref {(name)}";
                }
                member.Parameters.Add(new CodeParameterDeclarationExpression(typename, p.Name));
                data += $"{(name)},";
                if (typename.Contains("Ptr") || typename.Contains("*") || typename.Contains("Callback"))
                {
                    Console.WriteLine($"Ignoring {(member.Name)} because pointer.");
                    bailOut = true;
                    break;
                }
            }
            if (bailOut) continue;
            if (m.GetParameters().Length > 0)
            {
                data = data.Substring(0, data.Length - 1);
            }
            data += ")";
            var body = new CodeSnippetExpression(data);
            member.Statements.Add(body);
            BindingInterface.Members.Add(member);
        }

        samples.Types.Add(BindingInterface);

        CSharpCodeProvider provider = new CSharpCodeProvider();
        string sourceFile = file;

        using (StreamWriter sw = new StreamWriter(sourceFile, false))
        {
            IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");

            provider.GenerateCodeFromCompileUnit(compileUnit, tw,
                new CodeGeneratorOptions());

            tw.Close();
        }
    }

    private static void GenerateBindingWrapper(Type t, string className, string file) {
        Console.WriteLine($"Starting interface generation for {className}");
        CodeCompileUnit compileUnit = new CodeCompileUnit();
        CodeNamespace samples = new CodeNamespace("ModLoader.API");
        compileUnit.Namespaces.Add(samples);

        CodeTypeDeclaration BindingInterface = new CodeTypeDeclaration($"I{className}");
        BindingInterface.Attributes = MemberAttributes.Public;
        BindingInterface.BaseTypes.Add("IImGuiContainer");

        foreach (var m in t.GetMethods())
        {
            Console.WriteLine($"Generating wrapper member for {m.Name}");
            var member = new CodeMemberMethod();
            member.Attributes = MemberAttributes.Public;
            member.Name = m.Name;
            member.ReturnType = new CodeTypeReference(m.ReturnType);
            var attr = new CodeAttributeDeclaration(new CodeTypeReference(typeof(MethodImplAttribute)));
            attr.Arguments.Add(new CodeAttributeArgument(new CodeSnippetExpression("MethodImplOptions.AggressiveInlining")));
            member.CustomAttributes.Add(attr);
            if (m.ReturnType.Name.Contains("Ptr") || m.ReturnType.Name.Contains("*"))
            {
                continue;
            }
            var data = "";
            if (!m.ReturnType.Name.ToLowerInvariant().Contains("void"))
            {
                data += "return ";
            }
            data += $"ImGuiNET.ImGui.{m.Name}(";
            bool bailOut = false;
            foreach (var p in m.GetParameters())
            {
                var typename = p.ParameterType.Name;
                var name = p.Name;
                if (typename.Contains("&"))
                {
                    typename = typename.Replace("&", "");
                    typename = $"ref {typename}";
                    name = $"ref {(name)}";
                }
                member.Parameters.Add(new CodeParameterDeclarationExpression(typename, p.Name));
                data += $"{(name)},";
                if (typename.Contains("Ptr") || typename.Contains("*") || typename.Contains("Callback"))
                {
                    Console.WriteLine($"Ignoring {(member.Name)} because pointer.");
                    bailOut = true;
                    break;
                }
            }
            if (bailOut) continue;
            if (m.GetParameters().Length > 0)
            {
                data = data.Substring(0, data.Length - 1);
            }
            data += ")";
            var body = new CodeSnippetExpression(data);
            member.Statements.Add(body);
            BindingInterface.Members.Add(member);
        }

        samples.Types.Add(BindingInterface);

        CSharpCodeProvider provider = new CSharpCodeProvider();
        string sourceFile = file;

        using (StreamWriter sw = new StreamWriter(sourceFile, false))
        {
            IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");

            provider.GenerateCodeFromCompileUnit(compileUnit, tw,
                new CodeGeneratorOptions());

            tw.Close();
        }
    }

    private static void GenerateBindingInterface(Type t, string className, string file)
    {
        Console.WriteLine($"Starting interface generation for {className}");
        CodeCompileUnit compileUnit = new CodeCompileUnit();
        CodeNamespace samples = new CodeNamespace("ModLoader.API");
        compileUnit.Namespaces.Add(samples);

        CodeTypeDeclaration BindingInterface = new CodeTypeDeclaration($"I{className}");
        BindingInterface.IsInterface = true;
        BindingInterface.Attributes = MemberAttributes.Public;

        foreach (var m in t.GetMethods())
        {
            Console.WriteLine($"Generating interface member for {m.Name}");
            var member = new CodeMemberMethod();
            member.Attributes = MemberAttributes.Private;
            member.Name = m.Name;
            member.ReturnType = new CodeTypeReference(m.ReturnType);
            if (m.ReturnType.Name.Contains("Ptr") || m.ReturnType.Name.Contains("*"))
            {
                Console.WriteLine($"Ignoring {(member.Name)} because pointer.");
                continue;
            }
            bool bailOut = false;
            foreach (var p in m.GetParameters())
            {
                var typename = p.ParameterType.Name;
                if (typename.Contains("&"))
                {
                    typename = typename.Replace("&", "");
                    typename = $"ref {typename}";
                }
                member.Parameters.Add(new CodeParameterDeclarationExpression(typename, p.Name));
                if (typename.Contains("Ptr") || typename.Contains("*") || typename.Contains("Callback"))
                {
                    Console.WriteLine($"Ignoring {(member.Name)} because pointer.");
                    bailOut = true;
                    break;
                }
            }
            if (bailOut) continue;
            BindingInterface.Members.Add(member);
        }

        samples.Types.Add(BindingInterface);

        CSharpCodeProvider provider = new CSharpCodeProvider();
        string sourceFile = file;

        using (StreamWriter sw = new StreamWriter(sourceFile, false))
        {
            IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");

            provider.GenerateCodeFromCompileUnit(compileUnit, tw,
                new CodeGeneratorOptions());

            tw.Close();
        }
    }
}