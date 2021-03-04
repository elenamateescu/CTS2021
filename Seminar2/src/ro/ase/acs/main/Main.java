package ro.ase.acs.main;

import ro.ase.acs.readers.ConsoleReader;
import ro.ase.acs.services.Orchestrator;
import ro.ase.acs.writers.ConsoleWriter;


public class Main {

	public static void main(String[] args) {
		Orchestrator orchestrator =
				new Orchestrator(new ConsoleReader(),
						new ConsoleWriter());
		orchestrator.execute();
	}
	
}
