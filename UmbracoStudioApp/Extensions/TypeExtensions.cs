﻿using System;

namespace UmbracoStudioApp.Extensions
{
    public static class TypeExtensions
    {
        public static bool Implements<TInterface>(this Type type)
        {
            return typeof(TInterface).IsAssignableFrom(type);
        } 
    }
}