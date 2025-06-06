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
public static partial class TreeViewItem_MarkupExtensions
{
//================= Properties ======================//
 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> control._set(() => control.IsExpanded = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsExpanded<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TreeViewItem 
=> control._setEx(Avalonia.Controls.TreeViewItem.IsExpandedProperty, ps, () => control.IsExpanded = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsExpanded<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsExpanded<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TreeViewItem 
=> control._setEx(Avalonia.Controls.TreeViewItem.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> control._set(() => control.IsSelected = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsSelected<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TreeViewItem 
=> control._setEx(Avalonia.Controls.TreeViewItem.IsSelectedProperty, ps, () => control.IsSelected = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSelected<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSelected<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(Avalonia.Controls.TreeViewItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsSelected<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TreeViewItem 
=> control._setEx(Avalonia.Controls.TreeViewItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Expanded

/*ActionToEventGenerator*/
public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.ExpandedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.ExpandedEvent.RoutingStrategies);
  return control;
}



 // Collapsed

/*ActionToEventGenerator*/
public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.CollapsedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.CollapsedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty, binding);


 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty, binding);



}
