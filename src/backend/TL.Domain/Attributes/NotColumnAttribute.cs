using System;
namespace TL.Domain.Attributes
{
    /// <summary>
    /// Những thuộc tính có attribute này sẽ không phải là một cột trong DB
    /// </summary>
    public class NotColumnAttribute : Attribute
    {
    }
}