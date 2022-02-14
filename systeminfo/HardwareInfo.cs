using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace systeminfo
{
    class HardwareInfo
    {
        /// Retrieving HDD Serial No.
        /// 

        /// 
        public static String GetProcessorId()
        {

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Name"].Value.ToString();
                break;
            }
            return Id;

        }
        public static String GetHDDSerialNo()
        {
            string  name, dungluong;
            ManagementClass mc_hdd = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc_hdd = mc_hdd.GetInstances();
            string result = "";
            foreach (ManagementObject mo in moc_hdd)
            {

               
                name = mo.Properties["Model"].Value == null ? "-" : mo.Properties["Model"].Value.ToString();
                dungluong = mo.Properties["Size"].Value == null ? "0" : mo.Properties["Size"].Value.ToString();

            
               
                result =  name + " (" + Convert.ToInt64(dungluong)/1024/1024/1024 + "GB"  + ")";
                
            }
          
            return result;
        }
        /// Retrieving Physical Ram Memory.
        /// 

        /// 
        public static string GetPhysicalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;
            

            // In case more than one Memory sticks are installed
            foreach (ManagementObject obj in oCollection)
            {
                
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024 / 1024;
            return  MemSize.ToString() ;
        }

        public static string GetPhysicalMemoryinfor()
        {


            string result = " ";
            ManagementClass mc_ram = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc_ram = mc_ram.GetInstances();
            
            string bus;

            string name;
            int ramsl = 0;

            // In case more than one Memory sticks are installed
            foreach (ManagementObject mo in moc_ram)
            {
                ramsl = ramsl + 1;

                name = mo.Properties["Manufacturer"].Value == null ? "" : mo.Properties["Manufacturer"].Value.ToString();
                 string dungluong = mo.Properties["Capacity"].Value == null ? "0" : mo.Properties["Capacity"].Value.ToString();
                bus = mo.Properties["Speed"].Value == null ? "0" : mo.Properties["Speed"].Value.ToString();

                if(Convert.ToInt64(bus) < 2133)
                {
                    result = name + " - " + bus + " - " + "DDR3 - "  ;
                }
                else
                result =    name +" - "+ bus + " - " + "DDR4 - " ;
            }


            return result;
        }



        /// Retrieving No of Ram Slot on Motherboard.
        /// 

        /// 
        public static string GetNoRamSlots()
        {

            int MemSlots = 0;
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
            ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
            ManagementObjectCollection oCollection2 = oSearcher2.Get();
            foreach (ManagementObject obj in oCollection2)
            {
                MemSlots = Convert.ToInt32(obj["MemoryDevices"]);

            }
            return MemSlots.ToString();
        }
    }
}
