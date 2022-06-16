    public class CameraPhone : phone {
        List<string> pictures = new List<string>();

        public void take_picture(string picture_name) {
            pictures.Add(picture_name);
        }

        public CameraPhone(long phoneNumber) : base(phoneNumber) {

        }
        
    }