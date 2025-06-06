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
public static partial class GlyphRunDrawing_MarkupExtensions
{
//================= Properties ======================//
 // Foreground

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.IBrush value)  
=> control._set(() => control.Foreground = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, IBinding binding)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.GlyphRunDrawing Foreground<TValue>(this Avalonia.Media.GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // GlyphRun

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.GlyphRun value)  
=> control._set(() => control.GlyphRun = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.GlyphRun> func, Action<Avalonia.Media.GlyphRun>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control,Avalonia.Media.GlyphRun value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, IBinding binding)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.GlyphRunDrawing GlyphRun<TValue>(this Avalonia.Media.GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Media.GlyphRun> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
