using System;


namespace PhoneUml
{

    //Phone class
public class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public void Connect()
        {
            Console.WriteLine("Connected.");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected.");
        }
    }

    //Phone interface
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    // Tardis from Rotary Phone
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }

        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }

        public void TimeTravel()
        {
           //Empty
        }
        //Overloading boolean operator for Tardis 
        public static bool operator ==(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
            {
                return true;
            }
            else if (tardis1.whichDrWho != 10 && tardis2.whichDrWho == 10)
            {
                return false;
            }
            else
            {
                return tardis1.whichDrWho < tardis2.whichDrWho;
            }
        }

        public static bool operator !=(Tardis tardis1, Tardis tardis2)
        {
            return !(tardis1 == tardis2);
        }

        public static bool operator <(Tardis tardis1, Tardis tardis2)
        {
            return tardis1.whichDrWho < tardis2.whichDrWho;
        }

        public static bool operator >(Tardis tardis1, Tardis tardis2)
        {
            return tardis1.whichDrWho > tardis2.whichDrWho;
        }

        public static bool operator <=(Tardis tardis1, Tardis tardis2)
        {
            return tardis1.whichDrWho <= tardis2.whichDrWho;
        }

        public static bool operator >=(Tardis tardis1, Tardis tardis2)
        {
            return tardis1.whichDrWho >= tardis2.whichDrWho;
        }
    
}

    // Rotary from Phone and PhoneInterface
    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {
            Console.WriteLine("Answering.");
        }

        public void MakeCall()
        {
            Console.WriteLine("Calling.");
        }

        public void HangUp()
        {
            Console.WriteLine("Hanging up.");
        }

        public object Connect()
        {
            Console.WriteLine("Connected.");
            return null;
        }

        public object Disconnect()
        {
            Console.WriteLine("Disconnected.");
            return null;
        }
    }

    // PushButtonPhone, from Phone and PhoneInterface
    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {
            Console.WriteLine("Answering.");
        }

        public void MakeCall()
        {
            Console.WriteLine("Calling.");
        }

        public void HangUp()
        {
            Console.WriteLine("Hanging up.");
        }

        public object Connect()
        {
            Console.WriteLine("Connected.");
            return null;
        }

        public object Disconnect()
        {
            Console.WriteLine("Disconnected.");
            return null;
        }
    }

    // PhoneBooth from PushButtonPhone
    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        private bool phoneBook;

        public void OpenDoor()
        {
            Console.WriteLine("door opened.");
        }

        public void CloseDoor()
        {
            Console.WriteLine("door closed.");
        }
    }
    class Program
    {
        static void UsePhone(object obj)
        {
            if (obj is PhoneInterface phone)
            {
                phone.MakeCall();
                phone.HangUp();
            }

            if (obj is PhoneBooth phoneBooth)
            {
                phoneBooth.OpenDoor();
            }

            if (obj is Tardis tardis)
            {
                tardis.TimeTravel();
            }

        }

        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            Console.WriteLine("Tardis:");
            UsePhone(tardis);

            Console.WriteLine("PhoneBooth:");
            UsePhone(phoneBooth);
        }
    }
}

