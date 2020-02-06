using UnityEngine;
using UnityEngine.UI;

class Invoker
{
    private Command m_Command;

    public void SetCommand(Command command)
    {
        m_Command = command;
    }

    public void ExecuteCommand(Command command)
    {
        m_Command.Execute();
        Debug.Log(command);
    }
}