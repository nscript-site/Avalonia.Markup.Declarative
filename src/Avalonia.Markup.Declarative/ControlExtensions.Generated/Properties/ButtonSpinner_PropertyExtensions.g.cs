#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonSpinnerExtensions
{
public static T AllowSpin<T>(this T control, IBinding binding) where T : ButtonSpinner
   => control._set(ButtonSpinner.AllowSpinProperty, binding);
public static T AllowSpin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ButtonSpinner
   => control._set(ButtonSpinner.AllowSpinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AllowSpin<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ButtonSpinner
   => control._set(ButtonSpinner.AllowSpinProperty, func, onChanged, expression);
public static T AllowSpin<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ButtonSpinner
=> control._setEx(ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);
public static T AllowSpin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ButtonSpinner
=> control._setEx(ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowButtonSpinner<T>(this T control, IBinding binding) where T : ButtonSpinner
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, binding);
public static T ShowButtonSpinner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ButtonSpinner
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowButtonSpinner<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ButtonSpinner
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, func, onChanged, expression);
public static T ShowButtonSpinner<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ButtonSpinner
=> control._setEx(ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);
public static T ShowButtonSpinner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ButtonSpinner
=> control._setEx(ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ButtonSpinnerLocation<T>(this T control, IBinding binding) where T : ButtonSpinner
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, binding);
public static T ButtonSpinnerLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ButtonSpinner
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ButtonSpinnerLocation<T>(this T control, Func<Location> func, Action<Location>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ButtonSpinner
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, func, onChanged, expression);
public static T ButtonSpinnerLocation<T>(this T control, Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ButtonSpinner
=> control._setEx(ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);
public static T ButtonSpinnerLocation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ButtonSpinner
=> control._setEx(ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

