using LiteDB;
using magic.node;
using magic.node.extensions;
using magic.signals.contracts;

namespace Magic.Litedb.Slots;

[Slot(Name = "litedb.close")]
public class CloseLitedb : ISlot
{
    public void Signal(ISignaler signaler, Node input)
    {
        var db = input.Get<LiteDatabase>(0);

        db.Dispose();
    }
}