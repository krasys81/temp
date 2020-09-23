using System;
using UnityEngine;

public class ObjectFactory
{
    private static ObjectFactory instance = new ObjectFactory();

    public static ObjectFactory GetInstance()
    {
        return instance;
    }

    private ObjectFactory() {}

    public Logger GetLogger()
    {
        return new Logger(new DebugHandler());
    }
}

