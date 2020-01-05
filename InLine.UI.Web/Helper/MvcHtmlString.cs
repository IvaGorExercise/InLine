using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;
using System.Reflection;

namespace InLine.UI.Web.Helper
{
    public class MvcHtmlString
    {
        //    public static MvcHtmlString MyEditFor<TModel>(this HtmlHelper<TModel> html, Expression<Func<TModel, object>> expression)
        //    {
        //        var partial = html.Partial("Item", new LabelEditorValidation() { Label = html.LabelFor(expression), Editor = html.EditorFor(expression), Validation = html.ValidationMessageFor(expression) }).ToString();
        //        return MvcHtmlString.Create(partial);
        //    }

        //    public static MvcHtmlString MyEditFor<TModel, TProperty>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty>> expression)
        //    {
        //        var partial = html.Partial(
        //            "Item",
        //            new LabelEditorValidation
        //            {
        //                Label = html.LabelFor(expression),
        //                Editor = html.EditorFor(expression),
        //                Validation = html.ValidationMessageFor(expression)
        //            }
        //        ).ToString();
        //        return MvcHtmlString.Create(partial);
        //    }
        //}

        //public class LabelEditorValidation
        //{
        //    public MvcHtmlString Validation { get; set; }
        //    public MvcHtmlString Label { get; set; }
        //    public MvcHtmlString Editor { get; set; }
        //}
    }

    //public abstract class BaseModel
    //{
    //    protected IEnumerable<PropertyInfo> PropertyInfoCache { get; set; }
    //    protected IEnumerable<EnumeratedProperty> EnumeratedPropertyCache { get; set; }
    //    protected BaseModel()
    //    {
    //        PropertyInfoCache = this.GetType().GetProperties();
    //        EnumeratedPropertyCache = PropertyInfoCache.Select(p => new EnumeratedProperty(p.Name, p.GetType()));
    //    }
    //    public IEnumerable<EnumeratedProperty> EnumerateProperties()
    //    {
    //        return EnumeratedPropertyCache;
    //    }
    //    public object GetPropertyValue(string PropertyName)
    //    {
    //        var property = PropertyInfoCache.SingleOrDefault(i => i.Name == PropertyName);
    //        if (property != null)
    //            return property.GetValue(this, null);
    //        return null;
    //    }
    //}

    //public class EnumeratedProperty
    //{
    //    public string Name { get; private set; }
    //    public Type Type { get; private set; }
    //    public EnumeratedProperty(string PropertyName, Type PropertyType)
    //    {
    //        this.Name = PropertyName;
    //        this.Type = PropertyType;
    //    }
    //}

    //public static class ExtensionMethods
    //{
    //    public static MvcHtmlString EditorForProperty(this HtmlHelper html, BaseModel Model, EnumeratedProperty property)
    //    {
    //        // creates an error: The type arguments for method 'EditorFor' cannot be inferred from the usage. Try specifying the type arguments explicitly.
    //        return System.Web.Mvc.Html.EditorExtensions.EditorFor(html, Model => Model.GetPropertyValue(property.Name));
    //    }
    //}
}