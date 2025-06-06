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
public static partial class ConicGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // Center

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.Center = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(point, unit));

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control,Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.ConicGradientBrush.CenterProperty, ps, () => control.Center = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.ConicGradientBrush Center<TValue>(this Avalonia.Media.ConicGradientBrush control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.ConicGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Angle

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, System.Double value)  
=> control._set(() => control.Angle = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.ConicGradientBrush.AngleProperty, ps, () => control.Angle = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, IBinding binding)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ConicGradientBrush.AngleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.ConicGradientBrush Angle<TValue>(this Avalonia.Media.ConicGradientBrush control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.ConicGradientBrush.AngleProperty, ps, () => control.Angle = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
