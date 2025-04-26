using System.Collections.Generic;

namespace DesignPatternsV1.Behavioral.Memento
{
    public class Caretaker
    {
        private List<Memento> _mementos = new List<Memento>();
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            System.Console.WriteLine("\nCaretaker: Saving Originator's state...");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos[_mementos.Count - 1];
            _mementos.RemoveAt(_mementos.Count - 1);

            System.Console.WriteLine("Caretaker: Restoring state to: " + memento.GetState());
            _originator.Restore(memento);
        }

        public void ShowHistory()
        {
            System.Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in _mementos)
            {
                System.Console.WriteLine(memento.GetState());
            }
        }
    }
} 