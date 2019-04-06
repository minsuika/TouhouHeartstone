﻿using System;

namespace TouhouHeartstone.Frontend
{
    public class Utilities
    {
        /// <summary>
        /// 测试并转换数据类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public static T CheckType<T>(object obj) where T : class
        {
            if (!(obj is T))
                throw new WrongArumentTypeException(typeof(T), obj.GetType());
            return obj as T;
        }
    }

    /// <summary>
    /// 参数类型错误
    /// </summary>
    [Serializable]
    public class WrongArumentTypeException : Exception
    {
        public WrongArumentTypeException() { }
        public WrongArumentTypeException(Type expected, Type actual) : base($"错误的数据类型。需要{expected}但提供了{actual}") { }
    }
}
