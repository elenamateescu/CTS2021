package ro.ase.acs.services;

import ro.ase.acs.readers.ConsoleReader;
import ro.ase.acs.writers.ConsoleWriter;
import ro.ase.acs.writers.Writeable;
import ro.ase.acs.readers.Readable;

public class Orchestrator {

    

    private Readable reader;
    private Writeable writer;

    //Sol 1 pt Dependency Inversion: Constructor Inversion Conteiner
    public Orchestrator(Readable reader, Writeable writer){
        this.reader = reader;
        this.writer = writer;
    }

    public void execute(){
        writer.write(reader.read());
    }
}
