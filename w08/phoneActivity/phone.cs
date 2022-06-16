public class phone {
    public long phone_number = 1234567891;
    List<string> text_messages = new List<string>();

    public void place_call(long number_to_call) {
        // phone_number = number_to_call;
        Console.WriteLine($"Calling {number_to_call}");
    }
    public void place_text(int number_to_text, string message_to_send) {
    }
    public void save_text(string message_to_save) {
    }
    public void get_texts() {
        
    }
    public void get_number() {

    }

    // CameraPhone cp = new CameraPhone();


};