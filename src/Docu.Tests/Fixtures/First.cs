﻿using System;

namespace Example
{
    public class EmptyType
    { }

    public class SingleMethodType
    {
        public void Method()
        { }
    }

    public class PropertyType
    {
        public string Property { get; set; }
    }

    public class ClassWithOverload
    {
        public void Method() { }
        public void Method(string one) { }

        public string MethodWithReturn()
        {
            return "";
        }
    }

    public class ClassWithInterfaces : EmptyInterface, IDisposable
    {
        public void Dispose()
        {
            
        }
    }

    public class ClassWithBaseWithInterfaces : ClassWithInterfaces
    {}

    public class ClassWithBaseWithInterfacesAndDirect : ClassWithInterfaces, IExample
    { }

    public interface IExample
    {
    }

    public class ClassWithExplicitMethodImplementation : InterfaceForExplicitImplementation
    {
        void InterfaceForExplicitImplementation.Method()
        {

        }
    }

    public interface EmptyInterface
    { }

    public interface SingleMethodInterface
    {
        void Method();
    }

    public interface InterfaceForExplicitImplementation
    {
        void Method();
    }

    public class StaticMethodClass
    {
        public static void Method()
        {}
    }

    public class EventType
    {
        public event EventHandler<EventArgs> AnEvent;
    }

    public class FieldType
    {
        public string aField;
    }

    public class ReturnMethodClass
    {
        public string Method()
        {
            return "";
        }
    }

    /// <summary>
    /// First summary
    /// </summary>
    public class First
    {
    }

    public class FirstChild : First
    {
    }

    public class GenericDefinition<T>
    {
        public void AMethod()
        {
            
        }

        public void BMethod<C>()
        {
            
        }
    }

    public class GenericDefinition<T,C>
    {
        
    }

    namespace Deep
    {
        public class DeepFirst
        {
            
        }
    }
}
