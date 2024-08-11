#nullable enable
using Avalonia.Animation;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AnimatableExtensions
{
public static T Transitions<T>(this T control, IBinding binding) where T : Animatable
   => control._set(Animatable.TransitionsProperty, binding);
public static T Transitions<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Animatable
   => control._set(Animatable.TransitionsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Transitions<T>(this T control, Func<Transitions> func, Action<Transitions>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Animatable
   => control._set(Animatable.TransitionsProperty, func, onChanged, expression);
public static T Transitions<T>(this T control, Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Animatable
=> control._setEx(Animatable.TransitionsProperty, ps, () => control.Transitions = value, bindingMode, converter, bindingSource);
public static T Transitions<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Animatable
=> control._setEx(Animatable.TransitionsProperty, ps, () => control.Transitions = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

