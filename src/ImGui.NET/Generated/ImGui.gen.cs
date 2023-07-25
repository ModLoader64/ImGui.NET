using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
    public static unsafe partial class ImGui
    {
#if ANDROID
        public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<char> type)
#else
        public static ImGuiPayloadPtr AcceptDragDropPayload(string type)
#endif
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            ImGuiDragDropFlags flags = (ImGuiDragDropFlags)0;
            ImGuiPayload* ret = ImGuiNative.ImGui_AcceptDragDropPayload(native_type, flags);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return new ImGuiPayloadPtr(ret);
        }
#if ANDROID
        public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<char> type, ImGuiDragDropFlags flags)
#else
        public static ImGuiPayloadPtr AcceptDragDropPayload(string type, ImGuiDragDropFlags flags)
#endif
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            ImGuiPayload* ret = ImGuiNative.ImGui_AcceptDragDropPayload(native_type, flags);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return new ImGuiPayloadPtr(ret);
        }
        public static void AlignTextToFramePadding()
        {
            ImGuiNative.ImGui_AlignTextToFramePadding();
        }
#if ANDROID
        public static bool ArrowButton(ReadOnlySpan<char> str_id, ImGuiDir dir)
#else
        public static bool ArrowButton(string str_id, ImGuiDir dir)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_ArrowButton(native_str_id, dir);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool Begin(ReadOnlySpan<char> name)
#else
        public static bool Begin(string name)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte* p_open = null;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_Begin(native_name, p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool Begin(ReadOnlySpan<char> name, ref bool p_open)
#else
        public static bool Begin(string name, ref bool p_open)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_Begin(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool Begin(ReadOnlySpan<char> name, ref bool p_open, ImGuiWindowFlags flags)
#else
        public static bool Begin(string name, ref bool p_open, ImGuiWindowFlags flags)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.ImGui_Begin(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool BeginChild(ReadOnlySpan<char> str_id)
#else
        public static bool BeginChild(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector2 size = new Vector2();
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginChild_Str(native_str_id, size, border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginChild(ReadOnlySpan<char> str_id, Vector2 size)
#else
        public static bool BeginChild(string str_id, Vector2 size)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginChild_Str(native_str_id, size, border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginChild(ReadOnlySpan<char> str_id, Vector2 size, bool border)
#else
        public static bool BeginChild(string str_id, Vector2 size, bool border)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginChild_Str(native_str_id, size, native_border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginChild(ReadOnlySpan<char> str_id, Vector2 size, bool border, ImGuiWindowFlags flags)
#else
        public static bool BeginChild(string str_id, Vector2 size, bool border, ImGuiWindowFlags flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_BeginChild_Str(native_str_id, size, native_border, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginChild(uint id)
        {
            Vector2 size = new Vector2();
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginChild_ID(id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size)
        {
            byte border = 0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginChild_ID(id, size, border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size, bool border)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginChild_ID(id, size, native_border, flags);
            return ret != 0;
        }
        public static bool BeginChild(uint id, Vector2 size, bool border, ImGuiWindowFlags flags)
        {
            byte native_border = border ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_BeginChild_ID(id, size, native_border, flags);
            return ret != 0;
        }
        public static bool BeginChildFrame(uint id, Vector2 size)
        {
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginChildFrame(id, size, flags);
            return ret != 0;
        }
        public static bool BeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags)
        {
            byte ret = ImGuiNative.ImGui_BeginChildFrame(id, size, flags);
            return ret != 0;
        }
#if ANDROID
        public static bool BeginCombo(ReadOnlySpan<char> label, ReadOnlySpan<char> preview_value)
#else
        public static bool BeginCombo(string label, string preview_value)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_preview_value;
            int preview_value_byteCount = 0;
            if (preview_value != null)
            {
                preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
                if (preview_value_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_preview_value = Util.Allocate(preview_value_byteCount + 1);
                }
                else
                {
                    byte* native_preview_value_stackBytes = stackalloc byte[preview_value_byteCount + 1];
                    native_preview_value = native_preview_value_stackBytes;
                }
                int native_preview_value_offset = Util.GetUtf8(preview_value, native_preview_value, preview_value_byteCount);
                native_preview_value[native_preview_value_offset] = 0;
            }
            else { native_preview_value = null; }
            ImGuiComboFlags flags = (ImGuiComboFlags)0;
            byte ret = ImGuiNative.ImGui_BeginCombo(native_label, native_preview_value, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (preview_value_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_preview_value);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginCombo(ReadOnlySpan<char> label, ReadOnlySpan<char> preview_value, ImGuiComboFlags flags)
#else
        public static bool BeginCombo(string label, string preview_value, ImGuiComboFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_preview_value;
            int preview_value_byteCount = 0;
            if (preview_value != null)
            {
                preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
                if (preview_value_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_preview_value = Util.Allocate(preview_value_byteCount + 1);
                }
                else
                {
                    byte* native_preview_value_stackBytes = stackalloc byte[preview_value_byteCount + 1];
                    native_preview_value = native_preview_value_stackBytes;
                }
                int native_preview_value_offset = Util.GetUtf8(preview_value, native_preview_value, preview_value_byteCount);
                native_preview_value[native_preview_value_offset] = 0;
            }
            else { native_preview_value = null; }
            byte ret = ImGuiNative.ImGui_BeginCombo(native_label, native_preview_value, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (preview_value_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_preview_value);
            }
            return ret != 0;
        }
        public static void BeginDisabled()
        {
            byte disabled = 1;
            ImGuiNative.ImGui_BeginDisabled(disabled);
        }
        public static void BeginDisabled(bool disabled)
        {
            byte native_disabled = disabled ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_BeginDisabled(native_disabled);
        }
        public static bool BeginDragDropSource()
        {
            ImGuiDragDropFlags flags = (ImGuiDragDropFlags)0;
            byte ret = ImGuiNative.ImGui_BeginDragDropSource(flags);
            return ret != 0;
        }
        public static bool BeginDragDropSource(ImGuiDragDropFlags flags)
        {
            byte ret = ImGuiNative.ImGui_BeginDragDropSource(flags);
            return ret != 0;
        }
        public static bool BeginDragDropTarget()
        {
            byte ret = ImGuiNative.ImGui_BeginDragDropTarget();
            return ret != 0;
        }
        public static void BeginGroup()
        {
            ImGuiNative.ImGui_BeginGroup();
        }
        public static bool BeginItemTooltip()
        {
            byte ret = ImGuiNative.ImGui_BeginItemTooltip();
            return ret != 0;
        }
#if ANDROID
        public static bool BeginListBox(ReadOnlySpan<char> label)
#else
        public static bool BeginListBox(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_BeginListBox(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginListBox(ReadOnlySpan<char> label, Vector2 size)
#else
        public static bool BeginListBox(string label, Vector2 size)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_BeginListBox(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool BeginMainMenuBar()
        {
            byte ret = ImGuiNative.ImGui_BeginMainMenuBar();
            return ret != 0;
        }
#if ANDROID
        public static bool BeginMenu(ReadOnlySpan<char> label)
#else
        public static bool BeginMenu(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte enabled = 1;
            byte ret = ImGuiNative.ImGui_BeginMenu(native_label, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginMenu(ReadOnlySpan<char> label, bool enabled)
#else
        public static bool BeginMenu(string label, bool enabled)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_BeginMenu(native_label, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static bool BeginMenuBar()
        {
            byte ret = ImGuiNative.ImGui_BeginMenuBar();
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopup(ReadOnlySpan<char> str_id)
#else
        public static bool BeginPopup(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginPopup(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopup(ReadOnlySpan<char> str_id, ImGuiWindowFlags flags)
#else
        public static bool BeginPopup(string str_id, ImGuiWindowFlags flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_BeginPopup(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextItem()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.ImGui_BeginPopupContextItem(native_str_id, popup_flags);
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupContextItem(ReadOnlySpan<char> str_id)
#else
        public static bool BeginPopupContextItem(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.ImGui_BeginPopupContextItem(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupContextItem(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
#else
        public static bool BeginPopupContextItem(string str_id, ImGuiPopupFlags popup_flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_BeginPopupContextItem(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextVoid()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.ImGui_BeginPopupContextVoid(native_str_id, popup_flags);
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupContextVoid(ReadOnlySpan<char> str_id)
#else
        public static bool BeginPopupContextVoid(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.ImGui_BeginPopupContextVoid(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupContextVoid(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
#else
        public static bool BeginPopupContextVoid(string str_id, ImGuiPopupFlags popup_flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_BeginPopupContextVoid(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginPopupContextWindow()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.ImGui_BeginPopupContextWindow(native_str_id, popup_flags);
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupContextWindow(ReadOnlySpan<char> str_id)
#else
        public static bool BeginPopupContextWindow(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            byte ret = ImGuiNative.ImGui_BeginPopupContextWindow(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupContextWindow(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
#else
        public static bool BeginPopupContextWindow(string str_id, ImGuiPopupFlags popup_flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_BeginPopupContextWindow(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupModal(ReadOnlySpan<char> name)
#else
        public static bool BeginPopupModal(string name)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte* p_open = null;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginPopupModal(native_name, p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupModal(ReadOnlySpan<char> name, ref bool p_open)
#else
        public static bool BeginPopupModal(string name, ref bool p_open)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiWindowFlags flags = (ImGuiWindowFlags)0;
            byte ret = ImGuiNative.ImGui_BeginPopupModal(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool BeginPopupModal(ReadOnlySpan<char> name, ref bool p_open, ImGuiWindowFlags flags)
#else
        public static bool BeginPopupModal(string name, ref bool p_open, ImGuiWindowFlags flags)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.ImGui_BeginPopupModal(native_name, native_p_open, flags);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTabBar(ReadOnlySpan<char> str_id)
#else
        public static bool BeginTabBar(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiTabBarFlags flags = (ImGuiTabBarFlags)0;
            byte ret = ImGuiNative.ImGui_BeginTabBar(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTabBar(ReadOnlySpan<char> str_id, ImGuiTabBarFlags flags)
#else
        public static bool BeginTabBar(string str_id, ImGuiTabBarFlags flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_BeginTabBar(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTabItem(ReadOnlySpan<char> label)
#else
        public static bool BeginTabItem(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* p_open = null;
            ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;
            byte ret = ImGuiNative.ImGui_BeginTabItem(native_label, p_open, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTabItem(ReadOnlySpan<char> label, ref bool p_open)
#else
        public static bool BeginTabItem(string label, ref bool p_open)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;
            byte ret = ImGuiNative.ImGui_BeginTabItem(native_label, native_p_open, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTabItem(ReadOnlySpan<char> label, ref bool p_open, ImGuiTabItemFlags flags)
#else
        public static bool BeginTabItem(string label, ref bool p_open, ImGuiTabItemFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            byte ret = ImGuiNative.ImGui_BeginTabItem(native_label, native_p_open, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_open = native_p_open_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTable(ReadOnlySpan<char> str_id, int column)
#else
        public static bool BeginTable(string str_id, int column)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiTableFlags flags = (ImGuiTableFlags)0;
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNative.ImGui_BeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTable(ReadOnlySpan<char> str_id, int column, ImGuiTableFlags flags)
#else
        public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector2 outer_size = new Vector2();
            float inner_width = 0.0f;
            byte ret = ImGuiNative.ImGui_BeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTable(ReadOnlySpan<char> str_id, int column, ImGuiTableFlags flags, Vector2 outer_size)
#else
        public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags, Vector2 outer_size)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            float inner_width = 0.0f;
            byte ret = ImGuiNative.ImGui_BeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool BeginTable(ReadOnlySpan<char> str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
#else
        public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_BeginTable(native_str_id, column, flags, outer_size, inner_width);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool BeginTooltip()
        {
            byte ret = ImGuiNative.ImGui_BeginTooltip();
            return ret != 0;
        }
        public static void Bullet()
        {
            ImGuiNative.ImGui_Bullet();
        }
#if ANDROID
        public static void BulletText(ReadOnlySpan<char> fmt)
#else
        public static void BulletText(string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_BulletText(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
#if ANDROID
        public static bool Button(ReadOnlySpan<char> label)
#else
        public static bool Button(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_Button(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool Button(ReadOnlySpan<char> label, Vector2 size)
#else
        public static bool Button(string label, Vector2 size)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_Button(native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static float CalcItemWidth()
        {
            float ret = ImGuiNative.ImGui_CalcItemWidth();
            return ret;
        }
#if ANDROID
        public static bool Checkbox(ReadOnlySpan<char> label, ref bool v)
#else
        public static bool Checkbox(string label, ref bool v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_v_val = v ? (byte)1 : (byte)0;
            byte* native_v = &native_v_val;
            byte ret = ImGuiNative.ImGui_Checkbox(native_label, native_v);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            v = native_v_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool CheckboxFlags(ReadOnlySpan<char> label, ref int flags, int flags_value)
#else
        public static bool CheckboxFlags(string label, ref int flags, int flags_value)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_flags = &flags)
            {
                byte ret = ImGuiNative.ImGui_CheckboxFlags_IntPtr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool CheckboxFlags(ReadOnlySpan<char> label, ref uint flags, uint flags_value)
#else
        public static bool CheckboxFlags(string label, ref uint flags, uint flags_value)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (uint* native_flags = &flags)
            {
                byte ret = ImGuiNative.ImGui_CheckboxFlags_UintPtr(native_label, native_flags, flags_value);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static void CloseCurrentPopup()
        {
            ImGuiNative.ImGui_CloseCurrentPopup();
        }
#if ANDROID
        public static bool CollapsingHeader(ReadOnlySpan<char> label)
#else
        public static bool CollapsingHeader(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNative.ImGui_CollapsingHeader_TreeNodeFlags(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool CollapsingHeader(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
#else
        public static bool CollapsingHeader(string label, ImGuiTreeNodeFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_CollapsingHeader_TreeNodeFlags(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool CollapsingHeader(ReadOnlySpan<char> label, ref bool p_visible)
#else
        public static bool CollapsingHeader(string label, ref bool p_visible)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_visible_val = p_visible ? (byte)1 : (byte)0;
            byte* native_p_visible = &native_p_visible_val;
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNative.ImGui_CollapsingHeader_BoolPtr(native_label, native_p_visible, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_visible = native_p_visible_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool CollapsingHeader(ReadOnlySpan<char> label, ref bool p_visible, ImGuiTreeNodeFlags flags)
#else
        public static bool CollapsingHeader(string label, ref bool p_visible, ImGuiTreeNodeFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_visible_val = p_visible ? (byte)1 : (byte)0;
            byte* native_p_visible = &native_p_visible_val;
            byte ret = ImGuiNative.ImGui_CollapsingHeader_BoolPtr(native_label, native_p_visible, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_visible = native_p_visible_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool ColorButton(ReadOnlySpan<char> desc_id, Vector4 col)
#else
        public static bool ColorButton(string desc_id, Vector4 col)
#endif
        {
            byte* native_desc_id;
            int desc_id_byteCount = 0;
            if (desc_id != null)
            {
                desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
                if (desc_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_desc_id = Util.Allocate(desc_id_byteCount + 1);
                }
                else
                {
                    byte* native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
                    native_desc_id = native_desc_id_stackBytes;
                }
                int native_desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            else { native_desc_id = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_ColorButton(native_desc_id, col, flags, size);
            if (desc_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_desc_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool ColorButton(ReadOnlySpan<char> desc_id, Vector4 col, ImGuiColorEditFlags flags)
#else
        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags)
#endif
        {
            byte* native_desc_id;
            int desc_id_byteCount = 0;
            if (desc_id != null)
            {
                desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
                if (desc_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_desc_id = Util.Allocate(desc_id_byteCount + 1);
                }
                else
                {
                    byte* native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
                    native_desc_id = native_desc_id_stackBytes;
                }
                int native_desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            else { native_desc_id = null; }
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_ColorButton(native_desc_id, col, flags, size);
            if (desc_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_desc_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool ColorButton(ReadOnlySpan<char> desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
#else
        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
#endif
        {
            byte* native_desc_id;
            int desc_id_byteCount = 0;
            if (desc_id != null)
            {
                desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
                if (desc_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_desc_id = Util.Allocate(desc_id_byteCount + 1);
                }
                else
                {
                    byte* native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
                    native_desc_id = native_desc_id_stackBytes;
                }
                int native_desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
                native_desc_id[native_desc_id_offset] = 0;
            }
            else { native_desc_id = null; }
            byte ret = ImGuiNative.ImGui_ColorButton(native_desc_id, col, flags, size);
            if (desc_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_desc_id);
            }
            return ret != 0;
        }
        public static uint ColorConvertFloat4ToU32(Vector4 @in)
        {
            uint ret = ImGuiNative.ImGui_ColorConvertFloat4ToU32(@in);
            return ret;
        }
        public static void ColorConvertHSVtoRGB(float h, float s, float v, out float out_r, out float out_g, out float out_b)
        {
            fixed (float* native_out_r = &out_r)
            {
                fixed (float* native_out_g = &out_g)
                {
                    fixed (float* native_out_b = &out_b)
                    {
                        ImGuiNative.ImGui_ColorConvertHSVtoRGB(h, s, v, native_out_r, native_out_g, native_out_b);
                    }
                }
            }
        }
        public static void ColorConvertRGBtoHSV(float r, float g, float b, out float out_h, out float out_s, out float out_v)
        {
            fixed (float* native_out_h = &out_h)
            {
                fixed (float* native_out_s = &out_s)
                {
                    fixed (float* native_out_v = &out_v)
                    {
                        ImGuiNative.ImGui_ColorConvertRGBtoHSV(r, g, b, native_out_h, native_out_s, native_out_v);
                    }
                }
            }
        }
        public static Vector4 ColorConvertU32ToFloat4(uint @in)
        {
            Vector4 __retval;
            ImGuiNative.ImGui_ColorConvertU32ToFloat4(&__retval, @in);
            return __retval;
        }
#if ANDROID
        public static bool ColorEdit3(ReadOnlySpan<char> label, ref Vector3 col)
#else
        public static bool ColorEdit3(string label, ref Vector3 col)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorEdit3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorEdit3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
#else
        public static bool ColorEdit3(string label, ref Vector3 col, ImGuiColorEditFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorEdit3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorEdit4(ReadOnlySpan<char> label, ref Vector4 col)
#else
        public static bool ColorEdit4(string label, ref Vector4 col)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorEdit4(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorEdit4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags)
#else
        public static bool ColorEdit4(string label, ref Vector4 col, ImGuiColorEditFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorEdit4(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorPicker3(ReadOnlySpan<char> label, ref Vector3 col)
#else
        public static bool ColorPicker3(string label, ref Vector3 col)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorPicker3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorPicker3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
#else
        public static bool ColorPicker3(string label, ref Vector3 col, ImGuiColorEditFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector3* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorPicker3(native_label, native_col, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col)
#else
        public static bool ColorPicker4(string label, ref Vector4 col)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;
            float* ref_col = null;
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorPicker4(native_label, native_col, flags, ref_col);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags)
#else
        public static bool ColorPicker4(string label, ref Vector4 col, ImGuiColorEditFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float* ref_col = null;
            fixed (Vector4* native_col = &col)
            {
                byte ret = ImGuiNative.ImGui_ColorPicker4(native_label, native_col, flags, ref_col);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags, ref float ref_col)
#else
        public static bool ColorPicker4(string label, ref Vector4 col, ImGuiColorEditFlags flags, ref float ref_col)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_col = &col)
            {
                fixed (float* native_ref_col = &ref_col)
                {
                    byte ret = ImGuiNative.ImGui_ColorPicker4(native_label, native_col, flags, native_ref_col);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret != 0;
                }
            }
        }
        public static void Columns()
        {
            int count = 1;
            byte* native_id = null;
            byte border = 1;
            ImGuiNative.ImGui_Columns(count, native_id, border);
        }
        public static void Columns(int count)
        {
            byte* native_id = null;
            byte border = 1;
            ImGuiNative.ImGui_Columns(count, native_id, border);
        }
#if ANDROID
        public static void Columns(int count, ReadOnlySpan<char> id)
#else
        public static void Columns(int count, string id)
#endif
        {
            byte* native_id;
            int id_byteCount = 0;
            if (id != null)
            {
                id_byteCount = Encoding.UTF8.GetByteCount(id);
                if (id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_id = Util.Allocate(id_byteCount + 1);
                }
                else
                {
                    byte* native_id_stackBytes = stackalloc byte[id_byteCount + 1];
                    native_id = native_id_stackBytes;
                }
                int native_id_offset = Util.GetUtf8(id, native_id, id_byteCount);
                native_id[native_id_offset] = 0;
            }
            else { native_id = null; }
            byte border = 1;
            ImGuiNative.ImGui_Columns(count, native_id, border);
            if (id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_id);
            }
        }
#if ANDROID
        public static void Columns(int count, ReadOnlySpan<char> id, bool border)
#else
        public static void Columns(int count, string id, bool border)
#endif
        {
            byte* native_id;
            int id_byteCount = 0;
            if (id != null)
            {
                id_byteCount = Encoding.UTF8.GetByteCount(id);
                if (id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_id = Util.Allocate(id_byteCount + 1);
                }
                else
                {
                    byte* native_id_stackBytes = stackalloc byte[id_byteCount + 1];
                    native_id = native_id_stackBytes;
                }
                int native_id_offset = Util.GetUtf8(id, native_id, id_byteCount);
                native_id[native_id_offset] = 0;
            }
            else { native_id = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_Columns(count, native_id, native_border);
            if (id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_id);
            }
        }
#if ANDROID
        public static bool Combo(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count)
#else
        public static bool Combo(string label, ref int current_item, string[] items, int items_count)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    native_items_data[offset] = 0;
                    offset += 1;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            int popup_max_height_in_items = -1;
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.ImGui_Combo_Str_arr(native_label, native_current_item, native_items, items_count, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool Combo(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count, int popup_max_height_in_items)
#else
        public static bool Combo(string label, ref int current_item, string[] items, int items_count, int popup_max_height_in_items)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    native_items_data[offset] = 0;
                    offset += 1;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.ImGui_Combo_Str_arr(native_label, native_current_item, native_items, items_count, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool Combo(ReadOnlySpan<char> label, ref int current_item, ReadOnlySpan<char> items_separated_by_zeros)
#else
        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_items_separated_by_zeros;
            int items_separated_by_zeros_byteCount = 0;
            if (items_separated_by_zeros != null)
            {
                items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_items_separated_by_zeros = Util.Allocate(items_separated_by_zeros_byteCount + 1);
                }
                else
                {
                    byte* native_items_separated_by_zeros_stackBytes = stackalloc byte[items_separated_by_zeros_byteCount + 1];
                    native_items_separated_by_zeros = native_items_separated_by_zeros_stackBytes;
                }
                int native_items_separated_by_zeros_offset = Util.GetUtf8(items_separated_by_zeros, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
                native_items_separated_by_zeros[native_items_separated_by_zeros_offset] = 0;
            }
            else { native_items_separated_by_zeros = null; }
            int popup_max_height_in_items = -1;
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.ImGui_Combo_Str(native_label, native_current_item, native_items_separated_by_zeros, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_items_separated_by_zeros);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool Combo(ReadOnlySpan<char> label, ref int current_item, ReadOnlySpan<char> items_separated_by_zeros, int popup_max_height_in_items)
#else
        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros, int popup_max_height_in_items)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_items_separated_by_zeros;
            int items_separated_by_zeros_byteCount = 0;
            if (items_separated_by_zeros != null)
            {
                items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_items_separated_by_zeros = Util.Allocate(items_separated_by_zeros_byteCount + 1);
                }
                else
                {
                    byte* native_items_separated_by_zeros_stackBytes = stackalloc byte[items_separated_by_zeros_byteCount + 1];
                    native_items_separated_by_zeros = native_items_separated_by_zeros_stackBytes;
                }
                int native_items_separated_by_zeros_offset = Util.GetUtf8(items_separated_by_zeros, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
                native_items_separated_by_zeros[native_items_separated_by_zeros_offset] = 0;
            }
            else { native_items_separated_by_zeros = null; }
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.ImGui_Combo_Str(native_label, native_current_item, native_items_separated_by_zeros, popup_max_height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_items_separated_by_zeros);
                }
                return ret != 0;
            }
        }
        public static IntPtr CreateContext()
        {
            ImFontAtlas* shared_font_atlas = null;
            IntPtr ret = ImGuiNative.ImGui_CreateContext(shared_font_atlas);
            return ret;
        }
        public static IntPtr CreateContext(ImFontAtlasPtr shared_font_atlas)
        {
            ImFontAtlas* native_shared_font_atlas = shared_font_atlas.NativePtr;
            IntPtr ret = ImGuiNative.ImGui_CreateContext(native_shared_font_atlas);
            return ret;
        }
#if ANDROID
        public static bool DebugCheckVersionAndDataLayout(ReadOnlySpan<char> version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx)
#else
        public static bool DebugCheckVersionAndDataLayout(string version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx)
#endif
        {
            byte* native_version_str;
            int version_str_byteCount = 0;
            if (version_str != null)
            {
                version_str_byteCount = Encoding.UTF8.GetByteCount(version_str);
                if (version_str_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_version_str = Util.Allocate(version_str_byteCount + 1);
                }
                else
                {
                    byte* native_version_str_stackBytes = stackalloc byte[version_str_byteCount + 1];
                    native_version_str = native_version_str_stackBytes;
                }
                int native_version_str_offset = Util.GetUtf8(version_str, native_version_str, version_str_byteCount);
                native_version_str[native_version_str_offset] = 0;
            }
            else { native_version_str = null; }
            byte ret = ImGuiNative.ImGui_DebugCheckVersionAndDataLayout(native_version_str, sz_io, sz_style, sz_vec2, sz_vec4, sz_drawvert, sz_drawidx);
            if (version_str_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_version_str);
            }
            return ret != 0;
        }
#if ANDROID
        public static void DebugTextEncoding(ReadOnlySpan<char> text)
#else
        public static void DebugTextEncoding(string text)
#endif
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            ImGuiNative.ImGui_DebugTextEncoding(native_text);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public static void DestroyContext()
        {
            IntPtr ctx = IntPtr.Zero;
            ImGuiNative.ImGui_DestroyContext(ctx);
        }
        public static void DestroyContext(IntPtr ctx)
        {
            ImGuiNative.ImGui_DestroyContext(ctx);
        }
        public static void DestroyPlatformWindows()
        {
            ImGuiNative.ImGui_DestroyPlatformWindows();
        }
        public static uint DockSpace(uint id)
        {
            Vector2 size = new Vector2();
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.ImGui_DockSpace(id, size, flags, window_class);
            return ret;
        }
        public static uint DockSpace(uint id, Vector2 size)
        {
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.ImGui_DockSpace(id, size, flags, window_class);
            return ret;
        }
        public static uint DockSpace(uint id, Vector2 size, ImGuiDockNodeFlags flags)
        {
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.ImGui_DockSpace(id, size, flags, window_class);
            return ret;
        }
        public static uint DockSpace(uint id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr window_class)
        {
            ImGuiWindowClass* native_window_class = window_class.NativePtr;
            uint ret = ImGuiNative.ImGui_DockSpace(id, size, flags, native_window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport()
        {
            ImGuiViewport* viewport = null;
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.ImGui_DockSpaceOverViewport(viewport, flags, window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.ImGui_DockSpaceOverViewport(native_viewport, flags, window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport(ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiWindowClass* window_class = null;
            uint ret = ImGuiNative.ImGui_DockSpaceOverViewport(native_viewport, flags, window_class);
            return ret;
        }
        public static uint DockSpaceOverViewport(ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr window_class)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImGuiWindowClass* native_window_class = window_class.NativePtr;
            uint ret = ImGuiNative.ImGui_DockSpaceOverViewport(native_viewport, flags, native_window_class);
            return ret;
        }
#if ANDROID
        public static bool DragFloat(ReadOnlySpan<char> label, ref float v)
#else
        public static bool DragFloat(string label, ref float v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed)
#else
        public static bool DragFloat(string label, ref float v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min)
#else
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min, float v_max)
#else
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v)
#else
        public static bool DragFloat2(string label, ref Vector2 v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed)
#else
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min)
#else
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min, float v_max)
#else
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v)
#else
        public static bool DragFloat3(string label, ref Vector3 v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed)
#else
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min)
#else
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min, float v_max)
#else
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v)
#else
        public static bool DragFloat4(string label, ref Vector4 v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed)
#else
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min)
#else
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min, float v_max)
#else
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragFloat4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max)
#else
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed)
#else
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_min = 0.0f;
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min)
#else
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_max = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max)
#else
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max)
#else
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max, ImGuiSliderFlags flags)
#else
        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            fixed (float* native_v_current_min = &v_current_min)
            {
                fixed (float* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragInt(ReadOnlySpan<char> label, ref int v)
#else
        public static bool DragInt(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed)
#else
        public static bool DragInt(string label, ref int v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min)
#else
        public static bool DragInt(string label, ref int v, float v_speed, int v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max)
#else
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt2(ReadOnlySpan<char> label, ref int v)
#else
        public static bool DragInt2(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float v_speed)
#else
        public static bool DragInt2(string label, ref int v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min)
#else
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max)
#else
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt2(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt3(ReadOnlySpan<char> label, ref int v)
#else
        public static bool DragInt3(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float v_speed)
#else
        public static bool DragInt3(string label, ref int v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min)
#else
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max)
#else
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt3(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt4(ReadOnlySpan<char> label, ref int v)
#else
        public static bool DragInt4(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float v_speed)
#else
        public static bool DragInt4(string label, ref int v, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min)
#else
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max)
#else
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_DragInt4(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max)
#else
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_speed = 1.0f;
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed)
#else
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_min = 0;
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min)
#else
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int v_max = 0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max)
#else
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max)
#else
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max, ImGuiSliderFlags flags)
#else
        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte* native_format_max;
            int format_max_byteCount = 0;
            if (format_max != null)
            {
                format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
                if (format_max_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format_max = Util.Allocate(format_max_byteCount + 1);
                }
                else
                {
                    byte* native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
                    native_format_max = native_format_max_stackBytes;
                }
                int native_format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
                native_format_max[native_format_max_offset] = 0;
            }
            else { native_format_max = null; }
            fixed (int* native_v_current_min = &v_current_min)
            {
                fixed (int* native_v_current_max = &v_current_max)
                {
                    byte ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    if (format_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format);
                    }
                    if (format_max_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_format_max);
                    }
                    return ret != 0;
                }
            }
        }
#if ANDROID
        public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data)
#else
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            float v_speed = 1.0f;
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalar(native_label, data_type, native_p_data, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed)
#else
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalar(native_label, data_type, native_p_data, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min)
#else
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max)
#else
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
#else
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.ImGui_DragScalar(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components)
#else
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            float v_speed = 1.0f;
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalarN(native_label, data_type, native_p_data, components, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed)
#else
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_min = null;
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalarN(native_label, data_type, native_p_data, components, v_speed, p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min)
#else
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* p_max = null;
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max)
#else
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
#else
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_DragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.ImGui_DragScalarN(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
        public static void Dummy(Vector2 size)
        {
            ImGuiNative.ImGui_Dummy(size);
        }
        public static void End()
        {
            ImGuiNative.ImGui_End();
        }
        public static void EndChild()
        {
            ImGuiNative.ImGui_EndChild();
        }
        public static void EndChildFrame()
        {
            ImGuiNative.ImGui_EndChildFrame();
        }
        public static void EndCombo()
        {
            ImGuiNative.ImGui_EndCombo();
        }
        public static void EndDisabled()
        {
            ImGuiNative.ImGui_EndDisabled();
        }
        public static void EndDragDropSource()
        {
            ImGuiNative.ImGui_EndDragDropSource();
        }
        public static void EndDragDropTarget()
        {
            ImGuiNative.ImGui_EndDragDropTarget();
        }
        public static void EndFrame()
        {
            ImGuiNative.ImGui_EndFrame();
        }
        public static void EndGroup()
        {
            ImGuiNative.ImGui_EndGroup();
        }
        public static void EndListBox()
        {
            ImGuiNative.ImGui_EndListBox();
        }
        public static void EndMainMenuBar()
        {
            ImGuiNative.ImGui_EndMainMenuBar();
        }
        public static void EndMenu()
        {
            ImGuiNative.ImGui_EndMenu();
        }
        public static void EndMenuBar()
        {
            ImGuiNative.ImGui_EndMenuBar();
        }
        public static void EndPopup()
        {
            ImGuiNative.ImGui_EndPopup();
        }
        public static void EndTabBar()
        {
            ImGuiNative.ImGui_EndTabBar();
        }
        public static void EndTabItem()
        {
            ImGuiNative.ImGui_EndTabItem();
        }
        public static void EndTable()
        {
            ImGuiNative.ImGui_EndTable();
        }
        public static void EndTooltip()
        {
            ImGuiNative.ImGui_EndTooltip();
        }
        public static ImGuiViewportPtr FindViewportByID(uint id)
        {
            ImGuiViewport* ret = ImGuiNative.ImGui_FindViewportByID(id);
            return new ImGuiViewportPtr(ret);
        }
        public static ImGuiViewportPtr FindViewportByPlatformHandle(IntPtr platform_handle)
        {
            void* native_platform_handle = (void*)platform_handle.ToPointer();
            ImGuiViewport* ret = ImGuiNative.ImGui_FindViewportByPlatformHandle(native_platform_handle);
            return new ImGuiViewportPtr(ret);
        }
        public static void GetAllocatorFunctions(ref IntPtr p_alloc_func, ref IntPtr p_free_func, ref void* p_user_data)
        {
            fixed (IntPtr* native_p_alloc_func = &p_alloc_func)
            {
                fixed (IntPtr* native_p_free_func = &p_free_func)
                {
                    fixed (void** native_p_user_data = &p_user_data)
                    {
                        ImGuiNative.ImGui_GetAllocatorFunctions(native_p_alloc_func, native_p_free_func, native_p_user_data);
                    }
                }
            }
        }
        public static ImDrawListPtr GetBackgroundDrawList()
        {
            ImDrawList* ret = ImGuiNative.ImGui_GetBackgroundDrawList_Nil();
            return new ImDrawListPtr(ret);
        }
        public static ImDrawListPtr GetBackgroundDrawList(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImDrawList* ret = ImGuiNative.ImGui_GetBackgroundDrawList_ViewportPtr(native_viewport);
            return new ImDrawListPtr(ret);
        }
        public static string GetClipboardText()
        {
            byte* ret = ImGuiNative.ImGui_GetClipboardText();
            return Util.StringFromPtr(ret);
        }
        public static uint GetColorU32(ImGuiCol idx)
        {
            float alpha_mul = 1.0f;
            uint ret = ImGuiNative.ImGui_GetColorU32_Col(idx, alpha_mul);
            return ret;
        }
        public static uint GetColorU32(ImGuiCol idx, float alpha_mul)
        {
            uint ret = ImGuiNative.ImGui_GetColorU32_Col(idx, alpha_mul);
            return ret;
        }
        public static uint GetColorU32(Vector4 col)
        {
            uint ret = ImGuiNative.ImGui_GetColorU32_Vec4(col);
            return ret;
        }
        public static uint GetColorU32(uint col)
        {
            uint ret = ImGuiNative.ImGui_GetColorU32_U32(col);
            return ret;
        }
        public static int GetColumnIndex()
        {
            int ret = ImGuiNative.ImGui_GetColumnIndex();
            return ret;
        }
        public static float GetColumnOffset()
        {
            int column_index = -1;
            float ret = ImGuiNative.ImGui_GetColumnOffset(column_index);
            return ret;
        }
        public static float GetColumnOffset(int column_index)
        {
            float ret = ImGuiNative.ImGui_GetColumnOffset(column_index);
            return ret;
        }
        public static int GetColumnsCount()
        {
            int ret = ImGuiNative.ImGui_GetColumnsCount();
            return ret;
        }
        public static float GetColumnWidth()
        {
            int column_index = -1;
            float ret = ImGuiNative.ImGui_GetColumnWidth(column_index);
            return ret;
        }
        public static float GetColumnWidth(int column_index)
        {
            float ret = ImGuiNative.ImGui_GetColumnWidth(column_index);
            return ret;
        }
        public static Vector2 GetContentRegionAvail()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetContentRegionAvail(&__retval);
            return __retval;
        }
        public static Vector2 GetContentRegionMax()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetContentRegionMax(&__retval);
            return __retval;
        }
        public static IntPtr GetCurrentContext()
        {
            IntPtr ret = ImGuiNative.ImGui_GetCurrentContext();
            return ret;
        }
        public static Vector2 GetCursorPos()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetCursorPos(&__retval);
            return __retval;
        }
        public static float GetCursorPosX()
        {
            float ret = ImGuiNative.ImGui_GetCursorPosX();
            return ret;
        }
        public static float GetCursorPosY()
        {
            float ret = ImGuiNative.ImGui_GetCursorPosY();
            return ret;
        }
        public static Vector2 GetCursorScreenPos()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetCursorScreenPos(&__retval);
            return __retval;
        }
        public static Vector2 GetCursorStartPos()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetCursorStartPos(&__retval);
            return __retval;
        }
        public static ImGuiPayloadPtr GetDragDropPayload()
        {
            ImGuiPayload* ret = ImGuiNative.ImGui_GetDragDropPayload();
            return new ImGuiPayloadPtr(ret);
        }
        public static ImDrawDataPtr GetDrawData()
        {
            ImDrawData* ret = ImGuiNative.ImGui_GetDrawData();
            return new ImDrawDataPtr(ret);
        }
        public static IntPtr GetDrawListSharedData()
        {
            IntPtr ret = ImGuiNative.ImGui_GetDrawListSharedData();
            return ret;
        }
        public static ImFontPtr GetFont()
        {
            ImFont* ret = ImGuiNative.ImGui_GetFont();
            return new ImFontPtr(ret);
        }
        public static float GetFontSize()
        {
            float ret = ImGuiNative.ImGui_GetFontSize();
            return ret;
        }
        public static Vector2 GetFontTexUvWhitePixel()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetFontTexUvWhitePixel(&__retval);
            return __retval;
        }
        public static ImDrawListPtr GetForegroundDrawList()
        {
            ImDrawList* ret = ImGuiNative.ImGui_GetForegroundDrawList_Nil();
            return new ImDrawListPtr(ret);
        }
        public static ImDrawListPtr GetForegroundDrawList(ImGuiViewportPtr viewport)
        {
            ImGuiViewport* native_viewport = viewport.NativePtr;
            ImDrawList* ret = ImGuiNative.ImGui_GetForegroundDrawList_ViewportPtr(native_viewport);
            return new ImDrawListPtr(ret);
        }
        public static int GetFrameCount()
        {
            int ret = ImGuiNative.ImGui_GetFrameCount();
            return ret;
        }
        public static float GetFrameHeight()
        {
            float ret = ImGuiNative.ImGui_GetFrameHeight();
            return ret;
        }
        public static float GetFrameHeightWithSpacing()
        {
            float ret = ImGuiNative.ImGui_GetFrameHeightWithSpacing();
            return ret;
        }
#if ANDROID
        public static uint GetID(ReadOnlySpan<char> str_id)
#else
        public static uint GetID(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            uint ret = ImGuiNative.ImGui_GetID_Str(native_str_id);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret;
        }
        public static uint GetID(IntPtr ptr_id)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            uint ret = ImGuiNative.ImGui_GetID_Ptr(native_ptr_id);
            return ret;
        }
        public static ImGuiIOPtr GetIO()
        {
            ImGuiIO* ret = ImGuiNative.ImGui_GetIO();
            return new ImGuiIOPtr(ret);
        }
        public static uint GetItemID()
        {
            uint ret = ImGuiNative.ImGui_GetItemID();
            return ret;
        }
        public static Vector2 GetItemRectMax()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetItemRectMax(&__retval);
            return __retval;
        }
        public static Vector2 GetItemRectMin()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetItemRectMin(&__retval);
            return __retval;
        }
        public static Vector2 GetItemRectSize()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetItemRectSize(&__retval);
            return __retval;
        }
        public static ImGuiKey GetKeyIndex(ImGuiKey key)
        {
            ImGuiKey ret = ImGuiNative.ImGui_GetKeyIndex(key);
            return ret;
        }
        public static string GetKeyName(ImGuiKey key)
        {
            byte* ret = ImGuiNative.ImGui_GetKeyName(key);
            return Util.StringFromPtr(ret);
        }
        public static int GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate)
        {
            int ret = ImGuiNative.ImGui_GetKeyPressedAmount(key, repeat_delay, rate);
            return ret;
        }
        public static ImGuiViewportPtr GetMainViewport()
        {
            ImGuiViewport* ret = ImGuiNative.ImGui_GetMainViewport();
            return new ImGuiViewportPtr(ret);
        }
        public static int GetMouseClickedCount(ImGuiMouseButton button)
        {
            int ret = ImGuiNative.ImGui_GetMouseClickedCount(button);
            return ret;
        }
        public static ImGuiMouseCursor GetMouseCursor()
        {
            ImGuiMouseCursor ret = ImGuiNative.ImGui_GetMouseCursor();
            return ret;
        }
        public static Vector2 GetMouseDragDelta()
        {
            Vector2 __retval;
            ImGuiMouseButton button = (ImGuiMouseButton)0;
            float lock_threshold = -1.0f;
            ImGuiNative.ImGui_GetMouseDragDelta(&__retval, button, lock_threshold);
            return __retval;
        }
        public static Vector2 GetMouseDragDelta(ImGuiMouseButton button)
        {
            Vector2 __retval;
            float lock_threshold = -1.0f;
            ImGuiNative.ImGui_GetMouseDragDelta(&__retval, button, lock_threshold);
            return __retval;
        }
        public static Vector2 GetMouseDragDelta(ImGuiMouseButton button, float lock_threshold)
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetMouseDragDelta(&__retval, button, lock_threshold);
            return __retval;
        }
        public static Vector2 GetMousePos()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetMousePos(&__retval);
            return __retval;
        }
        public static Vector2 GetMousePosOnOpeningCurrentPopup()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetMousePosOnOpeningCurrentPopup(&__retval);
            return __retval;
        }
        public static ImGuiPlatformIOPtr GetPlatformIO()
        {
            ImGuiPlatformIO* ret = ImGuiNative.ImGui_GetPlatformIO();
            return new ImGuiPlatformIOPtr(ret);
        }
        public static float GetScrollMaxX()
        {
            float ret = ImGuiNative.ImGui_GetScrollMaxX();
            return ret;
        }
        public static float GetScrollMaxY()
        {
            float ret = ImGuiNative.ImGui_GetScrollMaxY();
            return ret;
        }
        public static float GetScrollX()
        {
            float ret = ImGuiNative.ImGui_GetScrollX();
            return ret;
        }
        public static float GetScrollY()
        {
            float ret = ImGuiNative.ImGui_GetScrollY();
            return ret;
        }
        public static ImGuiStoragePtr GetStateStorage()
        {
            ImGuiStorage* ret = ImGuiNative.ImGui_GetStateStorage();
            return new ImGuiStoragePtr(ret);
        }
        public static ImGuiStylePtr GetStyle()
        {
            ImGuiStyle* ret = ImGuiNative.ImGui_GetStyle();
            return new ImGuiStylePtr(ret);
        }
        public static string GetStyleColorName(ImGuiCol idx)
        {
            byte* ret = ImGuiNative.ImGui_GetStyleColorName(idx);
            return Util.StringFromPtr(ret);
        }
        public static Vector4* GetStyleColorVec4(ImGuiCol idx)
        {
            Vector4* ret = ImGuiNative.ImGui_GetStyleColorVec4(idx);
            return ret;
        }
        public static float GetTextLineHeight()
        {
            float ret = ImGuiNative.ImGui_GetTextLineHeight();
            return ret;
        }
        public static float GetTextLineHeightWithSpacing()
        {
            float ret = ImGuiNative.ImGui_GetTextLineHeightWithSpacing();
            return ret;
        }
        public static double GetTime()
        {
            double ret = ImGuiNative.ImGui_GetTime();
            return ret;
        }
        public static float GetTreeNodeToLabelSpacing()
        {
            float ret = ImGuiNative.ImGui_GetTreeNodeToLabelSpacing();
            return ret;
        }
        public static string GetVersion()
        {
            byte* ret = ImGuiNative.ImGui_GetVersion();
            return Util.StringFromPtr(ret);
        }
        public static Vector2 GetWindowContentRegionMax()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetWindowContentRegionMax(&__retval);
            return __retval;
        }
        public static Vector2 GetWindowContentRegionMin()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetWindowContentRegionMin(&__retval);
            return __retval;
        }
        public static uint GetWindowDockID()
        {
            uint ret = ImGuiNative.ImGui_GetWindowDockID();
            return ret;
        }
        public static float GetWindowDpiScale()
        {
            float ret = ImGuiNative.ImGui_GetWindowDpiScale();
            return ret;
        }
        public static ImDrawListPtr GetWindowDrawList()
        {
            ImDrawList* ret = ImGuiNative.ImGui_GetWindowDrawList();
            return new ImDrawListPtr(ret);
        }
        public static float GetWindowHeight()
        {
            float ret = ImGuiNative.ImGui_GetWindowHeight();
            return ret;
        }
        public static Vector2 GetWindowPos()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetWindowPos(&__retval);
            return __retval;
        }
        public static Vector2 GetWindowSize()
        {
            Vector2 __retval;
            ImGuiNative.ImGui_GetWindowSize(&__retval);
            return __retval;
        }
        public static ImGuiViewportPtr GetWindowViewport()
        {
            ImGuiViewport* ret = ImGuiNative.ImGui_GetWindowViewport();
            return new ImGuiViewportPtr(ret);
        }
        public static float GetWindowWidth()
        {
            float ret = ImGuiNative.ImGui_GetWindowWidth();
            return ret;
        }
        public static void Image(IntPtr user_texture_id, Vector2 size)
        {
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            Vector4 border_col = new Vector4();
            ImGuiNative.ImGui_Image(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0)
        {
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            Vector4 border_col = new Vector4();
            ImGuiNative.ImGui_Image(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1)
        {
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            Vector4 border_col = new Vector4();
            ImGuiNative.ImGui_Image(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col)
        {
            Vector4 border_col = new Vector4();
            ImGuiNative.ImGui_Image(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col)
        {
            ImGuiNative.ImGui_Image(user_texture_id, size, uv0, uv1, tint_col, border_col);
        }
#if ANDROID
        public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 size)
#else
        public static bool ImageButton(string str_id, IntPtr user_texture_id, Vector2 size)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 bg_col = new Vector4();
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.ImGui_ImageButton(native_str_id, user_texture_id, size, uv0, uv1, bg_col, tint_col);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0)
#else
        public static bool ImageButton(string str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 bg_col = new Vector4();
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.ImGui_ImageButton(native_str_id, user_texture_id, size, uv0, uv1, bg_col, tint_col);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1)
#else
        public static bool ImageButton(string str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector4 bg_col = new Vector4();
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.ImGui_ImageButton(native_str_id, user_texture_id, size, uv0, uv1, bg_col, tint_col);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 bg_col)
#else
        public static bool ImageButton(string str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 bg_col)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            byte ret = ImGuiNative.ImGui_ImageButton(native_str_id, user_texture_id, size, uv0, uv1, bg_col, tint_col);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col)
#else
        public static bool ImageButton(string str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_ImageButton(native_str_id, user_texture_id, size, uv0, uv1, bg_col, tint_col);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static void Indent()
        {
            float indent_w = 0.0f;
            ImGuiNative.ImGui_Indent(indent_w);
        }
        public static void Indent(float indent_w)
        {
            ImGuiNative.ImGui_Indent(indent_w);
        }
#if ANDROID
        public static bool InputDouble(ReadOnlySpan<char> label, ref double v)
#else
        public static bool InputDouble(string label, ref double v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            double step = 0.0;
            double step_fast = 0.0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.6f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step)
#else
        public static bool InputDouble(string label, ref double v, double step)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            double step_fast = 0.0;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.6f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double step_fast)
#else
        public static bool InputDouble(string label, ref double v, double step, double step_fast)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.6f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double step_fast, ReadOnlySpan<char> format)
#else
        public static bool InputDouble(string label, ref double v, double step, double step_fast, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
#else
        public static bool InputDouble(string label, ref double v, double step, double step_fast, string format, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (double* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputDouble(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat(ReadOnlySpan<char> label, ref float v)
#else
        public static bool InputFloat(string label, ref float v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float step = 0.0f;
            float step_fast = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step)
#else
        public static bool InputFloat(string label, ref float v, float step)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float step_fast = 0.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float step_fast)
#else
        public static bool InputFloat(string label, ref float v, float step, float step_fast)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float step_fast, ReadOnlySpan<char> format)
#else
        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
#else
        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat(native_label, native_v, step, step_fast, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v)
#else
        public static bool InputFloat2(string label, ref Vector2 v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat2(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v, ReadOnlySpan<char> format)
#else
        public static bool InputFloat2(string label, ref Vector2 v, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat2(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
#else
        public static bool InputFloat2(string label, ref Vector2 v, string format, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat2(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v)
#else
        public static bool InputFloat3(string label, ref Vector3 v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat3(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v, ReadOnlySpan<char> format)
#else
        public static bool InputFloat3(string label, ref Vector3 v, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat3(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
#else
        public static bool InputFloat3(string label, ref Vector3 v, string format, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat3(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v)
#else
        public static bool InputFloat4(string label, ref Vector4 v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat4(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v, ReadOnlySpan<char> format)
#else
        public static bool InputFloat4(string label, ref Vector4 v, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat4(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
#else
        public static bool InputFloat4(string label, ref Vector4 v, string format, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputFloat4(native_label, native_v, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt(ReadOnlySpan<char> label, ref int v)
#else
        public static bool InputInt(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int step = 1;
            int step_fast = 100;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step)
#else
        public static bool InputInt(string label, ref int v, int step)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int step_fast = 100;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step, int step_fast)
#else
        public static bool InputInt(string label, ref int v, int step, int step_fast)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step, int step_fast, ImGuiInputTextFlags flags)
#else
        public static bool InputInt(string label, ref int v, int step, int step_fast, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt(native_label, native_v, step, step_fast, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt2(ReadOnlySpan<char> label, ref int v)
#else
        public static bool InputInt2(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt2(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt2(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
#else
        public static bool InputInt2(string label, ref int v, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt2(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt3(ReadOnlySpan<char> label, ref int v)
#else
        public static bool InputInt3(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt3(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt3(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
#else
        public static bool InputInt3(string label, ref int v, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt3(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt4(ReadOnlySpan<char> label, ref int v)
#else
        public static bool InputInt4(string label, ref int v)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt4(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputInt4(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
#else
        public static bool InputInt4(string label, ref int v, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_InputInt4(native_label, native_v, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data)
#else
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_step = null;
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalar(native_label, data_type, native_p_data, p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step)
#else
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalar(native_label, data_type, native_p_data, native_p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast)
#else
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalar(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format)
#else
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalar(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
#else
        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, string format, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.ImGui_InputScalar(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components)
#else
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* p_step = null;
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalarN(native_label, data_type, native_p_data, components, p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step)
#else
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* p_step_fast = null;
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalarN(native_label, data_type, native_p_data, components, native_p_step, p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast)
#else
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format = null;
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalarN(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format)
#else
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;
            byte ret = ImGuiNative.ImGui_InputScalarN(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
#else
        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, string format, ImGuiInputTextFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_step = (void*)p_step.ToPointer();
            void* native_p_step_fast = (void*)p_step_fast.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.ImGui_InputScalarN(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InvisibleButton(ReadOnlySpan<char> str_id, Vector2 size)
#else
        public static bool InvisibleButton(string str_id, Vector2 size)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiButtonFlags flags = (ImGuiButtonFlags)0;
            byte ret = ImGuiNative.ImGui_InvisibleButton(native_str_id, size, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool InvisibleButton(ReadOnlySpan<char> str_id, Vector2 size, ImGuiButtonFlags flags)
#else
        public static bool InvisibleButton(string str_id, Vector2 size, ImGuiButtonFlags flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_InvisibleButton(native_str_id, size, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool IsAnyItemActive()
        {
            byte ret = ImGuiNative.ImGui_IsAnyItemActive();
            return ret != 0;
        }
        public static bool IsAnyItemFocused()
        {
            byte ret = ImGuiNative.ImGui_IsAnyItemFocused();
            return ret != 0;
        }
        public static bool IsAnyItemHovered()
        {
            byte ret = ImGuiNative.ImGui_IsAnyItemHovered();
            return ret != 0;
        }
        public static bool IsAnyMouseDown()
        {
            byte ret = ImGuiNative.ImGui_IsAnyMouseDown();
            return ret != 0;
        }
        public static bool IsItemActivated()
        {
            byte ret = ImGuiNative.ImGui_IsItemActivated();
            return ret != 0;
        }
        public static bool IsItemActive()
        {
            byte ret = ImGuiNative.ImGui_IsItemActive();
            return ret != 0;
        }
        public static bool IsItemClicked()
        {
            ImGuiMouseButton mouse_button = (ImGuiMouseButton)0;
            byte ret = ImGuiNative.ImGui_IsItemClicked(mouse_button);
            return ret != 0;
        }
        public static bool IsItemClicked(ImGuiMouseButton mouse_button)
        {
            byte ret = ImGuiNative.ImGui_IsItemClicked(mouse_button);
            return ret != 0;
        }
        public static bool IsItemDeactivated()
        {
            byte ret = ImGuiNative.ImGui_IsItemDeactivated();
            return ret != 0;
        }
        public static bool IsItemDeactivatedAfterEdit()
        {
            byte ret = ImGuiNative.ImGui_IsItemDeactivatedAfterEdit();
            return ret != 0;
        }
        public static bool IsItemEdited()
        {
            byte ret = ImGuiNative.ImGui_IsItemEdited();
            return ret != 0;
        }
        public static bool IsItemFocused()
        {
            byte ret = ImGuiNative.ImGui_IsItemFocused();
            return ret != 0;
        }
        public static bool IsItemHovered()
        {
            ImGuiHoveredFlags flags = (ImGuiHoveredFlags)0;
            byte ret = ImGuiNative.ImGui_IsItemHovered(flags);
            return ret != 0;
        }
        public static bool IsItemHovered(ImGuiHoveredFlags flags)
        {
            byte ret = ImGuiNative.ImGui_IsItemHovered(flags);
            return ret != 0;
        }
        public static bool IsItemToggledOpen()
        {
            byte ret = ImGuiNative.ImGui_IsItemToggledOpen();
            return ret != 0;
        }
        public static bool IsItemVisible()
        {
            byte ret = ImGuiNative.ImGui_IsItemVisible();
            return ret != 0;
        }
        public static bool IsKeyDown(ImGuiKey key)
        {
            byte ret = ImGuiNative.ImGui_IsKeyDown_Nil(key);
            return ret != 0;
        }
        public static bool IsKeyPressed(ImGuiKey key)
        {
            byte repeat = 1;
            byte ret = ImGuiNative.ImGui_IsKeyPressed_Bool(key, repeat);
            return ret != 0;
        }
        public static bool IsKeyPressed(ImGuiKey key, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_IsKeyPressed_Bool(key, native_repeat);
            return ret != 0;
        }
        public static bool IsKeyReleased(ImGuiKey key)
        {
            byte ret = ImGuiNative.ImGui_IsKeyReleased_Nil(key);
            return ret != 0;
        }
        public static bool IsMouseClicked(ImGuiMouseButton button)
        {
            byte repeat = 0;
            byte ret = ImGuiNative.ImGui_IsMouseClicked_Bool(button, repeat);
            return ret != 0;
        }
        public static bool IsMouseClicked(ImGuiMouseButton button, bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_IsMouseClicked_Bool(button, native_repeat);
            return ret != 0;
        }
        public static bool IsMouseDoubleClicked(ImGuiMouseButton button)
        {
            byte ret = ImGuiNative.ImGui_IsMouseDoubleClicked(button);
            return ret != 0;
        }
        public static bool IsMouseDown(ImGuiMouseButton button)
        {
            byte ret = ImGuiNative.ImGui_IsMouseDown_Nil(button);
            return ret != 0;
        }
        public static bool IsMouseDragging(ImGuiMouseButton button)
        {
            float lock_threshold = -1.0f;
            byte ret = ImGuiNative.ImGui_IsMouseDragging(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsMouseDragging(ImGuiMouseButton button, float lock_threshold)
        {
            byte ret = ImGuiNative.ImGui_IsMouseDragging(button, lock_threshold);
            return ret != 0;
        }
        public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max)
        {
            byte clip = 1;
            byte ret = ImGuiNative.ImGui_IsMouseHoveringRect(r_min, r_max, clip);
            return ret != 0;
        }
        public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max, bool clip)
        {
            byte native_clip = clip ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_IsMouseHoveringRect(r_min, r_max, native_clip);
            return ret != 0;
        }
        public static bool IsMousePosValid()
        {
            Vector2* mouse_pos = null;
            byte ret = ImGuiNative.ImGui_IsMousePosValid(mouse_pos);
            return ret != 0;
        }
        public static bool IsMousePosValid(ref Vector2 mouse_pos)
        {
            fixed (Vector2* native_mouse_pos = &mouse_pos)
            {
                byte ret = ImGuiNative.ImGui_IsMousePosValid(native_mouse_pos);
                return ret != 0;
            }
        }
        public static bool IsMouseReleased(ImGuiMouseButton button)
        {
            byte ret = ImGuiNative.ImGui_IsMouseReleased_Nil(button);
            return ret != 0;
        }
#if ANDROID
        public static bool IsPopupOpen(ReadOnlySpan<char> str_id)
#else
        public static bool IsPopupOpen(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags flags = (ImGuiPopupFlags)0;
            byte ret = ImGuiNative.ImGui_IsPopupOpen_Str(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool IsPopupOpen(ReadOnlySpan<char> str_id, ImGuiPopupFlags flags)
#else
        public static bool IsPopupOpen(string str_id, ImGuiPopupFlags flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte ret = ImGuiNative.ImGui_IsPopupOpen_Str(native_str_id, flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            return ret != 0;
        }
        public static bool IsRectVisible(Vector2 size)
        {
            byte ret = ImGuiNative.ImGui_IsRectVisible_Nil(size);
            return ret != 0;
        }
        public static bool IsRectVisible(Vector2 rect_min, Vector2 rect_max)
        {
            byte ret = ImGuiNative.ImGui_IsRectVisible_Vec2(rect_min, rect_max);
            return ret != 0;
        }
        public static bool IsWindowAppearing()
        {
            byte ret = ImGuiNative.ImGui_IsWindowAppearing();
            return ret != 0;
        }
        public static bool IsWindowCollapsed()
        {
            byte ret = ImGuiNative.ImGui_IsWindowCollapsed();
            return ret != 0;
        }
        public static bool IsWindowDocked()
        {
            byte ret = ImGuiNative.ImGui_IsWindowDocked();
            return ret != 0;
        }
        public static bool IsWindowFocused()
        {
            ImGuiFocusedFlags flags = (ImGuiFocusedFlags)0;
            byte ret = ImGuiNative.ImGui_IsWindowFocused(flags);
            return ret != 0;
        }
        public static bool IsWindowFocused(ImGuiFocusedFlags flags)
        {
            byte ret = ImGuiNative.ImGui_IsWindowFocused(flags);
            return ret != 0;
        }
        public static bool IsWindowHovered()
        {
            ImGuiHoveredFlags flags = (ImGuiHoveredFlags)0;
            byte ret = ImGuiNative.ImGui_IsWindowHovered(flags);
            return ret != 0;
        }
        public static bool IsWindowHovered(ImGuiHoveredFlags flags)
        {
            byte ret = ImGuiNative.ImGui_IsWindowHovered(flags);
            return ret != 0;
        }
#if ANDROID
        public static void LabelText(ReadOnlySpan<char> label, ReadOnlySpan<char> fmt)
#else
        public static void LabelText(string label, string fmt)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_LabelText(native_label, native_fmt);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
#if ANDROID
        public static bool ListBox(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count)
#else
        public static bool ListBox(string label, ref int current_item, string[] items, int items_count)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    native_items_data[offset] = 0;
                    offset += 1;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            int height_in_items = -1;
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.ImGui_ListBox_Str_arr(native_label, native_current_item, native_items, items_count, height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool ListBox(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count, int height_in_items)
#else
        public static bool ListBox(string label, ref int current_item, string[] items, int items_count, int height_in_items)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int* items_byteCounts = stackalloc int[items.Length];
            int items_byteCount = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                items_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                items_byteCount += items_byteCounts[i] + 1;
            }
            byte* native_items_data = stackalloc byte[items_byteCount];
            int offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                string s = items[i];
                fixed (char* sPtr = s)
                {
                    offset += Encoding.UTF8.GetBytes(sPtr, s.Length, native_items_data + offset, items_byteCounts[i]);
                    native_items_data[offset] = 0;
                    offset += 1;
                }
            }
            byte** native_items = stackalloc byte*[items.Length];
            offset = 0;
            for (int i = 0; i < items.Length; i++)
            {
                native_items[i] = &native_items_data[offset];
                offset += items_byteCounts[i] + 1;
            }
            fixed (int* native_current_item = &current_item)
            {
                byte ret = ImGuiNative.ImGui_ListBox_Str_arr(native_label, native_current_item, native_items, items_count, height_in_items);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static void LoadIniSettingsFromDisk(ReadOnlySpan<char> ini_filename)
#else
        public static void LoadIniSettingsFromDisk(string ini_filename)
#endif
        {
            byte* native_ini_filename;
            int ini_filename_byteCount = 0;
            if (ini_filename != null)
            {
                ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
                if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_filename = Util.Allocate(ini_filename_byteCount + 1);
                }
                else
                {
                    byte* native_ini_filename_stackBytes = stackalloc byte[ini_filename_byteCount + 1];
                    native_ini_filename = native_ini_filename_stackBytes;
                }
                int native_ini_filename_offset = Util.GetUtf8(ini_filename, native_ini_filename, ini_filename_byteCount);
                native_ini_filename[native_ini_filename_offset] = 0;
            }
            else { native_ini_filename = null; }
            ImGuiNative.ImGui_LoadIniSettingsFromDisk(native_ini_filename);
            if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_filename);
            }
        }
#if ANDROID
        public static void LoadIniSettingsFromMemory(ReadOnlySpan<char> ini_data)
#else
        public static void LoadIniSettingsFromMemory(string ini_data)
#endif
        {
            byte* native_ini_data;
            int ini_data_byteCount = 0;
            if (ini_data != null)
            {
                ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
                if (ini_data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_data = Util.Allocate(ini_data_byteCount + 1);
                }
                else
                {
                    byte* native_ini_data_stackBytes = stackalloc byte[ini_data_byteCount + 1];
                    native_ini_data = native_ini_data_stackBytes;
                }
                int native_ini_data_offset = Util.GetUtf8(ini_data, native_ini_data, ini_data_byteCount);
                native_ini_data[native_ini_data_offset] = 0;
            }
            else { native_ini_data = null; }
            uint ini_size = 0;
            ImGuiNative.ImGui_LoadIniSettingsFromMemory(native_ini_data, ini_size);
            if (ini_data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_data);
            }
        }
#if ANDROID
        public static void LoadIniSettingsFromMemory(ReadOnlySpan<char> ini_data, uint ini_size)
#else
        public static void LoadIniSettingsFromMemory(string ini_data, uint ini_size)
#endif
        {
            byte* native_ini_data;
            int ini_data_byteCount = 0;
            if (ini_data != null)
            {
                ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
                if (ini_data_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_data = Util.Allocate(ini_data_byteCount + 1);
                }
                else
                {
                    byte* native_ini_data_stackBytes = stackalloc byte[ini_data_byteCount + 1];
                    native_ini_data = native_ini_data_stackBytes;
                }
                int native_ini_data_offset = Util.GetUtf8(ini_data, native_ini_data, ini_data_byteCount);
                native_ini_data[native_ini_data_offset] = 0;
            }
            else { native_ini_data = null; }
            ImGuiNative.ImGui_LoadIniSettingsFromMemory(native_ini_data, ini_size);
            if (ini_data_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_data);
            }
        }
        public static void LogButtons()
        {
            ImGuiNative.ImGui_LogButtons();
        }
        public static void LogFinish()
        {
            ImGuiNative.ImGui_LogFinish();
        }
#if ANDROID
        public static void LogText(ReadOnlySpan<char> fmt)
#else
        public static void LogText(string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_LogText(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void LogToClipboard()
        {
            int auto_open_depth = -1;
            ImGuiNative.ImGui_LogToClipboard(auto_open_depth);
        }
        public static void LogToClipboard(int auto_open_depth)
        {
            ImGuiNative.ImGui_LogToClipboard(auto_open_depth);
        }
        public static void LogToFile()
        {
            int auto_open_depth = -1;
            byte* native_filename = null;
            ImGuiNative.ImGui_LogToFile(auto_open_depth, native_filename);
        }
        public static void LogToFile(int auto_open_depth)
        {
            byte* native_filename = null;
            ImGuiNative.ImGui_LogToFile(auto_open_depth, native_filename);
        }
#if ANDROID
        public static void LogToFile(int auto_open_depth, ReadOnlySpan<char> filename)
#else
        public static void LogToFile(int auto_open_depth, string filename)
#endif
        {
            byte* native_filename;
            int filename_byteCount = 0;
            if (filename != null)
            {
                filename_byteCount = Encoding.UTF8.GetByteCount(filename);
                if (filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_filename = Util.Allocate(filename_byteCount + 1);
                }
                else
                {
                    byte* native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
                    native_filename = native_filename_stackBytes;
                }
                int native_filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
                native_filename[native_filename_offset] = 0;
            }
            else { native_filename = null; }
            ImGuiNative.ImGui_LogToFile(auto_open_depth, native_filename);
            if (filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_filename);
            }
        }
        public static void LogToTTY()
        {
            int auto_open_depth = -1;
            ImGuiNative.ImGui_LogToTTY(auto_open_depth);
        }
        public static void LogToTTY(int auto_open_depth)
        {
            ImGuiNative.ImGui_LogToTTY(auto_open_depth);
        }
        public static IntPtr MemAlloc(uint size)
        {
            void* ret = ImGuiNative.ImGui_MemAlloc(size);
            return (IntPtr)ret;
        }
        public static void MemFree(IntPtr ptr)
        {
            void* native_ptr = (void*)ptr.ToPointer();
            ImGuiNative.ImGui_MemFree(native_ptr);
        }
#if ANDROID
        public static bool MenuItem(ReadOnlySpan<char> label)
#else
        public static bool MenuItem(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut = null;
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNative.ImGui_MenuItem_Bool(native_label, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut)
#else
        public static bool MenuItem(string label, string shortcut)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte selected = 0;
            byte enabled = 1;
            byte ret = ImGuiNative.ImGui_MenuItem_Bool(native_label, native_shortcut, selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, bool selected)
#else
        public static bool MenuItem(string label, string shortcut, bool selected)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte enabled = 1;
            byte ret = ImGuiNative.ImGui_MenuItem_Bool(native_label, native_shortcut, native_selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, bool selected, bool enabled)
#else
        public static bool MenuItem(string label, string shortcut, bool selected, bool enabled)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_MenuItem_Bool(native_label, native_shortcut, native_selected, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, ref bool p_selected)
#else
        public static bool MenuItem(string label, string shortcut, ref bool p_selected)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte enabled = 1;
            byte ret = ImGuiNative.ImGui_MenuItem_BoolPtr(native_label, native_shortcut, native_p_selected, enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, ref bool p_selected, bool enabled)
#else
        public static bool MenuItem(string label, string shortcut, ref bool p_selected, bool enabled)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_shortcut;
            int shortcut_byteCount = 0;
            if (shortcut != null)
            {
                shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
                if (shortcut_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_shortcut = Util.Allocate(shortcut_byteCount + 1);
                }
                else
                {
                    byte* native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
                    native_shortcut = native_shortcut_stackBytes;
                }
                int native_shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
                native_shortcut[native_shortcut_offset] = 0;
            }
            else { native_shortcut = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte native_enabled = enabled ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_MenuItem_BoolPtr(native_label, native_shortcut, native_p_selected, native_enabled);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (shortcut_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_shortcut);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static void NewFrame()
        {
            ImGuiNative.ImGui_NewFrame();
        }
        public static void NewLine()
        {
            ImGuiNative.ImGui_NewLine();
        }
        public static void NextColumn()
        {
            ImGuiNative.ImGui_NextColumn();
        }
#if ANDROID
        public static void OpenPopup(ReadOnlySpan<char> str_id)
#else
        public static void OpenPopup(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)0;
            ImGuiNative.ImGui_OpenPopup_Str(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
#if ANDROID
        public static void OpenPopup(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
#else
        public static void OpenPopup(string str_id, ImGuiPopupFlags popup_flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.ImGui_OpenPopup_Str(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void OpenPopup(uint id)
        {
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)0;
            ImGuiNative.ImGui_OpenPopup_ID(id, popup_flags);
        }
        public static void OpenPopup(uint id, ImGuiPopupFlags popup_flags)
        {
            ImGuiNative.ImGui_OpenPopup_ID(id, popup_flags);
        }
        public static void OpenPopupOnItemClick()
        {
            byte* native_str_id = null;
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            ImGuiNative.ImGui_OpenPopupOnItemClick(native_str_id, popup_flags);
        }
#if ANDROID
        public static void OpenPopupOnItemClick(ReadOnlySpan<char> str_id)
#else
        public static void OpenPopupOnItemClick(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;
            ImGuiNative.ImGui_OpenPopupOnItemClick(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
#if ANDROID
        public static void OpenPopupOnItemClick(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
#else
        public static void OpenPopupOnItemClick(string str_id, ImGuiPopupFlags popup_flags)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.ImGui_OpenPopupOnItemClick(native_str_id, popup_flags);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
#if ANDROID
        public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int values_count)
#else
        public static void PlotHistogram(string label, ref float values, int values_count)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int values_offset = 0;
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
#if ANDROID
        public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset)
#else
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
#if ANDROID
        public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text)
#else
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min)
#else
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max)
#else
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size)
#else
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
#else
        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotHistogram_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotLines(ReadOnlySpan<char> label, ref float values, int values_count)
#else
        public static void PlotLines(string label, ref float values, int values_count)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            int values_offset = 0;
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
#if ANDROID
        public static void PlotLines(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset)
#else
        public static void PlotLines(string label, ref float values, int values_count, int values_offset)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text = null;
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
            }
        }
#if ANDROID
        public static void PlotLines(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text)
#else
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_min = float.MaxValue;
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotLines(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min)
#else
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            float scale_max = float.MaxValue;
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotLines(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max)
#else
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            Vector2 graph_size = new Vector2();
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotLines(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size)
#else
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            int stride = sizeof(float);
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
#if ANDROID
        public static void PlotLines(ReadOnlySpan<char> label, ref float values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
#else
        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_overlay_text;
            int overlay_text_byteCount = 0;
            if (overlay_text != null)
            {
                overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
                    native_overlay_text = native_overlay_text_stackBytes;
                }
                int native_overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
                native_overlay_text[native_overlay_text_offset] = 0;
            }
            else { native_overlay_text = null; }
            fixed (float* native_values = &values)
            {
                ImGuiNative.ImGui_PlotLines_FloatPtr(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_overlay_text);
                }
            }
        }
        public static void PopButtonRepeat()
        {
            ImGuiNative.ImGui_PopButtonRepeat();
        }
        public static void PopClipRect()
        {
            ImGuiNative.ImGui_PopClipRect();
        }
        public static void PopFont()
        {
            ImGuiNative.ImGui_PopFont();
        }
        public static void PopID()
        {
            ImGuiNative.ImGui_PopID();
        }
        public static void PopItemWidth()
        {
            ImGuiNative.ImGui_PopItemWidth();
        }
        public static void PopStyleColor()
        {
            int count = 1;
            ImGuiNative.ImGui_PopStyleColor(count);
        }
        public static void PopStyleColor(int count)
        {
            ImGuiNative.ImGui_PopStyleColor(count);
        }
        public static void PopStyleVar()
        {
            int count = 1;
            ImGuiNative.ImGui_PopStyleVar(count);
        }
        public static void PopStyleVar(int count)
        {
            ImGuiNative.ImGui_PopStyleVar(count);
        }
        public static void PopTabStop()
        {
            ImGuiNative.ImGui_PopTabStop();
        }
        public static void PopTextWrapPos()
        {
            ImGuiNative.ImGui_PopTextWrapPos();
        }
        public static void ProgressBar(float fraction)
        {
            Vector2 size_arg = new Vector2(-float.MinValue, 0.0f);
            byte* native_overlay = null;
            ImGuiNative.ImGui_ProgressBar(fraction, size_arg, native_overlay);
        }
        public static void ProgressBar(float fraction, Vector2 size_arg)
        {
            byte* native_overlay = null;
            ImGuiNative.ImGui_ProgressBar(fraction, size_arg, native_overlay);
        }
#if ANDROID
        public static void ProgressBar(float fraction, Vector2 size_arg, ReadOnlySpan<char> overlay)
#else
        public static void ProgressBar(float fraction, Vector2 size_arg, string overlay)
#endif
        {
            byte* native_overlay;
            int overlay_byteCount = 0;
            if (overlay != null)
            {
                overlay_byteCount = Encoding.UTF8.GetByteCount(overlay);
                if (overlay_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_overlay = Util.Allocate(overlay_byteCount + 1);
                }
                else
                {
                    byte* native_overlay_stackBytes = stackalloc byte[overlay_byteCount + 1];
                    native_overlay = native_overlay_stackBytes;
                }
                int native_overlay_offset = Util.GetUtf8(overlay, native_overlay, overlay_byteCount);
                native_overlay[native_overlay_offset] = 0;
            }
            else { native_overlay = null; }
            ImGuiNative.ImGui_ProgressBar(fraction, size_arg, native_overlay);
            if (overlay_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_overlay);
            }
        }
        public static void PushButtonRepeat(bool repeat)
        {
            byte native_repeat = repeat ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_PushButtonRepeat(native_repeat);
        }
        public static void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)
        {
            byte native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_PushClipRect(clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
        }
        public static void PushFont(ImFontPtr font)
        {
            ImFont* native_font = font.NativePtr;
            ImGuiNative.ImGui_PushFont(native_font);
        }
#if ANDROID
        public static void PushID(ReadOnlySpan<char> str_id)
#else
        public static void PushID(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.ImGui_PushID_Str(native_str_id);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void PushID(IntPtr ptr_id)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            ImGuiNative.ImGui_PushID_Ptr(native_ptr_id);
        }
        public static void PushID(int int_id)
        {
            ImGuiNative.ImGui_PushID_Int(int_id);
        }
        public static void PushItemWidth(float item_width)
        {
            ImGuiNative.ImGui_PushItemWidth(item_width);
        }
        public static void PushStyleColor(ImGuiCol idx, uint col)
        {
            ImGuiNative.ImGui_PushStyleColor_U32(idx, col);
        }
        public static void PushStyleColor(ImGuiCol idx, Vector4 col)
        {
            ImGuiNative.ImGui_PushStyleColor_Vec4(idx, col);
        }
        public static void PushStyleVar(ImGuiStyleVar idx, float val)
        {
            ImGuiNative.ImGui_PushStyleVar_Float(idx, val);
        }
        public static void PushStyleVar(ImGuiStyleVar idx, Vector2 val)
        {
            ImGuiNative.ImGui_PushStyleVar_Vec2(idx, val);
        }
        public static void PushTabStop(bool tab_stop)
        {
            byte native_tab_stop = tab_stop ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_PushTabStop(native_tab_stop);
        }
        public static void PushTextWrapPos()
        {
            float wrap_local_pos_x = 0.0f;
            ImGuiNative.ImGui_PushTextWrapPos(wrap_local_pos_x);
        }
        public static void PushTextWrapPos(float wrap_local_pos_x)
        {
            ImGuiNative.ImGui_PushTextWrapPos(wrap_local_pos_x);
        }
#if ANDROID
        public static bool RadioButton(ReadOnlySpan<char> label, bool active)
#else
        public static bool RadioButton(string label, bool active)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_active = active ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_RadioButton_Bool(native_label, native_active);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool RadioButton(ReadOnlySpan<char> label, ref int v, int v_button)
#else
        public static bool RadioButton(string label, ref int v, int v_button)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_RadioButton_IntPtr(native_label, native_v, v_button);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                return ret != 0;
            }
        }
        public static void Render()
        {
            ImGuiNative.ImGui_Render();
        }
        public static void RenderPlatformWindowsDefault()
        {
            void* platform_render_arg = null;
            void* renderer_render_arg = null;
            ImGuiNative.ImGui_RenderPlatformWindowsDefault(platform_render_arg, renderer_render_arg);
        }
        public static void RenderPlatformWindowsDefault(IntPtr platform_render_arg)
        {
            void* native_platform_render_arg = (void*)platform_render_arg.ToPointer();
            void* renderer_render_arg = null;
            ImGuiNative.ImGui_RenderPlatformWindowsDefault(native_platform_render_arg, renderer_render_arg);
        }
        public static void RenderPlatformWindowsDefault(IntPtr platform_render_arg, IntPtr renderer_render_arg)
        {
            void* native_platform_render_arg = (void*)platform_render_arg.ToPointer();
            void* native_renderer_render_arg = (void*)renderer_render_arg.ToPointer();
            ImGuiNative.ImGui_RenderPlatformWindowsDefault(native_platform_render_arg, native_renderer_render_arg);
        }
        public static void ResetMouseDragDelta()
        {
            ImGuiMouseButton button = (ImGuiMouseButton)0;
            ImGuiNative.ImGui_ResetMouseDragDelta(button);
        }
        public static void ResetMouseDragDelta(ImGuiMouseButton button)
        {
            ImGuiNative.ImGui_ResetMouseDragDelta(button);
        }
        public static void SameLine()
        {
            float offset_from_start_x = 0.0f;
            float spacing = -1.0f;
            ImGuiNative.ImGui_SameLine(offset_from_start_x, spacing);
        }
        public static void SameLine(float offset_from_start_x)
        {
            float spacing = -1.0f;
            ImGuiNative.ImGui_SameLine(offset_from_start_x, spacing);
        }
        public static void SameLine(float offset_from_start_x, float spacing)
        {
            ImGuiNative.ImGui_SameLine(offset_from_start_x, spacing);
        }
#if ANDROID
        public static void SaveIniSettingsToDisk(ReadOnlySpan<char> ini_filename)
#else
        public static void SaveIniSettingsToDisk(string ini_filename)
#endif
        {
            byte* native_ini_filename;
            int ini_filename_byteCount = 0;
            if (ini_filename != null)
            {
                ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
                if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_ini_filename = Util.Allocate(ini_filename_byteCount + 1);
                }
                else
                {
                    byte* native_ini_filename_stackBytes = stackalloc byte[ini_filename_byteCount + 1];
                    native_ini_filename = native_ini_filename_stackBytes;
                }
                int native_ini_filename_offset = Util.GetUtf8(ini_filename, native_ini_filename, ini_filename_byteCount);
                native_ini_filename[native_ini_filename_offset] = 0;
            }
            else { native_ini_filename = null; }
            ImGuiNative.ImGui_SaveIniSettingsToDisk(native_ini_filename);
            if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_ini_filename);
            }
        }
        public static string SaveIniSettingsToMemory()
        {
            uint* out_ini_size = null;
            byte* ret = ImGuiNative.ImGui_SaveIniSettingsToMemory(out_ini_size);
            return Util.StringFromPtr(ret);
        }
        public static string SaveIniSettingsToMemory(out uint out_ini_size)
        {
            fixed (uint* native_out_ini_size = &out_ini_size)
            {
                byte* ret = ImGuiNative.ImGui_SaveIniSettingsToMemory(native_out_ini_size);
                return Util.StringFromPtr(ret);
            }
        }
#if ANDROID
        public static bool Selectable(ReadOnlySpan<char> label)
#else
        public static bool Selectable(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte selected = 0;
            ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_Selectable_Bool(native_label, selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool Selectable(ReadOnlySpan<char> label, bool selected)
#else
        public static bool Selectable(string label, bool selected)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_Selectable_Bool(native_label, native_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool Selectable(ReadOnlySpan<char> label, bool selected, ImGuiSelectableFlags flags)
#else
        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_Selectable_Bool(native_label, native_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool Selectable(ReadOnlySpan<char> label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
#else
        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_selected = selected ? (byte)1 : (byte)0;
            byte ret = ImGuiNative.ImGui_Selectable_Bool(native_label, native_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool Selectable(ReadOnlySpan<char> label, ref bool p_selected)
#else
        public static bool Selectable(string label, ref bool p_selected)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_Selectable_BoolPtr(native_label, native_p_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool Selectable(ReadOnlySpan<char> label, ref bool p_selected, ImGuiSelectableFlags flags)
#else
        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            Vector2 size = new Vector2();
            byte ret = ImGuiNative.ImGui_Selectable_BoolPtr(native_label, native_p_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
#if ANDROID
        public static bool Selectable(ReadOnlySpan<char> label, ref bool p_selected, ImGuiSelectableFlags flags, Vector2 size)
#else
        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags, Vector2 size)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte native_p_selected_val = p_selected ? (byte)1 : (byte)0;
            byte* native_p_selected = &native_p_selected_val;
            byte ret = ImGuiNative.ImGui_Selectable_BoolPtr(native_label, native_p_selected, flags, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            p_selected = native_p_selected_val != 0;
            return ret != 0;
        }
        public static void Separator()
        {
            ImGuiNative.ImGui_Separator();
        }
#if ANDROID
        public static void SeparatorText(ReadOnlySpan<char> label)
#else
        public static void SeparatorText(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNative.ImGui_SeparatorText(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func)
        {
            void* user_data = null;
            ImGuiNative.ImGui_SetAllocatorFunctions(alloc_func, free_func, user_data);
        }
        public static void SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, IntPtr user_data)
        {
            void* native_user_data = (void*)user_data.ToPointer();
            ImGuiNative.ImGui_SetAllocatorFunctions(alloc_func, free_func, native_user_data);
        }
#if ANDROID
        public static void SetClipboardText(ReadOnlySpan<char> text)
#else
        public static void SetClipboardText(string text)
#endif
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            ImGuiNative.ImGui_SetClipboardText(native_text);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public static void SetColorEditOptions(ImGuiColorEditFlags flags)
        {
            ImGuiNative.ImGui_SetColorEditOptions(flags);
        }
        public static void SetColumnOffset(int column_index, float offset_x)
        {
            ImGuiNative.ImGui_SetColumnOffset(column_index, offset_x);
        }
        public static void SetColumnWidth(int column_index, float width)
        {
            ImGuiNative.ImGui_SetColumnWidth(column_index, width);
        }
        public static void SetCurrentContext(IntPtr ctx)
        {
            ImGuiNative.ImGui_SetCurrentContext(ctx);
        }
        public static void SetCursorPos(Vector2 local_pos)
        {
            ImGuiNative.ImGui_SetCursorPos(local_pos);
        }
        public static void SetCursorPosX(float local_x)
        {
            ImGuiNative.ImGui_SetCursorPosX(local_x);
        }
        public static void SetCursorPosY(float local_y)
        {
            ImGuiNative.ImGui_SetCursorPosY(local_y);
        }
        public static void SetCursorScreenPos(Vector2 pos)
        {
            ImGuiNative.ImGui_SetCursorScreenPos(pos);
        }
#if ANDROID
        public static bool SetDragDropPayload(ReadOnlySpan<char> type, IntPtr data, uint sz)
#else
        public static bool SetDragDropPayload(string type, IntPtr data, uint sz)
#endif
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            void* native_data = (void*)data.ToPointer();
            ImGuiCond cond = (ImGuiCond)0;
            byte ret = ImGuiNative.ImGui_SetDragDropPayload(native_type, native_data, sz, cond);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool SetDragDropPayload(ReadOnlySpan<char> type, IntPtr data, uint sz, ImGuiCond cond)
#else
        public static bool SetDragDropPayload(string type, IntPtr data, uint sz, ImGuiCond cond)
#endif
        {
            byte* native_type;
            int type_byteCount = 0;
            if (type != null)
            {
                type_byteCount = Encoding.UTF8.GetByteCount(type);
                if (type_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_type = Util.Allocate(type_byteCount + 1);
                }
                else
                {
                    byte* native_type_stackBytes = stackalloc byte[type_byteCount + 1];
                    native_type = native_type_stackBytes;
                }
                int native_type_offset = Util.GetUtf8(type, native_type, type_byteCount);
                native_type[native_type_offset] = 0;
            }
            else { native_type = null; }
            void* native_data = (void*)data.ToPointer();
            byte ret = ImGuiNative.ImGui_SetDragDropPayload(native_type, native_data, sz, cond);
            if (type_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_type);
            }
            return ret != 0;
        }
        public static void SetItemDefaultFocus()
        {
            ImGuiNative.ImGui_SetItemDefaultFocus();
        }
#if ANDROID
        public static void SetItemTooltip(ReadOnlySpan<char> fmt)
#else
        public static void SetItemTooltip(string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_SetItemTooltip(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void SetKeyboardFocusHere()
        {
            int offset = 0;
            ImGuiNative.ImGui_SetKeyboardFocusHere(offset);
        }
        public static void SetKeyboardFocusHere(int offset)
        {
            ImGuiNative.ImGui_SetKeyboardFocusHere(offset);
        }
        public static void SetMouseCursor(ImGuiMouseCursor cursor_type)
        {
            ImGuiNative.ImGui_SetMouseCursor(cursor_type);
        }
        public static void SetNextFrameWantCaptureKeyboard(bool want_capture_keyboard)
        {
            byte native_want_capture_keyboard = want_capture_keyboard ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_SetNextFrameWantCaptureKeyboard(native_want_capture_keyboard);
        }
        public static void SetNextFrameWantCaptureMouse(bool want_capture_mouse)
        {
            byte native_want_capture_mouse = want_capture_mouse ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_SetNextFrameWantCaptureMouse(native_want_capture_mouse);
        }
        public static void SetNextItemAllowOverlap()
        {
            ImGuiNative.ImGui_SetNextItemAllowOverlap();
        }
        public static void SetNextItemOpen(bool is_open)
        {
            byte native_is_open = is_open ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetNextItemOpen(native_is_open, cond);
        }
        public static void SetNextItemOpen(bool is_open, ImGuiCond cond)
        {
            byte native_is_open = is_open ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_SetNextItemOpen(native_is_open, cond);
        }
        public static void SetNextItemWidth(float item_width)
        {
            ImGuiNative.ImGui_SetNextItemWidth(item_width);
        }
        public static void SetNextWindowBgAlpha(float alpha)
        {
            ImGuiNative.ImGui_SetNextWindowBgAlpha(alpha);
        }
        public static void SetNextWindowClass(ImGuiWindowClassPtr window_class)
        {
            ImGuiWindowClass* native_window_class = window_class.NativePtr;
            ImGuiNative.ImGui_SetNextWindowClass(native_window_class);
        }
        public static void SetNextWindowCollapsed(bool collapsed)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetNextWindowCollapsed(native_collapsed, cond);
        }
        public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_SetNextWindowCollapsed(native_collapsed, cond);
        }
        public static void SetNextWindowContentSize(Vector2 size)
        {
            ImGuiNative.ImGui_SetNextWindowContentSize(size);
        }
        public static void SetNextWindowDockID(uint dock_id)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetNextWindowDockID(dock_id, cond);
        }
        public static void SetNextWindowDockID(uint dock_id, ImGuiCond cond)
        {
            ImGuiNative.ImGui_SetNextWindowDockID(dock_id, cond);
        }
        public static void SetNextWindowFocus()
        {
            ImGuiNative.ImGui_SetNextWindowFocus();
        }
        public static void SetNextWindowPos(Vector2 pos)
        {
            ImGuiCond cond = (ImGuiCond)0;
            Vector2 pivot = new Vector2();
            ImGuiNative.ImGui_SetNextWindowPos(pos, cond, pivot);
        }
        public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond)
        {
            Vector2 pivot = new Vector2();
            ImGuiNative.ImGui_SetNextWindowPos(pos, cond, pivot);
        }
        public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot)
        {
            ImGuiNative.ImGui_SetNextWindowPos(pos, cond, pivot);
        }
        public static void SetNextWindowScroll(Vector2 scroll)
        {
            ImGuiNative.ImGui_SetNextWindowScroll(scroll);
        }
        public static void SetNextWindowSize(Vector2 size)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetNextWindowSize(size, cond);
        }
        public static void SetNextWindowSize(Vector2 size, ImGuiCond cond)
        {
            ImGuiNative.ImGui_SetNextWindowSize(size, cond);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max)
        {
            ImGuiSizeCallback custom_callback = null;
            void* custom_callback_data = null;
            ImGuiNative.ImGui_SetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback)
        {
            void* custom_callback_data = null;
            ImGuiNative.ImGui_SetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
        }
        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, IntPtr custom_callback_data)
        {
            void* native_custom_callback_data = (void*)custom_callback_data.ToPointer();
            ImGuiNative.ImGui_SetNextWindowSizeConstraints(size_min, size_max, custom_callback, native_custom_callback_data);
        }
        public static void SetNextWindowViewport(uint viewport_id)
        {
            ImGuiNative.ImGui_SetNextWindowViewport(viewport_id);
        }
        public static void SetScrollFromPosX(float local_x)
        {
            float center_x_ratio = 0.5f;
            ImGuiNative.ImGui_SetScrollFromPosX_Float(local_x, center_x_ratio);
        }
        public static void SetScrollFromPosX(float local_x, float center_x_ratio)
        {
            ImGuiNative.ImGui_SetScrollFromPosX_Float(local_x, center_x_ratio);
        }
        public static void SetScrollFromPosY(float local_y)
        {
            float center_y_ratio = 0.5f;
            ImGuiNative.ImGui_SetScrollFromPosY_Float(local_y, center_y_ratio);
        }
        public static void SetScrollFromPosY(float local_y, float center_y_ratio)
        {
            ImGuiNative.ImGui_SetScrollFromPosY_Float(local_y, center_y_ratio);
        }
        public static void SetScrollHereX()
        {
            float center_x_ratio = 0.5f;
            ImGuiNative.ImGui_SetScrollHereX(center_x_ratio);
        }
        public static void SetScrollHereX(float center_x_ratio)
        {
            ImGuiNative.ImGui_SetScrollHereX(center_x_ratio);
        }
        public static void SetScrollHereY()
        {
            float center_y_ratio = 0.5f;
            ImGuiNative.ImGui_SetScrollHereY(center_y_ratio);
        }
        public static void SetScrollHereY(float center_y_ratio)
        {
            ImGuiNative.ImGui_SetScrollHereY(center_y_ratio);
        }
        public static void SetScrollX(float scroll_x)
        {
            ImGuiNative.ImGui_SetScrollX_Float(scroll_x);
        }
        public static void SetScrollY(float scroll_y)
        {
            ImGuiNative.ImGui_SetScrollY_Float(scroll_y);
        }
        public static void SetStateStorage(ImGuiStoragePtr storage)
        {
            ImGuiStorage* native_storage = storage.NativePtr;
            ImGuiNative.ImGui_SetStateStorage(native_storage);
        }
#if ANDROID
        public static void SetTabItemClosed(ReadOnlySpan<char> tab_or_docked_window_label)
#else
        public static void SetTabItemClosed(string tab_or_docked_window_label)
#endif
        {
            byte* native_tab_or_docked_window_label;
            int tab_or_docked_window_label_byteCount = 0;
            if (tab_or_docked_window_label != null)
            {
                tab_or_docked_window_label_byteCount = Encoding.UTF8.GetByteCount(tab_or_docked_window_label);
                if (tab_or_docked_window_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_tab_or_docked_window_label = Util.Allocate(tab_or_docked_window_label_byteCount + 1);
                }
                else
                {
                    byte* native_tab_or_docked_window_label_stackBytes = stackalloc byte[tab_or_docked_window_label_byteCount + 1];
                    native_tab_or_docked_window_label = native_tab_or_docked_window_label_stackBytes;
                }
                int native_tab_or_docked_window_label_offset = Util.GetUtf8(tab_or_docked_window_label, native_tab_or_docked_window_label, tab_or_docked_window_label_byteCount);
                native_tab_or_docked_window_label[native_tab_or_docked_window_label_offset] = 0;
            }
            else { native_tab_or_docked_window_label = null; }
            ImGuiNative.ImGui_SetTabItemClosed(native_tab_or_docked_window_label);
            if (tab_or_docked_window_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_tab_or_docked_window_label);
            }
        }
#if ANDROID
        public static void SetTooltip(ReadOnlySpan<char> fmt)
#else
        public static void SetTooltip(string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_SetTooltip(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
        public static void SetWindowCollapsed(bool collapsed)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetWindowCollapsed_Bool(native_collapsed, cond);
        }
        public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond)
        {
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_SetWindowCollapsed_Bool(native_collapsed, cond);
        }
#if ANDROID
        public static void SetWindowCollapsed(ReadOnlySpan<char> name, bool collapsed)
#else
        public static void SetWindowCollapsed(string name, bool collapsed)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetWindowCollapsed_Str(native_name, native_collapsed, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
#if ANDROID
        public static void SetWindowCollapsed(ReadOnlySpan<char> name, bool collapsed, ImGuiCond cond)
#else
        public static void SetWindowCollapsed(string name, bool collapsed, ImGuiCond cond)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_collapsed = collapsed ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_SetWindowCollapsed_Str(native_name, native_collapsed, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowFocus()
        {
            ImGuiNative.ImGui_SetWindowFocus_Nil();
        }
#if ANDROID
        public static void SetWindowFocus(ReadOnlySpan<char> name)
#else
        public static void SetWindowFocus(string name)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiNative.ImGui_SetWindowFocus_Str(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowFontScale(float scale)
        {
            ImGuiNative.ImGui_SetWindowFontScale(scale);
        }
        public static void SetWindowPos(Vector2 pos)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetWindowPos_Vec2(pos, cond);
        }
        public static void SetWindowPos(Vector2 pos, ImGuiCond cond)
        {
            ImGuiNative.ImGui_SetWindowPos_Vec2(pos, cond);
        }
#if ANDROID
        public static void SetWindowPos(ReadOnlySpan<char> name, Vector2 pos)
#else
        public static void SetWindowPos(string name, Vector2 pos)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetWindowPos_Str(native_name, pos, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
#if ANDROID
        public static void SetWindowPos(ReadOnlySpan<char> name, Vector2 pos, ImGuiCond cond)
#else
        public static void SetWindowPos(string name, Vector2 pos, ImGuiCond cond)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiNative.ImGui_SetWindowPos_Str(native_name, pos, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void SetWindowSize(Vector2 size)
        {
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetWindowSize_Vec2(size, cond);
        }
        public static void SetWindowSize(Vector2 size, ImGuiCond cond)
        {
            ImGuiNative.ImGui_SetWindowSize_Vec2(size, cond);
        }
#if ANDROID
        public static void SetWindowSize(ReadOnlySpan<char> name, Vector2 size)
#else
        public static void SetWindowSize(string name, Vector2 size)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiCond cond = (ImGuiCond)0;
            ImGuiNative.ImGui_SetWindowSize_Str(native_name, size, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
#if ANDROID
        public static void SetWindowSize(ReadOnlySpan<char> name, Vector2 size, ImGuiCond cond)
#else
        public static void SetWindowSize(string name, Vector2 size, ImGuiCond cond)
#endif
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImGuiNative.ImGui_SetWindowSize_Str(native_name, size, cond);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void ShowAboutWindow()
        {
            byte* p_open = null;
            ImGuiNative.ImGui_ShowAboutWindow(p_open);
        }
        public static void ShowAboutWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.ImGui_ShowAboutWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static void ShowDebugLogWindow()
        {
            byte* p_open = null;
            ImGuiNative.ImGui_ShowDebugLogWindow(p_open);
        }
        public static void ShowDebugLogWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.ImGui_ShowDebugLogWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static void ShowDemoWindow()
        {
            byte* p_open = null;
            ImGuiNative.ImGui_ShowDemoWindow(p_open);
        }
        public static void ShowDemoWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.ImGui_ShowDemoWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
#if ANDROID
        public static void ShowFontSelector(ReadOnlySpan<char> label)
#else
        public static void ShowFontSelector(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNative.ImGui_ShowFontSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void ShowMetricsWindow()
        {
            byte* p_open = null;
            ImGuiNative.ImGui_ShowMetricsWindow(p_open);
        }
        public static void ShowMetricsWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.ImGui_ShowMetricsWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static void ShowStackToolWindow()
        {
            byte* p_open = null;
            ImGuiNative.ImGui_ShowStackToolWindow(p_open);
        }
        public static void ShowStackToolWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImGuiNative.ImGui_ShowStackToolWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static void ShowStyleEditor()
        {
            ImGuiStyle* @ref = null;
            ImGuiNative.ImGui_ShowStyleEditor(@ref);
        }
        public static void ShowStyleEditor(ImGuiStylePtr @ref)
        {
            ImGuiStyle* native_ref = @ref.NativePtr;
            ImGuiNative.ImGui_ShowStyleEditor(native_ref);
        }
#if ANDROID
        public static bool ShowStyleSelector(ReadOnlySpan<char> label)
#else
        public static bool ShowStyleSelector(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_ShowStyleSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static void ShowUserGuide()
        {
            ImGuiNative.ImGui_ShowUserGuide();
        }
#if ANDROID
        public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad)
#else
        public static bool SliderAngle(string label, ref float v_rad)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_degrees_min = -360.0f;
            float v_degrees_max = +360.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.0f deg", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.ImGui_SliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min)
#else
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float v_degrees_max = +360.0f;
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.0f deg", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.ImGui_SliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min, float v_degrees_max)
#else
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.0f deg", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.ImGui_SliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min, float v_degrees_max, ReadOnlySpan<char> format)
#else
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.ImGui_SliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min, float v_degrees_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v_rad = &v_rad)
            {
                byte ret = ImGuiNative.ImGui_SliderAngle(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float v_min, float v_max)
#else
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_min, float v_max)
#else
        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector2* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_min, float v_max)
#else
        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_min, float v_max)
#else
        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (Vector4* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderFloat4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int v_min, int v_max)
#else
        public static bool SliderInt(string label, ref int v, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt2(ReadOnlySpan<char> label, ref int v, int v_min, int v_max)
#else
        public static bool SliderInt2(string label, ref int v, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt2(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderInt2(string label, ref int v, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt2(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderInt2(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt2(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt3(ReadOnlySpan<char> label, ref int v, int v_min, int v_max)
#else
        public static bool SliderInt3(string label, ref int v, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt3(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderInt3(string label, ref int v, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt3(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderInt3(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt3(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt4(ReadOnlySpan<char> label, ref int v, int v_min, int v_max)
#else
        public static bool SliderInt4(string label, ref int v, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt4(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool SliderInt4(string label, ref int v, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderInt4(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderInt4(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_SliderInt4(native_label, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
#else
        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_SliderScalar(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
#else
        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_SliderScalar(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.ImGui_SliderScalar(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max)
#else
        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_SliderScalarN(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
#else
        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_SliderScalarN(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.ImGui_SliderScalarN(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool SmallButton(ReadOnlySpan<char> label)
#else
        public static bool SmallButton(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_SmallButton(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static void Spacing()
        {
            ImGuiNative.ImGui_Spacing();
        }
        public static void StyleColorsClassic()
        {
            ImGuiStyle* dst = null;
            ImGuiNative.ImGui_StyleColorsClassic(dst);
        }
        public static void StyleColorsClassic(ImGuiStylePtr dst)
        {
            ImGuiStyle* native_dst = dst.NativePtr;
            ImGuiNative.ImGui_StyleColorsClassic(native_dst);
        }
        public static void StyleColorsDark()
        {
            ImGuiStyle* dst = null;
            ImGuiNative.ImGui_StyleColorsDark(dst);
        }
        public static void StyleColorsDark(ImGuiStylePtr dst)
        {
            ImGuiStyle* native_dst = dst.NativePtr;
            ImGuiNative.ImGui_StyleColorsDark(native_dst);
        }
        public static void StyleColorsLight()
        {
            ImGuiStyle* dst = null;
            ImGuiNative.ImGui_StyleColorsLight(dst);
        }
        public static void StyleColorsLight(ImGuiStylePtr dst)
        {
            ImGuiStyle* native_dst = dst.NativePtr;
            ImGuiNative.ImGui_StyleColorsLight(native_dst);
        }
#if ANDROID
        public static bool TabItemButton(ReadOnlySpan<char> label)
#else
        public static bool TabItemButton(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;
            byte ret = ImGuiNative.ImGui_TabItemButton(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool TabItemButton(ReadOnlySpan<char> label, ImGuiTabItemFlags flags)
#else
        public static bool TabItemButton(string label, ImGuiTabItemFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_TabItemButton(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static int TableGetColumnCount()
        {
            int ret = ImGuiNative.ImGui_TableGetColumnCount();
            return ret;
        }
        public static ImGuiTableColumnFlags TableGetColumnFlags()
        {
            int column_n = -1;
            ImGuiTableColumnFlags ret = ImGuiNative.ImGui_TableGetColumnFlags(column_n);
            return ret;
        }
        public static ImGuiTableColumnFlags TableGetColumnFlags(int column_n)
        {
            ImGuiTableColumnFlags ret = ImGuiNative.ImGui_TableGetColumnFlags(column_n);
            return ret;
        }
        public static int TableGetColumnIndex()
        {
            int ret = ImGuiNative.ImGui_TableGetColumnIndex();
            return ret;
        }
        public static string TableGetColumnName()
        {
            int column_n = -1;
            byte* ret = ImGuiNative.ImGui_TableGetColumnName_Int(column_n);
            return Util.StringFromPtr(ret);
        }
        public static string TableGetColumnName(int column_n)
        {
            byte* ret = ImGuiNative.ImGui_TableGetColumnName_Int(column_n);
            return Util.StringFromPtr(ret);
        }
        public static int TableGetRowIndex()
        {
            int ret = ImGuiNative.ImGui_TableGetRowIndex();
            return ret;
        }
        public static ImGuiTableSortSpecsPtr TableGetSortSpecs()
        {
            ImGuiTableSortSpecs* ret = ImGuiNative.ImGui_TableGetSortSpecs();
            return new ImGuiTableSortSpecsPtr(ret);
        }
#if ANDROID
        public static void TableHeader(ReadOnlySpan<char> label)
#else
        public static void TableHeader(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNative.ImGui_TableHeader(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void TableHeadersRow()
        {
            ImGuiNative.ImGui_TableHeadersRow();
        }
        public static bool TableNextColumn()
        {
            byte ret = ImGuiNative.ImGui_TableNextColumn();
            return ret != 0;
        }
        public static void TableNextRow()
        {
            ImGuiTableRowFlags row_flags = (ImGuiTableRowFlags)0;
            float min_row_height = 0.0f;
            ImGuiNative.ImGui_TableNextRow(row_flags, min_row_height);
        }
        public static void TableNextRow(ImGuiTableRowFlags row_flags)
        {
            float min_row_height = 0.0f;
            ImGuiNative.ImGui_TableNextRow(row_flags, min_row_height);
        }
        public static void TableNextRow(ImGuiTableRowFlags row_flags, float min_row_height)
        {
            ImGuiNative.ImGui_TableNextRow(row_flags, min_row_height);
        }
        public static void TableSetBgColor(ImGuiTableBgTarget target, uint color)
        {
            int column_n = -1;
            ImGuiNative.ImGui_TableSetBgColor(target, color, column_n);
        }
        public static void TableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n)
        {
            ImGuiNative.ImGui_TableSetBgColor(target, color, column_n);
        }
        public static void TableSetColumnEnabled(int column_n, bool v)
        {
            byte native_v = v ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_TableSetColumnEnabled(column_n, native_v);
        }
        public static bool TableSetColumnIndex(int column_n)
        {
            byte ret = ImGuiNative.ImGui_TableSetColumnIndex(column_n);
            return ret != 0;
        }
#if ANDROID
        public static void TableSetupColumn(ReadOnlySpan<char> label)
#else
        public static void TableSetupColumn(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTableColumnFlags flags = (ImGuiTableColumnFlags)0;
            float init_width_or_weight = 0.0f;
            uint user_id = 0;
            ImGuiNative.ImGui_TableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
#if ANDROID
        public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags)
#else
        public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            float init_width_or_weight = 0.0f;
            uint user_id = 0;
            ImGuiNative.ImGui_TableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
#if ANDROID
        public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags, float init_width_or_weight)
#else
        public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags, float init_width_or_weight)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            uint user_id = 0;
            ImGuiNative.ImGui_TableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
#if ANDROID
        public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id)
#else
        public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiNative.ImGui_TableSetupColumn(native_label, flags, init_width_or_weight, user_id);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void TableSetupScrollFreeze(int cols, int rows)
        {
            ImGuiNative.ImGui_TableSetupScrollFreeze(cols, rows);
        }
#if ANDROID
        public static void Text(ReadOnlySpan<char> fmt)
#else
        public static void Text(string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_Text(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
#if ANDROID
        public static void TextColored(Vector4 col, ReadOnlySpan<char> fmt)
#else
        public static void TextColored(Vector4 col, string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_TextColored(col, native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
#if ANDROID
        public static void TextDisabled(ReadOnlySpan<char> fmt)
#else
        public static void TextDisabled(string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_TextDisabled(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
#if ANDROID
        public static void TextUnformatted(ReadOnlySpan<char> text)
#else
        public static void TextUnformatted(string text)
#endif
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            byte* native_text_end = null;
            ImGuiNative.ImGui_TextUnformatted(native_text, native_text_end);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
#if ANDROID
        public static void TextWrapped(ReadOnlySpan<char> fmt)
#else
        public static void TextWrapped(string fmt)
#endif
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImGuiNative.ImGui_TextWrapped(native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
#if ANDROID
        public static bool TreeNode(ReadOnlySpan<char> label)
#else
        public static bool TreeNode(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_TreeNode_Str(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool TreeNode(ReadOnlySpan<char> str_id, ReadOnlySpan<char> fmt)
#else
        public static bool TreeNode(string str_id, string fmt)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.ImGui_TreeNode_StrStr(native_str_id, native_fmt);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool TreeNode(IntPtr ptr_id, ReadOnlySpan<char> fmt)
#else
        public static bool TreeNode(IntPtr ptr_id, string fmt)
#endif
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.ImGui_TreeNode_Ptr(native_ptr_id, native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool TreeNodeEx(ReadOnlySpan<char> label)
#else
        public static bool TreeNodeEx(string label)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;
            byte ret = ImGuiNative.ImGui_TreeNodeEx_Str(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool TreeNodeEx(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
#else
        public static bool TreeNodeEx(string label, ImGuiTreeNodeFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuiNative.ImGui_TreeNodeEx_Str(native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool TreeNodeEx(ReadOnlySpan<char> str_id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
#else
        public static bool TreeNodeEx(string str_id, ImGuiTreeNodeFlags flags, string fmt)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.ImGui_TreeNodeEx_StrStr(native_str_id, flags, native_fmt);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool TreeNodeEx(IntPtr ptr_id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
#else
        public static bool TreeNodeEx(IntPtr ptr_id, ImGuiTreeNodeFlags flags, string fmt)
#endif
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            byte ret = ImGuiNative.ImGui_TreeNodeEx_Ptr(native_ptr_id, flags, native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
            return ret != 0;
        }
        public static void TreePop()
        {
            ImGuiNative.ImGui_TreePop();
        }
#if ANDROID
        public static void TreePush(ReadOnlySpan<char> str_id)
#else
        public static void TreePush(string str_id)
#endif
        {
            byte* native_str_id;
            int str_id_byteCount = 0;
            if (str_id != null)
            {
                str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
                if (str_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_str_id = Util.Allocate(str_id_byteCount + 1);
                }
                else
                {
                    byte* native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
                    native_str_id = native_str_id_stackBytes;
                }
                int native_str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
                native_str_id[native_str_id_offset] = 0;
            }
            else { native_str_id = null; }
            ImGuiNative.ImGui_TreePush_Str(native_str_id);
            if (str_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_str_id);
            }
        }
        public static void TreePush(IntPtr ptr_id)
        {
            void* native_ptr_id = (void*)ptr_id.ToPointer();
            ImGuiNative.ImGui_TreePush_Ptr(native_ptr_id);
        }
        public static void Unindent()
        {
            float indent_w = 0.0f;
            ImGuiNative.ImGui_Unindent(indent_w);
        }
        public static void Unindent(float indent_w)
        {
            ImGuiNative.ImGui_Unindent(indent_w);
        }
        public static void UpdatePlatformWindows()
        {
            ImGuiNative.ImGui_UpdatePlatformWindows();
        }
#if ANDROID
        public static void Value(ReadOnlySpan<char> prefix, bool b)
#else
        public static void Value(string prefix, bool b)
#endif
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuiNative.ImGui_Value_Bool(native_prefix, native_b);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
#if ANDROID
        public static void Value(ReadOnlySpan<char> prefix, int v)
#else
        public static void Value(string prefix, int v)
#endif
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            ImGuiNative.ImGui_Value_Int(native_prefix, v);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
#if ANDROID
        public static void Value(ReadOnlySpan<char> prefix, uint v)
#else
        public static void Value(string prefix, uint v)
#endif
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            ImGuiNative.ImGui_Value_Uint(native_prefix, v);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
#if ANDROID
        public static void Value(ReadOnlySpan<char> prefix, float v)
#else
        public static void Value(string prefix, float v)
#endif
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            byte* native_float_format = null;
            ImGuiNative.ImGui_Value_Float(native_prefix, v, native_float_format);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
        }
#if ANDROID
        public static void Value(ReadOnlySpan<char> prefix, float v, ReadOnlySpan<char> float_format)
#else
        public static void Value(string prefix, float v, string float_format)
#endif
        {
            byte* native_prefix;
            int prefix_byteCount = 0;
            if (prefix != null)
            {
                prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
                if (prefix_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_prefix = Util.Allocate(prefix_byteCount + 1);
                }
                else
                {
                    byte* native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
                    native_prefix = native_prefix_stackBytes;
                }
                int native_prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
                native_prefix[native_prefix_offset] = 0;
            }
            else { native_prefix = null; }
            byte* native_float_format;
            int float_format_byteCount = 0;
            if (float_format != null)
            {
                float_format_byteCount = Encoding.UTF8.GetByteCount(float_format);
                if (float_format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_float_format = Util.Allocate(float_format_byteCount + 1);
                }
                else
                {
                    byte* native_float_format_stackBytes = stackalloc byte[float_format_byteCount + 1];
                    native_float_format = native_float_format_stackBytes;
                }
                int native_float_format_offset = Util.GetUtf8(float_format, native_float_format, float_format_byteCount);
                native_float_format[native_float_format_offset] = 0;
            }
            else { native_float_format = null; }
            ImGuiNative.ImGui_Value_Float(native_prefix, v, native_float_format);
            if (prefix_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_prefix);
            }
            if (float_format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_float_format);
            }
        }
#if ANDROID
        public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float v_min, float v_max)
#else
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%.3f", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_VSliderFloat(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float v_min, float v_max, ReadOnlySpan<char> format)
#else
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_VSliderFloat(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (float* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_VSliderFloat(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int v_min, int v_max)
#else
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
                format_byteCount = Encoding.UTF8.GetByteCount("%d");
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8("%d", native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_VSliderInt(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int v_min, int v_max, ReadOnlySpan<char> format)
#else
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_VSliderInt(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            fixed (int* native_v = &v)
            {
                byte ret = ImGuiNative.ImGui_VSliderInt(native_label, size, native_v, v_min, v_max, native_format, flags);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_label);
                }
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_format);
                }
                return ret != 0;
            }
        }
#if ANDROID
        public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
#else
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format = null;
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_VSliderScalar(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
#else
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            ImGuiSliderFlags flags = (ImGuiSliderFlags)0;
            byte ret = ImGuiNative.ImGui_VSliderScalar(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
#if ANDROID
        public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
#else
        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, string format, ImGuiSliderFlags flags)
#endif
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            void* native_p_data = (void*)p_data.ToPointer();
            void* native_p_min = (void*)p_min.ToPointer();
            void* native_p_max = (void*)p_max.ToPointer();
            byte* native_format;
            int format_byteCount = 0;
            if (format != null)
            {
                format_byteCount = Encoding.UTF8.GetByteCount(format);
                if (format_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_format = Util.Allocate(format_byteCount + 1);
                }
                else
                {
                    byte* native_format_stackBytes = stackalloc byte[format_byteCount + 1];
                    native_format = native_format_stackBytes;
                }
                int native_format_offset = Util.GetUtf8(format, native_format, format_byteCount);
                native_format[native_format_offset] = 0;
            }
            else { native_format = null; }
            byte ret = ImGuiNative.ImGui_VSliderScalar(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            if (format_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_format);
            }
            return ret != 0;
        }
    }
}
