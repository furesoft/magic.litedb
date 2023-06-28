using LiteDB;
using magic.node;
using magic.node.extensions;
using magic.signals.contracts;

namespace Magic.Litedb.Slots;

[Slot(Name = "litedb.query")]
public class QueryLitedb : ISlot
{
    public void Signal(ISignaler signaler, Node input)
    {
        signaler.Signal("eval", input);
        
        var db = input.Get<LiteDatabase>(0);
        var query = input.Children.First().Children.First().Get<string>(1);
        
        signaler.Peek<Node>("slots.result").Value = db.Execute(query);
    }
}