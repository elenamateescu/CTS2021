package ro.ase.cts.before.classes;

import ro.ase.cts.before.Logger;

public class CommandLine {
    public CommandLine()
    {
        Logger logger=new Logger("log.txt");
        logger.log("CommandLine Created");
    }
}

