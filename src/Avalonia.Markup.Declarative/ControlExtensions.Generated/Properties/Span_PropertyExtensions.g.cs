#nullable enable
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpanExtensions
{
public static T Inlines<T>(this T control, IBinding binding) where T : Span
   => control._set(Span.InlinesProperty, binding);
public static T Inlines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Span
   => control._set(Span.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Inlines<T>(this T control, Func<InlineCollection> func, Action<InlineCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Span
   => control._set(Span.InlinesProperty, func, onChanged, expression);
public static T Inlines<T>(this T control, InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Span
=> control._setEx(Span.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);
public static T Inlines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Span
=> control._setEx(Span.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

