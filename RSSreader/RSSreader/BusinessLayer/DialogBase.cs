using System;

public class DialogBase
{
    internal virtual void EmptyInput()
    {
        MessageBox.Show("Can't leave input empty.");
    }
}


//af