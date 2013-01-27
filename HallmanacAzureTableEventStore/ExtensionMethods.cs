﻿using System;
using System.IO;
using System.Linq.Expressions;

namespace HallmanacAzureTable.EventStore
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get the name of a property from a property access lambda. Here are two examples:
        /// <para><example>EXAMPLE-1: var myPropertyName = this.GetPropertyName(() => someObject.SomeProperty);</example></para>
        /// <para><example>EXAMPLE-2: var myPropertyName = this.GetPropertyName(() => SomeStaticClass.SomeProperty);</example></para>
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="theObject"></param>
        /// <param name="propertyLambda"></param>
        /// <returns></returns>
        public static string GetPropertyName<TProperty>(this object theObject,
                                                        Expression<Func<TProperty>> propertyLambda)
        {
            var memberExpression = propertyLambda.Body as MemberExpression;
            if(memberExpression == null)
            {
                throw new ArgumentException("You must pass a lambda in the form of: '() => Class.Property' or '() => someObject.Property'");
            }
            return memberExpression.Member.Name;
        }

        public static Stream ToStream(this string theString)
        {
            var memStream = new MemoryStream();
            var stringBytes = System.Text.Encoding.UTF8.GetBytes(theString);
            memStream.Write(stringBytes, 0, stringBytes.Length);
            return memStream;
        }

        public static string WriteToUtf8String(this MemoryStream stream)
        {
            return System.Text.Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}