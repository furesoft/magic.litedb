using LiteDB;
using magic.node;
using magic.node.extensions;
using magic.signals.contracts;

namespace Magic.Litedb.Slots;

[Slot(Name = "litedb.open")]
public class OpenLitedb : ISlot
{
    public void Signal(ISignaler signaler, Node input)
    {
        var connecitonString = input.GetEx<string>();

        input.Value = new LiteDatabase(connecitonString);
    }
}