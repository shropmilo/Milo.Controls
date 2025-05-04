using System;
using System.ComponentModel;
using Milo.Core.Commands;

namespace Milo.Controls.WPF.Commands
{
    public abstract class MiloVisualCommand : DelegateCommand, IMiloVisualCommand
    {
        public virtual object Header { get; protected set; }

        protected MiloVisualCommand(Action<object> execute, Predicate<object> canExecute, object header) : base(execute, canExecute)
        {
            Header = header;
        }

        protected MiloVisualCommand(Action<object> execute, object header) : base(execute)
        {
            Header = header;
        }

        protected MiloVisualCommand(Action execute, Func<bool> canExecute, object header) : base(execute, canExecute)
        {
            Header = header;
        }

        protected MiloVisualCommand(Action execute, object header) : base(execute)
        {
            Header = header;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        

        public virtual bool IsAvailable(object parameter)
        {
            return true;
        }
    }
}