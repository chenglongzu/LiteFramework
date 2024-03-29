﻿namespace LiteFramework
{
    /// <summary>
    /// 管理器脚本的基类 单例基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseManager<T> where T : new()
    {
        private static T instance;
        public static T GetInstance()
        {
            if (instance == null)
            {
                instance = new T();
            }
            
            return instance;

        }

        protected virtual void InitManager()
        {
            
        }
    }
    
    
}

