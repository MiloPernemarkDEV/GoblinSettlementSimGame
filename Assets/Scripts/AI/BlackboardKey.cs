using System;

public class BlackboardKey<T> : IBlackboardKey
{
    public T Value { get; set; }
    public Type KeyType => typeof(T);

    public BlackboardKey(T defaultValue = default)
    {
        Value = defaultValue;
    }
}