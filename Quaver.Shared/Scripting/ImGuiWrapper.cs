using System;
using System.Numerics;
using ImGuiNET;
using MoonSharp.Interpreter;

namespace Quaver.Shared.Scripting
{
    [MoonSharpUserData]
    public static class ImGuiWrapper
    {
        public static Vector2 CreateVector2(int x, int y) => new Vector2(x, y);

        public static Vector3 CreateVector3(int x, int y, int z) => new Vector3(x, y, z);

        public static Vector4 CreateVector4(float w, float x, float y, float z) => new Vector4(w, x, y, z);

        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string format, float power) => ImGui.SliderFloat4(label, ref v, v_min, v_max, format, power);

        public static bool SliderInt(string label, ref int v, int v_min, int v_max) => ImGui.SliderInt(label, ref v, v_min, v_max);

        public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format) => ImGui.SliderInt(label, ref v, v_min, v_max, format);

        public static bool SliderInt2(string label, ref int v, int v_min, int v_max) => ImGui.SliderInt2(label, ref v, v_min, v_max);

        public static bool SliderInt2(string label, ref int v, int v_min, int v_max, string format) => ImGui.SliderInt2(label, ref v, v_min, v_max, format);

        public static bool SliderInt3(string label, ref int v, int v_min, int v_max) => ImGui.SliderInt3(label, ref v, v_min, v_max);

        public static bool SliderInt3(string label, ref int v, int v_min, int v_max, string format) => ImGui.SliderInt3(label, ref v, v_min, v_max, format);

        public static bool SliderInt4(string label, ref int v, int v_min, int v_max) => ImGui.SliderInt4(label, ref v, v_min, v_max);

        public static bool SliderInt4(string label, ref int v, int v_min, int v_max, string format) => ImGui.SliderInt4(label, ref v, v_min, v_max, format);

        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max) => ImGui.SliderScalar(label, data_type, v, v_min, v_max);

        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max, string format) => ImGui.SliderScalar(label, data_type, v, v_min, v_max, format);

        public static bool SliderScalar(string label, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max, string format, float power) => ImGui.SliderScalar(label, data_type, v, v_min, v_max, format, power);

        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, IntPtr v_min, IntPtr v_max) => ImGui.SliderScalarN(label, data_type, v, components, v_min, v_max);

        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, IntPtr v_min, IntPtr v_max, string format) => ImGui.SliderScalarN(label, data_type, v, components, v_min, v_max, format);

        public static bool SliderScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, IntPtr v_min, IntPtr v_max, string format, float power) => ImGui.SliderScalarN(label, data_type, v, components, v_min, v_max, format, power);

        public static bool SmallButton(string label) => ImGui.SmallButton(label);

        public static void Spacing() => ImGui.Spacing();

        public static void StyleColorsClassic() => ImGui.StyleColorsClassic();

        public static void StyleColorsClassic(ImGuiStylePtr dst) => ImGui.StyleColorsClassic(dst);

        public static void StyleColorsDark() => ImGui.StyleColorsDark();

        public static void StyleColorsDark(ImGuiStylePtr dst) => ImGui.StyleColorsDark(dst);

        public static void StyleColorsLight() => ImGui.StyleColorsLight();

        public static void StyleColorsLight(ImGuiStylePtr dst) => ImGui.StyleColorsLight(dst);

        public static void Text(string fmt) => ImGui.Text(fmt);

        public static void TextColored(Vector4 col, string fmt) => ImGui.TextColored(col, fmt);

        public static void TextDisabled(string fmt) => ImGui.TextDisabled(fmt);

        public static void TextUnformatted(string text) => ImGui.TextUnformatted(text);

        public static void TextWrapped(string fmt) => ImGui.TextWrapped(fmt);

        public static void TreeAdvanceToLabelPos() => ImGui.TreeAdvanceToLabelPos();

        public static bool TreeNode(string label) => ImGui.TreeNode(label);

        public static bool TreeNode(string str_id, string fmt) => ImGui.TreeNode(str_id, fmt);

        public static bool TreeNode(IntPtr ptr_id, string fmt) => ImGui.TreeNode(ptr_id, fmt);

        public static bool TreeNodeEx(string label) => ImGui.TreeNodeEx(label);

        public static bool TreeNodeEx(string label, ImGuiTreeNodeFlags flags) => ImGui.TreeNodeEx(label, flags);

        public static bool TreeNodeEx(string str_id, ImGuiTreeNodeFlags flags, string fmt) => ImGui.TreeNodeEx(str_id, flags, fmt);

        public static bool TreeNodeEx(IntPtr ptr_id, ImGuiTreeNodeFlags flags, string fmt) => ImGui.TreeNodeEx(ptr_id, flags, fmt);

        public static void TreePop() => ImGui.TreePop();

        public static void TreePush(string str_id) => ImGui.TreePush(str_id);

        public static void TreePush() => ImGui.TreePush();

        public static void TreePush(IntPtr ptr_id) => ImGui.TreePush(ptr_id);

        public static void Unindent() => ImGui.Unindent();

        public static void Unindent(float indent_w) => ImGui.Unindent(indent_w);

        public static void Value(string prefix, bool b) => ImGui.Value(prefix, b);

        public static void Value(string prefix, int v) => ImGui.Value(prefix, v);

        public static void Value(string prefix, uint v) => ImGui.Value(prefix, v);

        public static void Value(string prefix, float v) => ImGui.Value(prefix, v);

        public static void Value(string prefix, float v, string float_format) => ImGui.Value(prefix, v, float_format);

        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max) => ImGui.VSliderFloat(label, size, ref v, v_min, v_max);

        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format) => ImGui.VSliderFloat(label, size, ref v, v_min, v_max, format);

        public static bool VSliderFloat(string label, Vector2 size, ref float v, float v_min, float v_max, string format, float power) => ImGui.VSliderFloat(label, size, ref v, v_min, v_max, format, power);

        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max) => ImGui.VSliderInt(label, size, ref v, v_min, v_max);

        public static bool VSliderInt(string label, Vector2 size, ref int v, int v_min, int v_max, string format) => ImGui.VSliderInt(label, size, ref v, v_min, v_max, format);

        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max) => ImGui.VSliderScalar(label, size, data_type, v, v_min, v_max);

        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max, string format) => ImGui.VSliderScalar(label, size, data_type, v, v_min, v_max, format);

        public static bool VSliderScalar(string label, Vector2 size, ImGuiDataType data_type, IntPtr v, IntPtr v_min, IntPtr v_max, string format, float power) => ImGui.VSliderScalar(label, size, data_type, v, v_min, v_max, format, power);

        public static bool InputText(string label, Byte[] buf, uint buf_size) => ImGui.InputText(label, buf, buf_size);

        public static bool InputText(string label, Byte[] buf, uint buf_size, ImGuiInputTextFlags flags) => ImGui.InputText(label, buf, buf_size, flags);

        public static bool InputText(string label, Byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) => ImGui.InputText(label, buf, buf_size, flags, callback);

        public static bool InputText(string label, Byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data) => ImGui.InputText(label, buf, buf_size, flags, callback, user_data);

        public static bool InputText(string label, ref string input, uint maxLength) => ImGui.InputText(label, ref input, maxLength);

        public static bool InputText(string label, ref string input, uint maxLength, ImGuiInputTextFlags flags) => ImGui.InputText(label, ref input, maxLength, flags);

        public static bool InputText(string label, ref string input, uint maxLength, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) => ImGui.InputText(label, ref input, maxLength, flags, callback);

        public static bool InputText(string label, ref string input, uint maxLength, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data) => ImGui.InputText(label, ref input, maxLength, flags, callback, user_data);

        public static bool InputTextMultiline(string label, ref string input, uint maxLength, Vector2 size) => ImGui.InputTextMultiline(label, ref input, maxLength, size);

        public static bool InputTextMultiline(string label, ref string input, uint maxLength, Vector2 size, ImGuiInputTextFlags flags) => ImGui.InputTextMultiline(label, ref input, maxLength, size, flags);

        public static bool InputTextMultiline(string label, ref string input, uint maxLength, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) => ImGui.InputTextMultiline(label, ref input, maxLength, size, flags, callback);

        public static bool InputTextMultiline(string label, ref string input, uint maxLength, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data) => ImGui.InputTextMultiline(label, ref input, maxLength, size, flags, callback, user_data);

        public static bool InputText(string label, IntPtr buf, uint buf_size) => ImGui.InputText(label, buf, buf_size);

        public static bool InputText(string label, IntPtr buf, uint buf_size, ImGuiInputTextFlags flags) => ImGui.InputText(label, buf, buf_size, flags);

        public static bool InputText(string label, IntPtr buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) => ImGui.InputText(label, buf, buf_size, flags, callback);

        public static bool InputText(string label, IntPtr buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data) => ImGui.InputText(label, buf, buf_size, flags, callback, user_data);

        public static bool Begin(string name, ImGuiWindowFlags flags) => ImGui.Begin(name, flags);

        public static bool MenuItem(string label, bool enabled) => ImGui.MenuItem(label, enabled);

        public static void PopAllowKeyboardFocus() => ImGui.PopAllowKeyboardFocus();

        public static void PopButtonRepeat() => ImGui.PopButtonRepeat();

        public static void PopClipRect() => ImGui.PopClipRect();

        public static void PopFont() => ImGui.PopFont();

        public static void PopID() => ImGui.PopID();

        public static void PopItemWidth() => ImGui.PopItemWidth();

        public static void PopStyleColor() => ImGui.PopStyleColor();

        public static void PopStyleColor(int count) => ImGui.PopStyleColor(count);

        public static void PopStyleVar() => ImGui.PopStyleVar();

        public static void PopStyleVar(int count) => ImGui.PopStyleVar(count);

        public static void PopTextWrapPos() => ImGui.PopTextWrapPos();

        public static void ProgressBar(float fraction) => ImGui.ProgressBar(fraction);

        public static void ProgressBar(float fraction, Vector2 size_arg) => ImGui.ProgressBar(fraction, size_arg);

        public static void ProgressBar(float fraction, Vector2 size_arg, string overlay) => ImGui.ProgressBar(fraction, size_arg, overlay);

        public static void PushAllowKeyboardFocus(bool allow_keyboard_focus) => ImGui.PushAllowKeyboardFocus(allow_keyboard_focus);

        public static void PushButtonRepeat(bool repeat) => ImGui.PushButtonRepeat(repeat);

        public static void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect) => ImGui.PushClipRect(clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);

        public static void PushFont(ImFontPtr font) => ImGui.PushFont(font);

        public static void PushID(string str_id) => ImGui.PushID(str_id);

        public static void PushID(IntPtr ptr_id) => ImGui.PushID(ptr_id);

        public static void PushID(int int_id) => ImGui.PushID(int_id);

        public static void PushItemWidth(float item_width) => ImGui.PushItemWidth(item_width);

        public static void PushStyleColor(ImGuiCol idx, uint col) => ImGui.PushStyleColor(idx, col);

        public static void PushStyleColor(ImGuiCol idx, Vector4 col) => ImGui.PushStyleColor(idx, col);

        public static void PushStyleVar(ImGuiStyleVar idx, float val) => ImGui.PushStyleVar(idx, val);

        public static void PushStyleVar(ImGuiStyleVar idx, Vector2 val) => ImGui.PushStyleVar(idx, val);

        public static void PushTextWrapPos() => ImGui.PushTextWrapPos();

        public static void PushTextWrapPos(float wrap_local_pos_x) => ImGui.PushTextWrapPos(wrap_local_pos_x);

        public static bool RadioButton(string label, bool active) => ImGui.RadioButton(label, active);

        public static bool RadioButton(string label, ref int v, int v_button) => ImGui.RadioButton(label, ref v, v_button);

        public static void Render() => ImGui.Render();

        public static void ResetMouseDragDelta() => ImGui.ResetMouseDragDelta();

        public static void ResetMouseDragDelta(int button) => ImGui.ResetMouseDragDelta(button);

        public static void SameLine() => ImGui.SameLine();

        public static void SameLine(float local_pos_x) => ImGui.SameLine(local_pos_x);

        public static void SameLine(float local_pos_x, float spacing_w) => ImGui.SameLine(local_pos_x, spacing_w);

        public static bool Selectable(string label) => ImGui.Selectable(label);

        public static bool Selectable(string label, bool selected) => ImGui.Selectable(label, selected);

        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags) => ImGui.Selectable(label, selected, flags);

        public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags, Vector2 size) => ImGui.Selectable(label, selected, flags, size);

        public static bool Selectable(string label, ref bool p_selected) => ImGui.Selectable(label, ref p_selected);

        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags) => ImGui.Selectable(label, ref p_selected, flags);

        public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags, Vector2 size) => ImGui.Selectable(label, ref p_selected, flags, size);

        public static void Separator() => ImGui.Separator();

        public static void SetClipboardText(string text) => ImGui.SetClipboardText(text);

        public static void SetColorEditOptions(ImGuiColorEditFlags flags) => ImGui.SetColorEditOptions(flags);

        public static void SetColumnOffset(int column_index, float offset_x) => ImGui.SetColumnOffset(column_index, offset_x);

        public static void SetColumnWidth(int column_index, float width) => ImGui.SetColumnWidth(column_index, width);

        public static void SetCurrentContext(IntPtr ctx) => ImGui.SetCurrentContext(ctx);

        public static void SetCursorPos(Vector2 local_pos) => ImGui.SetCursorPos(local_pos);

        public static void SetCursorPosX(float local_x) => ImGui.SetCursorPosX(local_x);

        public static void SetCursorPosY(float local_y) => ImGui.SetCursorPosY(local_y);

        public static void SetCursorScreenPos(Vector2 pos) => ImGui.SetCursorScreenPos(pos);

        public static bool SetDragDropPayload(string type, IntPtr data, uint size) => ImGui.SetDragDropPayload(type, data, size);

        public static bool SetDragDropPayload(string type, IntPtr data, uint size, ImGuiCond cond) => ImGui.SetDragDropPayload(type, data, size, cond);

        public static void SetItemAllowOverlap() => ImGui.SetItemAllowOverlap();

        public static void SetItemDefaultFocus() => ImGui.SetItemDefaultFocus();

        public static void SetKeyboardFocusHere() => ImGui.SetKeyboardFocusHere();

        public static void SetKeyboardFocusHere(int offset) => ImGui.SetKeyboardFocusHere(offset);

        public static void SetMouseCursor(ImGuiMouseCursor type) => ImGui.SetMouseCursor(type);

        public static void SetNextTreeNodeOpen(bool is_open) => ImGui.SetNextTreeNodeOpen(is_open);

        public static void SetNextTreeNodeOpen(bool is_open, ImGuiCond cond) => ImGui.SetNextTreeNodeOpen(is_open, cond);

        public static void SetNextWindowBgAlpha(float alpha) => ImGui.SetNextWindowBgAlpha(alpha);

        public static void SetNextWindowCollapsed(bool collapsed) => ImGui.SetNextWindowCollapsed(collapsed);

        public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond) => ImGui.SetNextWindowCollapsed(collapsed, cond);

        public static void SetNextWindowContentSize(Vector2 size) => ImGui.SetNextWindowContentSize(size);

        public static void SetNextWindowFocus() => ImGui.SetNextWindowFocus();

        public static void SetNextWindowPos(Vector2 pos) => ImGui.SetNextWindowPos(pos);

        public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond) => ImGui.SetNextWindowPos(pos, cond);

        public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot) => ImGui.SetNextWindowPos(pos, cond, pivot);

        public static void SetNextWindowSize(Vector2 size) => ImGui.SetNextWindowSize(size);

        public static void SetNextWindowSize(Vector2 size, ImGuiCond cond) => ImGui.SetNextWindowSize(size, cond);

        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max) => ImGui.SetNextWindowSizeConstraints(size_min, size_max);

        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback) => ImGui.SetNextWindowSizeConstraints(size_min, size_max, custom_callback);

        public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, IntPtr custom_callback_data) => ImGui.SetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);

        public static void SetScrollFromPosY(float local_y) => ImGui.SetScrollFromPosY(local_y);

        public static void SetScrollFromPosY(float local_y, float center_y_ratio) => ImGui.SetScrollFromPosY(local_y, center_y_ratio);

        public static void SetScrollHereY() => ImGui.SetScrollHereY();

        public static void SetScrollHereY(float center_y_ratio) => ImGui.SetScrollHereY(center_y_ratio);

        public static void SetScrollX(float scroll_x) => ImGui.SetScrollX(scroll_x);

        public static void SetScrollY(float scroll_y) => ImGui.SetScrollY(scroll_y);

        public static void SetStateStorage(ImGuiStoragePtr storage) => ImGui.SetStateStorage(storage);

        public static void SetTabItemClosed(string tab_or_docked_window_label) => ImGui.SetTabItemClosed(tab_or_docked_window_label);

        public static void SetTooltip(string fmt) => ImGui.SetTooltip(fmt);

        public static void SetWindowCollapsed(bool collapsed) => ImGui.SetWindowCollapsed(collapsed);

        public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond) => ImGui.SetWindowCollapsed(collapsed, cond);

        public static void SetWindowCollapsed(string name, bool collapsed) => ImGui.SetWindowCollapsed(name, collapsed);

        public static void SetWindowCollapsed(string name, bool collapsed, ImGuiCond cond) => ImGui.SetWindowCollapsed(name, collapsed, cond);

        public static void SetWindowFocus() => ImGui.SetWindowFocus();

        public static void SetWindowFocus(string name) => ImGui.SetWindowFocus(name);

        public static void SetWindowFontScale(float scale) => ImGui.SetWindowFontScale(scale);

        public static void SetWindowPos(Vector2 pos) => ImGui.SetWindowPos(pos);

        public static void SetWindowPos(Vector2 pos, ImGuiCond cond) => ImGui.SetWindowPos(pos, cond);

        public static void SetWindowPos(string name, Vector2 pos) => ImGui.SetWindowPos(name, pos);

        public static void SetWindowPos(string name, Vector2 pos, ImGuiCond cond) => ImGui.SetWindowPos(name, pos, cond);

        public static void SetWindowSize(Vector2 size) => ImGui.SetWindowSize(size);

        public static void SetWindowSize(Vector2 size, ImGuiCond cond) => ImGui.SetWindowSize(size, cond);

        public static void SetWindowSize(string name, Vector2 size) => ImGui.SetWindowSize(name, size);

        public static void SetWindowSize(string name, Vector2 size, ImGuiCond cond) => ImGui.SetWindowSize(name, size, cond);

        public static void ShowAboutWindow() => ImGui.ShowAboutWindow();

        public static void ShowAboutWindow(ref bool p_open) => ImGui.ShowAboutWindow(ref p_open);

        public static void ShowDemoWindow() => ImGui.ShowDemoWindow();

        public static void ShowDemoWindow(ref bool p_open) => ImGui.ShowDemoWindow(ref p_open);

        public static void ShowFontSelector(string label) => ImGui.ShowFontSelector(label);

        public static void ShowMetricsWindow() => ImGui.ShowMetricsWindow();

        public static void ShowMetricsWindow(ref bool p_open) => ImGui.ShowMetricsWindow(ref p_open);

        public static void ShowStyleEditor() => ImGui.ShowStyleEditor();

        public static void ShowStyleEditor(ImGuiStylePtr ptr) => ImGui.ShowStyleEditor(ptr);

        public static bool ShowStyleSelector(string label) => ImGui.ShowStyleSelector(label);

        public static void ShowUserGuide() => ImGui.ShowUserGuide();

        public static bool SliderAngle(string label, ref float v_rad) => ImGui.SliderAngle(label, ref v_rad);

        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min) => ImGui.SliderAngle(label, ref v_rad, v_degrees_min);

        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max) => ImGui.SliderAngle(label, ref v_rad, v_degrees_min, v_degrees_max);

        public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, string format) => ImGui.SliderAngle(label, ref v_rad, v_degrees_min, v_degrees_max, format);

        public static bool SliderFloat(string label, ref float v, float v_min, float v_max) => ImGui.SliderFloat(label, ref v, v_min, v_max);

        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format) => ImGui.SliderFloat(label, ref v, v_min, v_max, format);

        public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format, float power) => ImGui.SliderFloat(label, ref v, v_min, v_max, format, power);

        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max) => ImGui.SliderFloat2(label, ref v, v_min, v_max);

        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string format) => ImGui.SliderFloat2(label, ref v, v_min, v_max, format);

        public static bool SliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string format, float power) => ImGui.SliderFloat2(label, ref v, v_min, v_max, format, power);

        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max) => ImGui.SliderFloat3(label, ref v, v_min, v_max);

        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string format) => ImGui.SliderFloat3(label, ref v, v_min, v_max, format);

        public static bool SliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string format, float power) => ImGui.SliderFloat3(label, ref v, v_min, v_max, format, power);

        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max) => ImGui.SliderFloat4(label, ref v, v_min, v_max);

        public static bool SliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string format) => ImGui.SliderFloat4(label, ref v, v_min, v_max, format);

        public static bool InputDouble(string label, ref Double v, Double step) => ImGui.InputDouble(label, ref v, step);

        public static bool InputDouble(string label, ref Double v, Double step, Double step_fast) => ImGui.InputDouble(label, ref v, step, step_fast);

        public static bool InputDouble(string label, ref Double v, Double step, Double step_fast, string format) => ImGui.InputDouble(label, ref v, step, step_fast, format);

        public static bool InputDouble(string label, ref Double v, Double step, Double step_fast, string format, ImGuiInputTextFlags flags) => ImGui.InputDouble(label, ref v, step, step_fast, format, flags);

        public static bool InputFloat(string label, ref float v) => ImGui.InputFloat(label, ref v);

        public static bool InputFloat(string label, ref float v, float step) => ImGui.InputFloat(label, ref v, step);

        public static bool InputFloat(string label, ref float v, float step, float step_fast) => ImGui.InputFloat(label, ref v, step, step_fast);

        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format) => ImGui.InputFloat(label, ref v, step, step_fast, format);

        public static bool InputFloat(string label, ref float v, float step, float step_fast, string format, ImGuiInputTextFlags flags) => ImGui.InputFloat(label, ref v, step, step_fast, format, flags);

        public static bool InputFloat2(string label, ref Vector2 v) => ImGui.InputFloat2(label, ref v);

        public static bool InputFloat2(string label, ref Vector2 v, string format) => ImGui.InputFloat2(label, ref v, format);

        public static bool InputFloat2(string label, ref Vector2 v, string format, ImGuiInputTextFlags flags) => ImGui.InputFloat2(label, ref v, format, flags);

        public static bool InputFloat3(string label, ref Vector3 v) => ImGui.InputFloat3(label, ref v);

        public static bool InputFloat3(string label, ref Vector3 v, string format) => ImGui.InputFloat3(label, ref v, format);

        public static bool InputFloat3(string label, ref Vector3 v, string format, ImGuiInputTextFlags flags) => ImGui.InputFloat3(label, ref v, format, flags);

        public static bool InputFloat4(string label, ref Vector4 v) => ImGui.InputFloat4(label, ref v);

        public static bool InputFloat4(string label, ref Vector4 v, string format) => ImGui.InputFloat4(label, ref v, format);

        public static bool InputFloat4(string label, ref Vector4 v, string format, ImGuiInputTextFlags flags) => ImGui.InputFloat4(label, ref v, format, flags);

        public static bool InputInt(string label, ref int v) => ImGui.InputInt(label, ref v);

        public static bool InputInt(string label, ref int v, int step) => ImGui.InputInt(label, ref v, step);

        public static bool InputInt(string label, ref int v, int step, int step_fast) => ImGui.InputInt(label, ref v, step, step_fast);

        public static bool InputInt(string label, ref int v, int step, int step_fast, ImGuiInputTextFlags flags) => ImGui.InputInt(label, ref v, step, step_fast, flags);

        public static bool InputInt2(string label, ref int v) => ImGui.InputInt2(label, ref v);

        public static bool InputInt2(string label, ref int v, ImGuiInputTextFlags flags) => ImGui.InputInt2(label, ref v, flags);

        public static bool InputInt3(string label, ref int v) => ImGui.InputInt3(label, ref v);

        public static bool InputInt3(string label, ref int v, ImGuiInputTextFlags flags) => ImGui.InputInt3(label, ref v, flags);

        public static bool InputInt4(string label, ref int v) => ImGui.InputInt4(label, ref v);

        public static bool InputInt4(string label, ref int v, ImGuiInputTextFlags flags) => ImGui.InputInt4(label, ref v, flags);

        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr v) => ImGui.InputScalar(label, data_type, v);

        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr v, IntPtr step) => ImGui.InputScalar(label, data_type, v, step);

        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr v, IntPtr step, IntPtr step_fast) => ImGui.InputScalar(label, data_type, v, step, step_fast);

        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr v, IntPtr step, IntPtr step_fast, string format) => ImGui.InputScalar(label, data_type, v, step, step_fast, format);

        public static bool InputScalar(string label, ImGuiDataType data_type, IntPtr v, IntPtr step, IntPtr step_fast, string format, ImGuiInputTextFlags flags) => ImGui.InputScalar(label, data_type, v, step, step_fast, format, flags);

        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr v, int components) => ImGui.InputScalarN(label, data_type, v, components);

        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, IntPtr step) => ImGui.InputScalarN(label, data_type, v, components, step);

        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, IntPtr step, IntPtr step_fast) => ImGui.InputScalarN(label, data_type, v, components, step, step_fast);

        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, IntPtr step, IntPtr step_fast, string format) => ImGui.InputScalarN(label, data_type, v, components, step, step_fast, format);

        public static bool InputScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, IntPtr step, IntPtr step_fast, string format, ImGuiInputTextFlags flags) => ImGui.InputScalarN(label, data_type, v, components, step, step_fast, format, flags);

        public static bool InvisibleButton(string str_id, Vector2 size) => ImGui.InvisibleButton(str_id, size);

        public static bool IsAnyItemActive() => ImGui.IsAnyItemActive();

        public static bool IsAnyItemFocused() => ImGui.IsAnyItemFocused();

        public static bool IsAnyItemHovered() => ImGui.IsAnyItemHovered();

        public static bool IsAnyMouseDown() => ImGui.IsAnyMouseDown();

        public static bool IsItemActive() => ImGui.IsItemActive();

        public static bool IsItemClicked() => ImGui.IsItemClicked();

        public static bool IsItemClicked(int mouse_button) => ImGui.IsItemClicked(mouse_button);

        public static bool IsItemDeactivated() => ImGui.IsItemDeactivated();

        public static bool IsItemDeactivatedAfterEdit() => ImGui.IsItemDeactivatedAfterEdit();

        public static bool IsItemEdited() => ImGui.IsItemEdited();

        public static bool IsItemFocused() => ImGui.IsItemFocused();

        public static bool IsItemHovered() => ImGui.IsItemHovered();

        public static bool IsItemHovered(ImGuiHoveredFlags flags) => ImGui.IsItemHovered(flags);

        public static bool IsItemVisible() => ImGui.IsItemVisible();

        public static bool IsKeyDown(int user_key_index) => ImGui.IsKeyDown(user_key_index);

        public static bool IsKeyPressed(int user_key_index) => ImGui.IsKeyPressed(user_key_index);

        public static bool IsKeyPressed(int user_key_index, bool repeat) => ImGui.IsKeyPressed(user_key_index, repeat);

        public static bool IsKeyReleased(int user_key_index) => ImGui.IsKeyReleased(user_key_index);

        public static bool IsMouseClicked(int button) => ImGui.IsMouseClicked(button);

        public static bool IsMouseClicked(int button, bool repeat) => ImGui.IsMouseClicked(button, repeat);

        public static bool IsMouseDoubleClicked(int button) => ImGui.IsMouseDoubleClicked(button);

        public static bool IsMouseDown(int button) => ImGui.IsMouseDown(button);

        public static bool IsMouseDragging() => ImGui.IsMouseDragging();

        public static bool IsMouseDragging(int button) => ImGui.IsMouseDragging(button);

        public static bool IsMouseDragging(int button, float lock_threshold) => ImGui.IsMouseDragging(button, lock_threshold);

        public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max) => ImGui.IsMouseHoveringRect(r_min, r_max);

        public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max, bool clip) => ImGui.IsMouseHoveringRect(r_min, r_max, clip);

        public static bool IsMousePosValid() => ImGui.IsMousePosValid();

        public static bool IsMousePosValid(ref Vector2 mouse_pos) => ImGui.IsMousePosValid(ref mouse_pos);

        public static bool IsMouseReleased(int button) => ImGui.IsMouseReleased(button);

        public static bool IsPopupOpen(string str_id) => ImGui.IsPopupOpen(str_id);

        public static bool IsRectVisible(Vector2 size) => ImGui.IsRectVisible(size);

        public static bool IsRectVisible(Vector2 rect_min, Vector2 rect_max) => ImGui.IsRectVisible(rect_min, rect_max);

        public static bool IsWindowAppearing() => ImGui.IsWindowAppearing();

        public static bool IsWindowCollapsed() => ImGui.IsWindowCollapsed();

        public static bool IsWindowFocused() => ImGui.IsWindowFocused();

        public static bool IsWindowFocused(ImGuiFocusedFlags flags) => ImGui.IsWindowFocused(flags);

        public static bool IsWindowHovered() => ImGui.IsWindowHovered();

        public static bool IsWindowHovered(ImGuiHoveredFlags flags) => ImGui.IsWindowHovered(flags);

        public static void LabelText(string label, string fmt) => ImGui.LabelText(label, fmt);

        public static bool ListBox(string label, ref int current_item, string[] items, int items_count) => ImGui.ListBox(label, ref current_item, items, items_count);

        public static bool ListBox(string label, ref int current_item, string[] items, int items_count, int height_in_items) => ImGui.ListBox(label, ref current_item, items, items_count, height_in_items);

        public static void ListBoxFooter() => ImGui.ListBoxFooter();

        public static bool ListBoxHeader(string label) => ImGui.ListBoxHeader(label);

        public static bool ListBoxHeader(string label, Vector2 size) => ImGui.ListBoxHeader(label, size);

        public static bool ListBoxHeader(string label, int items_count) => ImGui.ListBoxHeader(label, items_count);

        public static bool ListBoxHeader(string label, int items_count, int height_in_items) => ImGui.ListBoxHeader(label, items_count, height_in_items);

        public static void LoadIniSettingsFromDisk(string ini_filename) => ImGui.LoadIniSettingsFromDisk(ini_filename);

        public static void LoadIniSettingsFromMemory(string ini_data) => ImGui.LoadIniSettingsFromMemory(ini_data);

        public static void LoadIniSettingsFromMemory(string ini_data, uint ini_size) => ImGui.LoadIniSettingsFromMemory(ini_data, ini_size);

        public static void LogButtons() => ImGui.LogButtons();

        public static void LogFinish() => ImGui.LogFinish();

        public static void LogText(string fmt) => ImGui.LogText(fmt);

        public static void LogToClipboard() => ImGui.LogToClipboard();

        public static void LogToClipboard(int max_depth) => ImGui.LogToClipboard(max_depth);

        public static void LogToFile() => ImGui.LogToFile();

        public static void LogToFile(int max_depth) => ImGui.LogToFile(max_depth);

        public static void LogToFile(int max_depth, string filename) => ImGui.LogToFile(max_depth, filename);

        public static void LogToTTY() => ImGui.LogToTTY();

        public static void LogToTTY(int max_depth) => ImGui.LogToTTY(max_depth);

        public static IntPtr MemAlloc(uint size) => ImGui.MemAlloc(size);

        public static void MemFree(IntPtr ptr) => ImGui.MemFree(ptr);

        public static bool MenuItem(string label) => ImGui.MenuItem(label);

        public static bool MenuItem(string label, string shortcut) => ImGui.MenuItem(label, shortcut);

        public static bool MenuItem(string label, string shortcut, bool selected) => ImGui.MenuItem(label, shortcut, selected);

        public static bool MenuItem(string label, string shortcut, bool selected, bool enabled) => ImGui.MenuItem(label, shortcut, selected, enabled);

        public static bool MenuItem(string label, string shortcut, ref bool p_selected) => ImGui.MenuItem(label, shortcut, ref p_selected);

        public static bool MenuItem(string label, string shortcut, ref bool p_selected, bool enabled) => ImGui.MenuItem(label, shortcut, ref p_selected, enabled);

        public static void NewFrame() => ImGui.NewFrame();

        public static void NewLine() => ImGui.NewLine();

        public static void NextColumn() => ImGui.NextColumn();

        public static void OpenPopup(string str_id) => ImGui.OpenPopup(str_id);

        public static bool OpenPopupOnItemClick() => ImGui.OpenPopupOnItemClick();

        public static bool OpenPopupOnItemClick(string str_id) => ImGui.OpenPopupOnItemClick(str_id);

        public static bool OpenPopupOnItemClick(string str_id, int mouse_button) => ImGui.OpenPopupOnItemClick(str_id, mouse_button);

        public static void PlotHistogram(string label, ref float values, int values_count) => ImGui.PlotHistogram(label, ref values, values_count);

        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset) => ImGui.PlotHistogram(label, ref values, values_count, values_offset);

        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text) => ImGui.PlotHistogram(label, ref values, values_count, values_offset, overlay_text);

        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min) => ImGui.PlotHistogram(label, ref values, values_count, values_offset, overlay_text, scale_min);

        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max) => ImGui.PlotHistogram(label, ref values, values_count, values_offset, overlay_text, scale_min, scale_max);

        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size) => ImGui.PlotHistogram(label, ref values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size);

        public static void PlotHistogram(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride) => ImGui.PlotHistogram(label, ref values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size, stride);

        public static void PlotLines(string label, ref float values, int values_count) => ImGui.PlotLines(label, ref values, values_count);

        public static void PlotLines(string label, ref float values, int values_count, int values_offset) => ImGui.PlotLines(label, ref values, values_count, values_offset);

        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text) => ImGui.PlotLines(label, ref values, values_count, values_offset, overlay_text);

        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min) => ImGui.PlotLines(label, ref values, values_count, values_offset, overlay_text, scale_min);

        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max) => ImGui.PlotLines(label, ref values, values_count, values_offset, overlay_text, scale_min, scale_max);

        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size) => ImGui.PlotLines(label, ref values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size);

        public static void PlotLines(string label, ref float values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride) => ImGui.PlotLines(label, ref values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size, stride);

        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max) => ImGui.DragInt(label, ref v, v_speed, v_min, v_max);

        public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format) => ImGui.DragInt(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragInt2(string label, ref int v) => ImGui.DragInt2(label, ref v);

        public static bool DragInt2(string label, ref int v, float v_speed) => ImGui.DragInt2(label, ref v, v_speed);

        public static bool DragInt2(string label, ref int v, float v_speed, int v_min) => ImGui.DragInt2(label, ref v, v_speed, v_min);

        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max) => ImGui.DragInt2(label, ref v, v_speed, v_min, v_max);

        public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, string format) => ImGui.DragInt2(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragInt3(string label, ref int v) => ImGui.DragInt3(label, ref v);

        public static bool DragInt3(string label, ref int v, float v_speed) => ImGui.DragInt3(label, ref v, v_speed);

        public static bool DragInt3(string label, ref int v, float v_speed, int v_min) => ImGui.DragInt3(label, ref v, v_speed, v_min);

        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max) => ImGui.DragInt3(label, ref v, v_speed, v_min, v_max);

        public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, string format) => ImGui.DragInt3(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragInt4(string label, ref int v) => ImGui.DragInt4(label, ref v);

        public static bool DragInt4(string label, ref int v, float v_speed) => ImGui.DragInt4(label, ref v, v_speed);

        public static bool DragInt4(string label, ref int v, float v_speed, int v_min) => ImGui.DragInt4(label, ref v, v_speed, v_min);

        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max) => ImGui.DragInt4(label, ref v, v_speed, v_min, v_max);

        public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, string format) => ImGui.DragInt4(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max) => ImGui.DragIntRange2(label, ref v_current_min, ref v_current_max);

        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed) => ImGui.DragIntRange2(label, ref v_current_min, ref v_current_max, v_speed);

        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min) => ImGui.DragIntRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min);

        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max) => ImGui.DragIntRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min, v_max);

        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format) => ImGui.DragIntRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min, v_max, format);

        public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max) => ImGui.DragIntRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min, v_max, format, format_max);

        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr v, float v_speed) => ImGui.DragScalar(label, data_type, v, v_speed);

        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr v, float v_speed, IntPtr v_min) => ImGui.DragScalar(label, data_type, v, v_speed, v_min);

        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr v, float v_speed, IntPtr v_min, IntPtr v_max) => ImGui.DragScalar(label, data_type, v, v_speed, v_min, v_max);

        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr v, float v_speed, IntPtr v_min, IntPtr v_max, string format) => ImGui.DragScalar(label, data_type, v, v_speed, v_min, v_max, format);

        public static bool DragScalar(string label, ImGuiDataType data_type, IntPtr v, float v_speed, IntPtr v_min, IntPtr v_max, string format, float power) => ImGui.DragScalar(label, data_type, v, v_speed, v_min, v_max, format, power);

        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, float v_speed) => ImGui.DragScalarN(label, data_type, v, components, v_speed);

        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, float v_speed, IntPtr v_min) => ImGui.DragScalarN(label, data_type, v, components, v_speed, v_min);

        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, float v_speed, IntPtr v_min, IntPtr v_max) => ImGui.DragScalarN(label, data_type, v, components, v_speed, v_min, v_max);

        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, float v_speed, IntPtr v_min, IntPtr v_max, string format) => ImGui.DragScalarN(label, data_type, v, components, v_speed, v_min, v_max, format);

        public static bool DragScalarN(string label, ImGuiDataType data_type, IntPtr v, int components, float v_speed, IntPtr v_min, IntPtr v_max, string format, float power) => ImGui.DragScalarN(label, data_type, v, components, v_speed, v_min, v_max, format, power);

        public static void Dummy(Vector2 size) => ImGui.Dummy(size);

        public static void End() => ImGui.End();

        public static void EndChild() => ImGui.EndChild();

        public static void EndChildFrame() => ImGui.EndChildFrame();

        public static void EndCombo() => ImGui.EndCombo();

        public static void EndDragDropSource() => ImGui.EndDragDropSource();

        public static void EndDragDropTarget() => ImGui.EndDragDropTarget();

        public static void EndFrame() => ImGui.EndFrame();

        public static void EndGroup() => ImGui.EndGroup();

        public static void EndMainMenuBar() => ImGui.EndMainMenuBar();

        public static void EndMenu() => ImGui.EndMenu();

        public static void EndMenuBar() => ImGui.EndMenuBar();

        public static void EndPopup() => ImGui.EndPopup();

        public static void EndTabBar() => ImGui.EndTabBar();

        public static void EndTabItem() => ImGui.EndTabItem();

        public static void EndTooltip() => ImGui.EndTooltip();

        public static string GetClipboardText() => ImGui.GetClipboardText();

        public static uint GetColorU32(ImGuiCol idx) => ImGui.GetColorU32(idx);

        public static uint GetColorU32(ImGuiCol idx, float alpha_mul) => ImGui.GetColorU32(idx, alpha_mul);

        public static uint GetColorU32(Vector4 col) => ImGui.GetColorU32(col);

        public static uint GetColorU32(uint col) => ImGui.GetColorU32(col);

        public static int GetColumnIndex() => ImGui.GetColumnIndex();

        public static float GetColumnOffset() => ImGui.GetColumnOffset();

        public static float GetColumnOffset(int column_index) => ImGui.GetColumnOffset(column_index);

        public static int GetColumnsCount() => ImGui.GetColumnsCount();

        public static float GetColumnWidth() => ImGui.GetColumnWidth();

        public static float GetColumnWidth(int column_index) => ImGui.GetColumnWidth(column_index);

        public static Vector2 GetContentRegionAvail() => ImGui.GetContentRegionAvail();

        public static float GetContentRegionAvailWidth() => ImGui.GetContentRegionAvailWidth();

        public static Vector2 GetContentRegionMax() => ImGui.GetContentRegionMax();

        public static IntPtr GetCurrentContext() => ImGui.GetCurrentContext();

        public static Vector2 GetCursorPos() => ImGui.GetCursorPos();

        public static float GetCursorPosX() => ImGui.GetCursorPosX();

        public static float GetCursorPosY() => ImGui.GetCursorPosY();

        public static Vector2 GetCursorScreenPos() => ImGui.GetCursorScreenPos();

        public static Vector2 GetCursorStartPos() => ImGui.GetCursorStartPos();

        public static ImGuiPayloadPtr GetDragDropPayload() => ImGui.GetDragDropPayload();

        public static ImDrawDataPtr GetDrawData() => ImGui.GetDrawData();

        public static IntPtr GetDrawListSharedData() => ImGui.GetDrawListSharedData();

        public static ImFontPtr GetFont() => ImGui.GetFont();

        public static float GetFontSize() => ImGui.GetFontSize();

        public static Vector2 GetFontTexUvWhitePixel() => ImGui.GetFontTexUvWhitePixel();

        public static int GetFrameCount() => ImGui.GetFrameCount();

        public static float GetFrameHeight() => ImGui.GetFrameHeight();

        public static float GetFrameHeightWithSpacing() => ImGui.GetFrameHeightWithSpacing();

        public static uint GetID(string str_id) => ImGui.GetID(str_id);

        public static uint GetID(IntPtr ptr_id) => ImGui.GetID(ptr_id);

        public static ImGuiIOPtr GetIO() => ImGui.GetIO();

        public static Vector2 GetItemRectMax() => ImGui.GetItemRectMax();

        public static Vector2 GetItemRectMin() => ImGui.GetItemRectMin();

        public static Vector2 GetItemRectSize() => ImGui.GetItemRectSize();

        public static int GetKeyIndex(ImGuiKey imgui_key) => ImGui.GetKeyIndex(imgui_key);

        public static int GetKeyPressedAmount(int key_index, float repeat_delay, float rate) => ImGui.GetKeyPressedAmount(key_index, repeat_delay, rate);

        public static ImGuiMouseCursor GetMouseCursor() => ImGui.GetMouseCursor();

        public static Vector2 GetMouseDragDelta() => ImGui.GetMouseDragDelta();

        public static Vector2 GetMouseDragDelta(int button) => ImGui.GetMouseDragDelta(button);

        public static Vector2 GetMouseDragDelta(int button, float lock_threshold) => ImGui.GetMouseDragDelta(button, lock_threshold);

        public static Vector2 GetMousePos() => ImGui.GetMousePos();

        public static Vector2 GetMousePosOnOpeningCurrentPopup() => ImGui.GetMousePosOnOpeningCurrentPopup();

        public static ImDrawListPtr GetOverlayDrawList() => ImGui.GetOverlayDrawList();

        public static float GetScrollMaxX() => ImGui.GetScrollMaxX();

        public static float GetScrollMaxY() => ImGui.GetScrollMaxY();

        public static float GetScrollX() => ImGui.GetScrollX();

        public static float GetScrollY() => ImGui.GetScrollY();

        public static ImGuiStoragePtr GetStateStorage() => ImGui.GetStateStorage();

        public static ImGuiStylePtr GetStyle() => ImGui.GetStyle();

        public static string GetStyleColorName(ImGuiCol idx) => ImGui.GetStyleColorName(idx);
        public static float GetTextLineHeight() => ImGui.GetTextLineHeight();

        public static float GetTextLineHeightWithSpacing() => ImGui.GetTextLineHeightWithSpacing();

        public static Double GetTime() => ImGui.GetTime();

        public static float GetTreeNodeToLabelSpacing() => ImGui.GetTreeNodeToLabelSpacing();

        public static string GetVersion() => ImGui.GetVersion();

        public static Vector2 GetWindowContentRegionMax() => ImGui.GetWindowContentRegionMax();

        public static Vector2 GetWindowContentRegionMin() => ImGui.GetWindowContentRegionMin();

        public static float GetWindowContentRegionWidth() => ImGui.GetWindowContentRegionWidth();

        public static ImDrawListPtr GetWindowDrawList() => ImGui.GetWindowDrawList();

        public static float GetWindowHeight() => ImGui.GetWindowHeight();

        public static Vector2 GetWindowPos() => ImGui.GetWindowPos();

        public static Vector2 GetWindowSize() => ImGui.GetWindowSize();

        public static float GetWindowWidth() => ImGui.GetWindowWidth();

        public static void Image(IntPtr user_texture_id, Vector2 size) => ImGui.Image(user_texture_id, size);

        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0) => ImGui.Image(user_texture_id, size, uv0);

        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1) => ImGui.Image(user_texture_id, size, uv0, uv1);

        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col) => ImGui.Image(user_texture_id, size, uv0, uv1, tint_col);

        public static void Image(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col) => ImGui.Image(user_texture_id, size, uv0, uv1, tint_col, border_col);

        public static bool ImageButton(IntPtr user_texture_id, Vector2 size) => ImGui.ImageButton(user_texture_id, size);

        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0) => ImGui.ImageButton(user_texture_id, size, uv0);

        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1) => ImGui.ImageButton(user_texture_id, size, uv0, uv1);

        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding) => ImGui.ImageButton(user_texture_id, size, uv0, uv1, frame_padding);

        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col) => ImGui.ImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col);

        public static bool ImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col) => ImGui.ImageButton(user_texture_id, size, uv0, uv1, frame_padding, bg_col, tint_col);

        public static void Indent() => ImGui.Indent();

        public static void Indent(float indent_w) => ImGui.Indent(indent_w);

        public static bool InputDouble(string label, ref Double v) => ImGui.InputDouble(label, ref v);

        public static ImGuiPayloadPtr AcceptDragDropPayload(string type) => ImGui.AcceptDragDropPayload(type);

        public static ImGuiPayloadPtr AcceptDragDropPayload(string type, ImGuiDragDropFlags flags) => ImGui.AcceptDragDropPayload(type, flags);

        public static void AlignTextToFramePadding() => ImGui.AlignTextToFramePadding();

        public static bool ArrowButton(string str_id, ImGuiDir dir) => ImGui.ArrowButton(str_id, dir);

        public static bool Begin(string name) => ImGui.Begin(name);

        public static bool Begin(string name, ref bool p_open) => ImGui.Begin(name, ref p_open);

        public static bool Begin(string name, ref bool p_open, ImGuiWindowFlags flags) => ImGui.Begin(name, ref p_open, flags);

        public static bool BeginChild(string str_id) => ImGui.BeginChild(str_id);

        public static bool BeginChild(string str_id, Vector2 size) => ImGui.BeginChild(str_id, size);

        public static bool BeginChild(string str_id, Vector2 size, bool border) => ImGui.BeginChild(str_id, size, border);

        public static bool BeginChild(string str_id, Vector2 size, bool border, ImGuiWindowFlags flags) => ImGui.BeginChild(str_id, size, border, flags);

        public static bool BeginChild(uint id) => ImGui.BeginChild(id);

        public static bool BeginChild(uint id, Vector2 size) => ImGui.BeginChild(id, size);

        public static bool BeginChild(uint id, Vector2 size, bool border) => ImGui.BeginChild(id, size, border);

        public static bool BeginChild(uint id, Vector2 size, bool border, ImGuiWindowFlags flags) => ImGui.BeginChild(id, size, border, flags);

        public static bool BeginChildFrame(uint id, Vector2 size) => ImGui.BeginChildFrame(id, size);

        public static bool BeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags) => ImGui.BeginChildFrame(id, size, flags);

        public static bool BeginCombo(string label, string preview_value) => ImGui.BeginCombo(label, preview_value);

        public static bool BeginCombo(string label, string preview_value, ImGuiComboFlags flags) => ImGui.BeginCombo(label, preview_value, flags);

        public static bool BeginDragDropSource() => ImGui.BeginDragDropSource();

        public static bool BeginDragDropSource(ImGuiDragDropFlags flags) => ImGui.BeginDragDropSource(flags);

        public static bool BeginDragDropTarget() => ImGui.BeginDragDropTarget();

        public static void BeginGroup() => ImGui.BeginGroup();

        public static bool BeginMainMenuBar() => ImGui.BeginMainMenuBar();

        public static bool BeginMenu(string label) => ImGui.BeginMenu(label);

        public static bool BeginMenu(string label, bool enabled) => ImGui.BeginMenu(label, enabled);

        public static bool BeginMenuBar() => ImGui.BeginMenuBar();

        public static bool BeginPopup(string str_id) => ImGui.BeginPopup(str_id);

        public static bool BeginPopup(string str_id, ImGuiWindowFlags flags) => ImGui.BeginPopup(str_id, flags);

        public static bool BeginPopupContextItem() => ImGui.BeginPopupContextItem();

        public static bool BeginPopupContextItem(string str_id) => ImGui.BeginPopupContextItem(str_id);

        public static bool BeginPopupContextItem(string str_id, int mouse_button) => ImGui.BeginPopupContextItem(str_id, mouse_button);

        public static bool BeginPopupContextVoid() => ImGui.BeginPopupContextVoid();

        public static bool BeginPopupContextVoid(string str_id) => ImGui.BeginPopupContextVoid(str_id);

        public static bool BeginPopupContextVoid(string str_id, int mouse_button) => ImGui.BeginPopupContextVoid(str_id, mouse_button);

        public static bool BeginPopupContextWindow() => ImGui.BeginPopupContextWindow();

        public static bool BeginPopupContextWindow(string str_id) => ImGui.BeginPopupContextWindow(str_id);

        public static bool BeginPopupContextWindow(string str_id, int mouse_button) => ImGui.BeginPopupContextWindow(str_id, mouse_button);

        public static bool BeginPopupContextWindow(string str_id, int mouse_button, bool also_over_items) => ImGui.BeginPopupContextWindow(str_id, mouse_button, also_over_items);

        public static bool BeginPopupModal(string name) => ImGui.BeginPopupModal(name);

        public static bool BeginPopupModal(string name, ref bool p_open) => ImGui.BeginPopupModal(name, ref p_open);

        public static bool BeginPopupModal(string name, ref bool p_open, ImGuiWindowFlags flags) => ImGui.BeginPopupModal(name, ref p_open, flags);

        public static bool BeginTabBar(string str_id) => ImGui.BeginTabBar(str_id);

        public static bool BeginTabBar(string str_id, ImGuiTabBarFlags flags) => ImGui.BeginTabBar(str_id, flags);

        public static bool BeginTabItem(string label) => ImGui.BeginTabItem(label);

        public static bool BeginTabItem(string label, ref bool p_open) => ImGui.BeginTabItem(label, ref p_open);

        public static bool BeginTabItem(string label, ref bool p_open, ImGuiTabItemFlags flags) => ImGui.BeginTabItem(label, ref p_open, flags);

        public static void BeginTooltip() => ImGui.BeginTooltip();

        public static void Bullet() => ImGui.Bullet();

        public static void BulletText(string fmt) => ImGui.BulletText(fmt);

        public static bool Button(string label) => ImGui.Button(label);

        public static bool Button(string label, Vector2 size) => ImGui.Button(label, size);

        public static float CalcItemWidth() => ImGui.CalcItemWidth();

        public static Vector2 CalcTextSize(string text) => ImGui.CalcTextSize(text);

        public static void CaptureKeyboardFromApp() => ImGui.CaptureKeyboardFromApp();

        public static void CaptureKeyboardFromApp(bool want_capture_keyboard_value) => ImGui.CaptureKeyboardFromApp(want_capture_keyboard_value);

        public static void CaptureMouseFromApp() => ImGui.CaptureMouseFromApp();

        public static void CaptureMouseFromApp(bool want_capture_mouse_value) => ImGui.CaptureMouseFromApp(want_capture_mouse_value);

        public static bool Checkbox(string label, ref bool v) => ImGui.Checkbox(label, ref v);

        public static bool CheckboxFlags(string label, ref uint flags, uint flags_value) => ImGui.CheckboxFlags(label, ref flags, flags_value);

        public static void CloseCurrentPopup() => ImGui.CloseCurrentPopup();

        public static bool CollapsingHeader(string label) => ImGui.CollapsingHeader(label);

        public static bool CollapsingHeader(string label, ImGuiTreeNodeFlags flags) => ImGui.CollapsingHeader(label, flags);

        public static bool CollapsingHeader(string label, ref bool p_open) => ImGui.CollapsingHeader(label, ref p_open);

        public static bool CollapsingHeader(string label, ref bool p_open, ImGuiTreeNodeFlags flags) => ImGui.CollapsingHeader(label, ref p_open, flags);

        public static bool ColorButton(string desc_id, Vector4 col) => ImGui.ColorButton(desc_id, col);

        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags) => ImGui.ColorButton(desc_id, col, flags);

        public static bool ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size) => ImGui.ColorButton(desc_id, col, flags, size);

        public static bool ColorEdit3(string label, ref Vector3 col) => ImGui.ColorEdit3(label, ref col);

        public static bool ColorEdit3(string label, ref Vector3 col, ImGuiColorEditFlags flags) => ImGui.ColorEdit3(label, ref col, flags);

        public static bool ColorEdit4(string label, ref Vector4 col) => ImGui.ColorEdit4(label, ref col);

        public static bool ColorEdit4(string label, ref Vector4 col, ImGuiColorEditFlags flags) => ImGui.ColorEdit4(label, ref col, flags);

        public static bool ColorPicker3(string label, ref Vector3 col) => ImGui.ColorPicker3(label, ref col);

        public static bool ColorPicker3(string label, ref Vector3 col, ImGuiColorEditFlags flags) => ImGui.ColorPicker3(label, ref col, flags);

        public static bool ColorPicker4(string label, ref Vector4 col) => ImGui.ColorPicker4(label, ref col);

        public static bool ColorPicker4(string label, ref Vector4 col, ImGuiColorEditFlags flags) => ImGui.ColorPicker4(label, ref col, flags);

        public static bool ColorPicker4(string label, ref Vector4 col, ImGuiColorEditFlags flags, ref float ref_col) => ImGui.ColorPicker4(label, ref col, flags, ref ref_col);

        public static void Columns() => ImGui.Columns();

        public static void Columns(int count) => ImGui.Columns(count);

        public static void Columns(int count, string id) => ImGui.Columns(count, id);

        public static void Columns(int count, string id, bool border) => ImGui.Columns(count, id, border);

        public static bool Combo(string label, ref int current_item, string[] items, int items_count) => ImGui.Combo(label, ref current_item, items, items_count);

        public static bool Combo(string label, ref int current_item, string[] items, int items_count, int popup_max_height_in_items) => ImGui.Combo(label, ref current_item, items, items_count, popup_max_height_in_items);

        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros) => ImGui.Combo(label, ref current_item, items_separated_by_zeros);

        public static bool Combo(string label, ref int current_item, string items_separated_by_zeros, int popup_max_height_in_items) => ImGui.Combo(label, ref current_item, items_separated_by_zeros, popup_max_height_in_items);

        public static IntPtr CreateContext() => ImGui.CreateContext();

        public static IntPtr CreateContext(ImFontAtlasPtr shared_font_atlas) => ImGui.CreateContext(shared_font_atlas);

        public static bool DebugCheckVersionAndDataLayout(string version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert) => ImGui.DebugCheckVersionAndDataLayout(version_str, sz_io, sz_style, sz_vec2, sz_vec4, sz_drawvert);

        public static void DestroyContext() => ImGui.DestroyContext();

        public static void DestroyContext(IntPtr ctx) => ImGui.DestroyContext(ctx);

        public static bool DragFloat(string label, ref float v) => ImGui.DragFloat(label, ref v);

        public static bool DragFloat(string label, ref float v, float v_speed) => ImGui.DragFloat(label, ref v, v_speed);

        public static bool DragFloat(string label, ref float v, float v_speed, float v_min) => ImGui.DragFloat(label, ref v, v_speed, v_min);

        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max) => ImGui.DragFloat(label, ref v, v_speed, v_min, v_max);

        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format) => ImGui.DragFloat(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format, float power) => ImGui.DragFloat(label, ref v, v_speed, v_min, v_max, format, power);

        public static bool DragFloat2(string label, ref Vector2 v) => ImGui.DragFloat2(label, ref v);

        public static bool DragFloat2(string label, ref Vector2 v, float v_speed) => ImGui.DragFloat2(label, ref v, v_speed);

        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min) => ImGui.DragFloat2(label, ref v, v_speed, v_min);

        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max) => ImGui.DragFloat2(label, ref v, v_speed, v_min, v_max);

        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max, string format) => ImGui.DragFloat2(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragFloat2(string label, ref Vector2 v, float v_speed, float v_min, float v_max, string format, float power) => ImGui.DragFloat2(label, ref v, v_speed, v_min, v_max, format, power);

        public static bool DragFloat3(string label, ref Vector3 v) => ImGui.DragFloat3(label, ref v);

        public static bool DragFloat3(string label, ref Vector3 v, float v_speed) => ImGui.DragFloat3(label, ref v, v_speed);

        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min) => ImGui.DragFloat3(label, ref v, v_speed, v_min);

        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max) => ImGui.DragFloat3(label, ref v, v_speed, v_min, v_max);

        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max, string format) => ImGui.DragFloat3(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragFloat3(string label, ref Vector3 v, float v_speed, float v_min, float v_max, string format, float power) => ImGui.DragFloat3(label, ref v, v_speed, v_min, v_max, format, power);

        public static bool DragFloat4(string label, ref Vector4 v) => ImGui.DragFloat4(label, ref v);

        public static bool DragFloat4(string label, ref Vector4 v, float v_speed) => ImGui.DragFloat4(label, ref v, v_speed);

        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min) => ImGui.DragFloat4(label, ref v, v_speed, v_min);

        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max) => ImGui.DragFloat4(label, ref v, v_speed, v_min, v_max);

        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max, string format) => ImGui.DragFloat4(label, ref v, v_speed, v_min, v_max, format);

        public static bool DragFloat4(string label, ref Vector4 v, float v_speed, float v_min, float v_max, string format, float power) => ImGui.DragFloat4(label, ref v, v_speed, v_min, v_max, format, power);

        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max) => ImGui.DragFloatRange2(label, ref v_current_min, ref v_current_max);

        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed) => ImGui.DragFloatRange2(label, ref v_current_min, ref v_current_max, v_speed);

        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min) => ImGui.DragFloatRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min);

        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max) => ImGui.DragFloatRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min, v_max);

        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format) => ImGui.DragFloatRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min, v_max, format);

        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max) => ImGui.DragFloatRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min, v_max, format, format_max);

        public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max, float power) => ImGui.DragFloatRange2(label, ref v_current_min, ref v_current_max, v_speed, v_min, v_max, format, format_max, power);

        public static bool DragInt(string label, ref int v) => ImGui.DragInt(label, ref v);

        public static bool DragInt(string label, ref int v, float v_speed) => ImGui.DragInt(label, ref v, v_speed);

        public static bool DragInt(string label, ref int v, float v_speed, int v_min) => ImGui.DragInt(label, ref v, v_speed, v_min);
    }
}