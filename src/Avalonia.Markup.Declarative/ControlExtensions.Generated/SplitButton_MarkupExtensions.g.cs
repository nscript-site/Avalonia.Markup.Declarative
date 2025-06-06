#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class SplitButton_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.Command = value!);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.CommandProperty, ps, () => control.Command = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.CommandProperty, ps, () => control.Command = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.CommandParameter = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Flyout

/*ValueSetterGenerator*/
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.Flyout = value!);

/*BindFromExpressionSetterGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Flyout<T>(this T control,Avalonia.Controls.Primitives.FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.FlyoutProperty, ps, () => control.Flyout = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Flyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Flyout<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.HotKey = value!);

/*BindFromExpressionSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HotKey<T>(this T control,Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.HotKeyProperty, ps, () => control.HotKey = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton 
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HotKey<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitButton 
=> control._setEx(Avalonia.Controls.SplitButton.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitButton 
{
  control.AddHandler(Avalonia.Controls.SplitButton.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitButton.ClickEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty, binding);



}
