using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGui_AcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_AlignTextToFramePadding();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_Begin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginChild_Str(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginChild_ID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_BeginDisabled(byte disabled);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginDragDropTarget();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_BeginGroup();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginItemTooltip();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginListBox(byte* label, Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginMainMenuBar();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginMenu(byte* label, byte enabled);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginMenuBar();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginTable(byte* str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_BeginTooltip();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Bullet();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_BulletText(byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_Button(byte* label, Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_CalcItemWidth();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_CalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_Checkbox(byte* label, byte* v);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_CheckboxFlags_IntPtr(byte* label, int* flags, int flags_value);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_CheckboxFlags_UintPtr(byte* label, uint* flags, uint flags_value);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_CloseCurrentPopup();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_CollapsingHeader_TreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_CollapsingHeader_BoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_ColorConvertFloat4ToU32(Vector4 @in);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Columns(int count, byte* id, byte border);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_Combo_Str_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_Combo_Str(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImGui_CreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_DebugTextEncoding(byte* text);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_DestroyContext(IntPtr ctx);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_DestroyPlatformWindows();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_DockSpace(uint id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_DockSpaceOverViewport(ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_DragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Dummy(Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_End();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndChild();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndChildFrame();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndCombo();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndDisabled();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndDragDropSource();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndDragDropTarget();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndFrame();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndGroup();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndListBox();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndMainMenuBar();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndMenu();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndMenuBar();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndPopup();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndTabBar();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndTabItem();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndTable();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_EndTooltip();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGui_FindViewportByID(uint id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGui_FindViewportByPlatformHandle(void* platform_handle);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetAllocatorFunctions(IntPtr* p_alloc_func, IntPtr* p_free_func, void** p_user_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImGui_GetBackgroundDrawList_Nil();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImGui_GetBackgroundDrawList_ViewportPtr(ImGuiViewport* viewport);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGui_GetClipboardText();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetColorU32_Col(ImGuiCol idx, float alpha_mul);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetColorU32_Vec4(Vector4 col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetColorU32_U32(uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_GetColumnIndex();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetColumnOffset(int column_index);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_GetColumnsCount();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetColumnWidth(int column_index);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetContentRegionAvail(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetContentRegionMax(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImGui_GetCurrentContext();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetCursorPos(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetCursorPosX();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetCursorPosY();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetCursorScreenPos(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetCursorStartPos(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGui_GetDragDropPayload();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImGui_GetDrawData();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImGui_GetDrawListSharedData();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImGui_GetFont();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetFontSize();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetFontTexUvWhitePixel(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImGui_GetForegroundDrawList_Nil();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImGui_GetForegroundDrawList_ViewportPtr(ImGuiViewport* viewport);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_GetFrameCount();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetFrameHeight();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetFrameHeightWithSpacing();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetID_Str(byte* str_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetID_Ptr(void* ptr_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGui_GetIO();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetItemID();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetItemRectMax(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetItemRectMin(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetItemRectSize(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKey ImGui_GetKeyIndex(ImGuiKey key);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGui_GetKeyName(ImGuiKey key);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGui_GetMainViewport();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_GetMouseClickedCount(ImGuiMouseButton button);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMouseCursor ImGui_GetMouseCursor();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetMousePos(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetMousePosOnOpeningCurrentPopup(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* ImGui_GetPlatformIO();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetScrollMaxX();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetScrollMaxY();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetScrollX();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetScrollY();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStorage* ImGui_GetStateStorage();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGui_GetStyle();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGui_GetStyleColorName(ImGuiCol idx);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImGui_GetStyleColorVec4(ImGuiCol idx);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetTextLineHeight();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetTextLineHeightWithSpacing();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImGui_GetTime();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetTreeNodeToLabelSpacing();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGui_GetVersion();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetWindowContentRegionMax(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetWindowContentRegionMin(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGui_GetWindowDockID();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetWindowDpiScale();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImGui_GetWindowDrawList();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetWindowHeight();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetWindowPos(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_GetWindowSize(Vector2* pOut);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGui_GetWindowViewport();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGui_GetWindowWidth();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ImageButton(byte* str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Indent(float indent_w);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_InvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsAnyItemActive();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsAnyItemFocused();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsAnyItemHovered();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsAnyMouseDown();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemActivated();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemActive();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemClicked(ImGuiMouseButton mouse_button);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemDeactivated();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemDeactivatedAfterEdit();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemEdited();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemFocused();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemHovered(ImGuiHoveredFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemToggledOpen();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsItemVisible();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsKeyDown_Nil(ImGuiKey key);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsKeyPressed_Bool(ImGuiKey key, byte repeat);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsKeyReleased_Nil(ImGuiKey key);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsMouseClicked_Bool(ImGuiMouseButton button, byte repeat);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsMouseDoubleClicked(ImGuiMouseButton button);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsMouseDown_Nil(ImGuiMouseButton button);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsMousePosValid(Vector2* mouse_pos);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsMouseReleased_Nil(ImGuiMouseButton button);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsPopupOpen_Str(byte* str_id, ImGuiPopupFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsRectVisible_Nil(Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsRectVisible_Vec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsWindowAppearing();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsWindowCollapsed();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsWindowDocked();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_IsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LabelText(byte* label, byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ListBox_Str_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LogButtons();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LogFinish();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LogText(byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LogToClipboard(int auto_open_depth);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LogToFile(int auto_open_depth, byte* filename);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_LogToTTY(int auto_open_depth);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGui_MemAlloc(uint size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_MemFree(void* ptr);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_MenuItem_Bool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_MenuItem_BoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_NewFrame();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_NewLine();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_NextColumn();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_OpenPopup_Str(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_OpenPopup_ID(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_OpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PlotHistogram_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PlotLines_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopButtonRepeat();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopClipRect();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopFont();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopID();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopItemWidth();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopStyleColor(int count);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopStyleVar(int count);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopTabStop();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PopTextWrapPos();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushButtonRepeat(byte repeat);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushFont(ImFont* font);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushID_Str(byte* str_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushID_Ptr(void* ptr_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushID_Int(int int_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushItemWidth(float item_width);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushStyleColor_U32(ImGuiCol idx, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushStyleColor_Vec4(ImGuiCol idx, Vector4 col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushStyleVar_Float(ImGuiStyleVar idx, float val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushStyleVar_Vec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushTabStop(byte tab_stop);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_PushTextWrapPos(float wrap_local_pos_x);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_RadioButton_Bool(byte* label, byte active);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_RadioButton_IntPtr(byte* label, int* v, int v_button);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Render();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_RenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ResetMouseDragDelta(ImGuiMouseButton button);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SameLine(float offset_from_start_x, float spacing);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SaveIniSettingsToDisk(byte* ini_filename);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGui_SaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_Selectable_Bool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_Selectable_BoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Separator();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SeparatorText(byte* label);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetClipboardText(byte* text);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetColumnOffset(int column_index, float offset_x);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetColumnWidth(int column_index, float width);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetCurrentContext(IntPtr ctx);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetCursorPos(Vector2 local_pos);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetCursorPosX(float local_x);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetCursorPosY(float local_y);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetCursorScreenPos(Vector2 pos);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetItemDefaultFocus();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetItemTooltip(byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetKeyboardFocusHere(int offset);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetMouseCursor(ImGuiMouseCursor cursor_type);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextFrameWantCaptureKeyboard(byte want_capture_keyboard);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextFrameWantCaptureMouse(byte want_capture_mouse);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextItemAllowOverlap();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextItemOpen(byte is_open, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextItemWidth(float item_width);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowBgAlpha(float alpha);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowClass(ImGuiWindowClass* window_class);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowContentSize(Vector2 size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowDockID(uint dock_id, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowFocus();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowScroll(Vector2 scroll);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetNextWindowViewport(uint viewport_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetScrollFromPosX_Float(float local_x, float center_x_ratio);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetScrollFromPosY_Float(float local_y, float center_y_ratio);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetScrollHereX(float center_x_ratio);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetScrollHereY(float center_y_ratio);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetScrollX_Float(float scroll_x);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetScrollY_Float(float scroll_y);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetStateStorage(ImGuiStorage* storage);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetTabItemClosed(byte* tab_or_docked_window_label);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetTooltip(byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowCollapsed_Bool(byte collapsed, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowCollapsed_Str(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowFocus_Nil();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowFocus_Str(byte* name);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowFontScale(float scale);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowPos_Vec2(Vector2 pos, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowPos_Str(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowSize_Vec2(Vector2 size, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_SetWindowSize_Str(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowAboutWindow(byte* p_open);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowDebugLogWindow(byte* p_open);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowDemoWindow(byte* p_open);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowFontSelector(byte* label);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowMetricsWindow(byte* p_open);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowStackToolWindow(byte* p_open);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowStyleEditor(ImGuiStyle* @ref);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_ShowStyleSelector(byte* label);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_ShowUserGuide();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_SmallButton(byte* label);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Spacing();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_StyleColorsClassic(ImGuiStyle* dst);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_StyleColorsDark(ImGuiStyle* dst);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_StyleColorsLight(ImGuiStyle* dst);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TabItemButton(byte* label, ImGuiTabItemFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_TableGetColumnCount();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnFlags ImGui_TableGetColumnFlags(int column_n);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_TableGetColumnIndex();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGui_TableGetColumnName_Int(int column_n);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGui_TableGetRowIndex();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* ImGui_TableGetSortSpecs();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TableHeader(byte* label);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TableHeadersRow();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TableNextColumn();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TableSetColumnEnabled(int column_n, byte v);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TableSetColumnIndex(int column_n);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TableSetupScrollFreeze(int cols, int rows);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Text(byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TextColored(Vector4 col, byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TextDisabled(byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TextUnformatted(byte* text, byte* text_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TextWrapped(byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TreeNode_Str(byte* label);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TreeNode_StrStr(byte* str_id, byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TreeNode_Ptr(void* ptr_id, byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TreeNodeEx_Str(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TreeNodeEx_StrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_TreeNodeEx_Ptr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TreePop();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TreePush_Str(byte* str_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_TreePush_Ptr(void* ptr_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Unindent(float indent_w);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_UpdatePlatformWindows();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Value_Bool(byte* prefix, byte b);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Value_Int(byte* prefix, int v);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Value_Uint(byte* prefix, uint v);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGui_Value_Float(byte* prefix, float v, byte* float_format);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_VSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_VSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGui_VSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_destroy(ImColor* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Nil();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Float(float r, float g, float b, float a);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Vec4(Vector4 col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Int(int r, int g, int b, int a);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_U32(uint rgba);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedTextureID(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__TryMergeDrawCmds(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* callback_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddText_Vec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_destroy(ImFont* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, ushort c);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFont_ImFont();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseViewportEvent(ImGuiIO* self, uint id);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputKeys(ImGuiIO* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_IncludeRangeByIndices(ImGuiListClipper* self, int item_begin, int item_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformImeData* ImGuiPlatformImeData_ImGuiPlatformImeData();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* ImGuiPlatformIO_ImGuiPlatformIO();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformMonitor_destroy(ImGuiPlatformMonitor* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformMonitor* ImGuiPlatformMonitor_ImGuiPlatformMonitor();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Int(uint _key, int _val_i);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Float(uint _key, float _val_f);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Ptr(uint _key, void* _val_p);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Nil();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Str(byte* _b, byte* _e);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_destroy(ImGuiViewport* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGuiViewport_ImGuiViewport();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowClass_destroy(ImGuiWindowClass* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowClass* ImGuiWindowClass_ImGuiWindowClass();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2_destroy(Vector2* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2_Nil();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2_Float(float _x, float _y);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec4_destroy(Vector4* self);
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4_Nil();
        [DllImport("mupen64plus", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4_Float(float _x, float _y, float _z, float _w);
    }
}
