using System;

public interface ICardBehavior
{
    public static void OnDraw() => throw new NotImplementedException();
    public void OnPlay() => throw new NotImplementedException();
    public void OnDiscard() => throw new NotImplementedException();
}
