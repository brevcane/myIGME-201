using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q4
{
    internal class Program
    {

        public abstract class Phone
        {
            private string phoneNumber;
            public string address;

            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public abstract void Connect();
            public abstract void Disconnect();
        }

        public interface PhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();
        }
        public class Tardis
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
                get { return FemaleSideKick; }
            }

            public void TimeTravel()
            {

            }
        }

        public class PhoneBooth
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;

            public void OpenDoor()
            {

            }

            public void CloseDoor()
            {

            }
        }

        public class RotaryPhone : Phone, PhoneInterface
        {
            public void Answer()
            {

            }

            public void MakeCall()
            {

            }

            public void HangUp()
            {

            }

            public override void Connect()
            {
                
            }

            public override void Disconnect()
            {
               
            }
        }

        public class PushButtonPhone : Phone, PhoneInterface
        {
            public void Answer()
            {

            }

            public void MakeCall()
            {

            }

            public void HangUp()
            {

            }

            public override void Connect()
            {

            }

            public override void Disconnect()
            {

            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
