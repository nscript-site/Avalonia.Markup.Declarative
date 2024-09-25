#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class SolidColorBrush_MarkupExtensions
{
//================= Properties ======================//
 // ColorProperty

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SolidColorBrush.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, IBinding binding)
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.SolidColorBrush Color<TValue>(this Avalonia.Media.SolidColorBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SolidColorBrush.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
