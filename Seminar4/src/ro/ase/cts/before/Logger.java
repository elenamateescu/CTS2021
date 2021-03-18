package ro.ase.cts.before;
import java.io.BufferedWriter;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.util.Date;

public class Logger {
	private String fileName;
	
	public Logger() {
		this.fileName="log.txt";
		
	}
	
	public Logger(String fileName) {
		this();
		if(fileName != null) {
			this.fileName =fileName;
			
		}
	}
	public void log(String message){
        try {
            FileOutputStream fileOutputStream = new FileOutputStream(this.fileName, true);
            Thread.sleep(3000);
            OutputStreamWriter outputStreamWriter = new OutputStreamWriter(fileOutputStream);
            BufferedWriter bufferedWritter = new BufferedWriter(outputStreamWriter);
            //bufferedWritter.write(String.valueOf(new Date()));
            bufferedWritter.write(String.valueOf(new Date()) + " ");
            bufferedWritter.write(" ");
            bufferedWritter.write(message);
            bufferedWritter.write(System.lineSeparator());
            bufferedWritter.close();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

}

