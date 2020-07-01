using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class DemoClass
    {
        public int CalDemo(int s, bool checkSign = true)
        {
            if (s > 10 && checkSign)
            {
                return s << 2;
            }
            else
            {
                return s;
            }
        }

        /// <summary>
        /// 获取某个类型的泛型参数
        /// </summary>
        /// <param name="type">需要检测的类型</param>
        /// <param name="genericType">检测类型所继承的泛型接口</param>
        /// <returns>泛型接口的所有参数信息</returns>
        public Type[] MyDemoMethod(Type type, Type genericType)
        {
            return type.GetInterfaces()
                        .Where(i => IsGenericType(i))
                        .SelectMany(i => i.GetGenericArguments())
                        .ToArray();

            bool IsGenericType(Type type1)
                => type1.IsGenericType && type1.GetGenericTypeDefinition() == genericType;
        }
    }
}
