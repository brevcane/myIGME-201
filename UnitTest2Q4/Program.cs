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

            public static bool operator ==(Tardis t1, Tardis t2)
            {
                return t1.whichDrWho == t2.whichDrWho;
            }

            
            public static bool operator !=(Tardis t1, Tardis t2)
            {
                return !(t1.whichDrWho == t2.whichDrWho);
            }

           
            public static bool operator <(Tardis t1, Tardis t2)
            {
                if (t1.whichDrWho == 10 && t2.whichDrWho != 10)
                {
                    return false;
                }
                else if (t2.whichDrWho == 10 && t1.whichDrWho != 10)
                {
                    return true; 
                }
                else
                {
                    return t1.whichDrWho < t2.whichDrWho; 
                }
            }

            // Overload the > operator
            public static bool operator >(Tardis t1, Tardis t2)
            {
                if (t1.whichDrWho == 10 && t2.whichDrWho != 10)
                {
                    return true;
                }
                else if (t2.whichDrWho == 10 && t1.whichDrWho != 10)
                {
                    return false;
                }
                else
                {
                    return t1.whichDrWho < t2.whichDrWho;
                }
            }

            
            public static bool operator <=(Tardis t1, Tardis t2)
            {
                return (t1 < t2) || (t1 == t2);
            }

            
            public static bool operator >=(Tardis t1, Tardis t2)
            {
                return (t1 > t2) || (t1 == t2);
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
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);
        }
        static void UsePhone(object obj)
        {
            if (obj is PhoneInterface phone)
            {
                phone.MakeCall();
                phone.HangUp();
            }
            else if (obj is Tardis tardis)
            {
                tardis.TimeTravel();
            }
        }
    }
}
