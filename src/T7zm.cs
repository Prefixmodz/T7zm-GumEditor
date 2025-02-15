using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using soulsAPI;

namespace T7zm_GumEditor
{
    public partial class T7zm : CBH_WinForm_Theme_Library_NET.CrEaTiiOn_Form
    {
        public uint GumPackName = 0x37DF0DD7;
        public uint Slot_0 = 0x11;
        public uint Slot_1 = 0x12;
        public uint Slot_2 = 0x13;
        public uint Slot_3 = 0x14;
        public uint Slot_4 = 0x15;

        public Byte
            // Classic
            Always_Done_Swiftly = 0xCA,
            Arms_Grace = 0xCD,
            Coagulant = 0xCF,
            In_Plain_Sight = 0xD3,
            Stock_Option = 0xD6,
            Impatient = 0xD2,
            Sword_Flay = 0xD7,
            Anywhere_But_Here = 0xCB,
            Danger_Closest = 0xD0,
            Armamental_Accomplishment = 0xCC,
            Firing_On_All_Cylinders = 0xD1,
            Arsenal_Accelerator = 0xCE,
            Lucky_Crit = 0xD4,
            Now_You_See_Me = 0xD5,
            Alchemical_Antithesis = 0xC9,

            // Mega
            Aftertaste = 0xD8,
            Burned_Out = 0xD9,
            Crawl_Space_DLC = 0xEA,
            Dead_Of_Nuclear_Winter = 0xDB,
            Ephemeral_Enhancement = 0xDC,
            Fatal_Contraption_DLC = 0xEB,
            Im_Feelin_Lucky = 0xDD,
            Immolation_Liquidation = 0xDE,
            Licensed_Contractor = 0xE1,
            Phoenix_Up = 0xE4,
            Pop_Shocks = 0xE5,
            Respin_Cycle = 0xE6,
            Unquenchable = 0xE7,
            Whos_Keeping_Score = 0xE9,
            Cache_Back = 0xDA,
            Kill_Joy = 0xDF,
            On_The_House = 0xE2,
            Undead_Man_Walking_DLC = 0xED,
            Wall_Power = 0xE8,
            Head_Drama_DLC = 0xEC,
            Killing_Time = 0xE0,
            Perkaholic = 0xE3;

        public T7zm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            if (!api.Connections.isConnected)
                return;
            else
                api.Connections.disconnect();
        }

        private void crEaTiiOn_Ultimate_FancyButton1_Click(object sender, EventArgs e)
        {
            api.Connections.showConnectionWindow();
        }

        private void crEaTiiOn_Ultimate_FancyButton2_Click(object sender, EventArgs e)
        {
            if (!api.Connections.isConnected)
            {
                api.Misc.windowsNotify("Error", "Not Connected!");
            }
            else
            {
                api.Extension.WriteHexString(0x37DF0EE3, "42795072656669784D6F647A");
                ComboBoxGumPack.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    string GumPackNames = api.Extension.ReadString(GumPackName + (uint)(i * 0x16));

                    ComboBoxGumPack.Items.Add(GumPackNames);
                }
                ComboBoxGumPack.SelectedIndex = 0;
            }
        }

        private uint GetCurrentGobbleGumPack()
        {
            switch (ComboBoxGumPack.SelectedIndex)
            {
                case 0:
                    return GumPackName;
                    break;
                case 1:
                    return GumPackName + (1 * 0x16);
                    break;
                case 2:
                    return GumPackName + (2 * 0x16);
                    break;
                case 3:
                    return GumPackName + (3 * 0x16);
                    break;
                case 4:
                    return GumPackName + (4 * 0x16);
                    break;
                case 5:
                    return GumPackName + (5 * 0x16);
                    break;
                case 6:
                    return GumPackName + (6 * 0x16);
                    break;
                case 7:
                    return GumPackName + (7 * 0x16);
                    break;
                case 8:
                    return GumPackName + (8 * 0x16);
                    break;
                case 9:
                    return GumPackName + (9 * 0x16);
                    break;
                default:
                    return GumPackName;
                    break;
            }
        }

        private void ComboBoxGumSlot_1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!api.Connections.isConnected)
            {
                api.Misc.windowsNotify("Error", "Not Connected!");
            }
            else
            {
                switch (ComboBoxGumSlot_1.SelectedIndex)
                {
                    case 0:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Always_Done_Swiftly);
                        break;
                    case 1:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Arms_Grace);
                        break;
                    case 2:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Coagulant);
                        break;
                    case 3:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, In_Plain_Sight);
                        break;
                    case 4:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Stock_Option);
                        break;
                    case 5:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Impatient);
                        break;
                    case 6:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Sword_Flay);
                        break;
                    case 7:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Anywhere_But_Here);
                        break;
                    case 8:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Danger_Closest);
                        break;
                    case 9:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Armamental_Accomplishment);
                        break;
                    case 10:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Firing_On_All_Cylinders);
                        break;
                    case 11:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Arsenal_Accelerator);
                        break;
                    case 12:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Lucky_Crit);
                        break;
                    case 13:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Now_You_See_Me);
                        break;
                    case 14:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Alchemical_Antithesis);
                        break;
                    case 15:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Aftertaste);
                        break;
                    case 16:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Burned_Out);
                        break;
                    case 17:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Crawl_Space_DLC);
                        break;
                    case 18:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Dead_Of_Nuclear_Winter);
                        break;
                    case 19:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Ephemeral_Enhancement);
                        break;
                    case 20:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Fatal_Contraption_DLC);
                        break;
                    case 21:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Im_Feelin_Lucky);
                        break;
                    case 22:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Immolation_Liquidation);
                        break;
                    case 23:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Licensed_Contractor);
                        break;
                    case 24:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Phoenix_Up);
                        break;
                    case 25:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Pop_Shocks);
                        break;
                    case 26:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Respin_Cycle);
                        break;
                    case 27:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Unquenchable);
                        break;
                    case 28:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Whos_Keeping_Score);
                        break;
                    case 29:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Cache_Back);
                        break;
                    case 30:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Kill_Joy);
                        break;
                    case 31:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, On_The_House);
                        break;
                    case 32:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Undead_Man_Walking_DLC);
                        break;
                    case 33:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Wall_Power);
                        break;
                    case 34:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Head_Drama_DLC);
                        break;
                    case 35:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Killing_Time);
                        break;
                    case 36:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_0, Perkaholic);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ComboBoxGumSlot_2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!api.Connections.isConnected)
            {
                api.Misc.windowsNotify("Error", "Not Connected!");
            }
            else
            {
                switch (ComboBoxGumSlot_2.SelectedIndex)
                {
                    case 0:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Always_Done_Swiftly);
                        break;
                    case 1:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Arms_Grace);
                        break;
                    case 2:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Coagulant);
                        break;
                    case 3:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, In_Plain_Sight);
                        break;
                    case 4:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Stock_Option);
                        break;
                    case 5:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Impatient);
                        break;
                    case 6:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Sword_Flay);
                        break;
                    case 7:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Anywhere_But_Here);
                        break;
                    case 8:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Danger_Closest);
                        break;
                    case 9:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Armamental_Accomplishment);
                        break;
                    case 10:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Firing_On_All_Cylinders);
                        break;
                    case 11:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Arsenal_Accelerator);
                        break;
                    case 12:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Lucky_Crit);
                        break;
                    case 13:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Now_You_See_Me);
                        break;
                    case 14:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Alchemical_Antithesis);
                        break;
                    case 15:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Aftertaste);
                        break;
                    case 16:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Burned_Out);
                        break;
                    case 17:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Crawl_Space_DLC);
                        break;
                    case 18:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Dead_Of_Nuclear_Winter);
                        break;
                    case 19:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Ephemeral_Enhancement);
                        break;
                    case 20:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Fatal_Contraption_DLC);
                        break;
                    case 21:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Im_Feelin_Lucky);
                        break;
                    case 22:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Immolation_Liquidation);
                        break;
                    case 23:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Licensed_Contractor);
                        break;
                    case 24:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Phoenix_Up);
                        break;
                    case 25:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Pop_Shocks);
                        break;
                    case 26:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Respin_Cycle);
                        break;
                    case 27:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Unquenchable);
                        break;
                    case 28:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Whos_Keeping_Score);
                        break;
                    case 29:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Cache_Back);
                        break;
                    case 30:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Kill_Joy);
                        break;
                    case 31:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, On_The_House);
                        break;
                    case 32:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Undead_Man_Walking_DLC);
                        break;
                    case 33:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Wall_Power);
                        break;
                    case 34:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Head_Drama_DLC);
                        break;
                    case 35:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Killing_Time);
                        break;
                    case 36:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_1, Perkaholic);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ComboBoxGumSlot_3_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!api.Connections.isConnected)
            {
                api.Misc.windowsNotify("Error", "Not Connected!");
            }
            else
            {
                switch (ComboBoxGumSlot_3.SelectedIndex)
                {
                    case 0:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Always_Done_Swiftly);
                        break;
                    case 1:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Arms_Grace);
                        break;
                    case 2:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Coagulant);
                        break;
                    case 3:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, In_Plain_Sight);
                        break;
                    case 4:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Stock_Option);
                        break;
                    case 5:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Impatient);
                        break;
                    case 6:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Sword_Flay);
                        break;
                    case 7:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Anywhere_But_Here);
                        break;
                    case 8:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Danger_Closest);
                        break;
                    case 9:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Armamental_Accomplishment);
                        break;
                    case 10:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Firing_On_All_Cylinders);
                        break;
                    case 11:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Arsenal_Accelerator);
                        break;
                    case 12:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Lucky_Crit);
                        break;
                    case 13:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Now_You_See_Me);
                        break;
                    case 14:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Alchemical_Antithesis);
                        break;
                    case 15:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Aftertaste);
                        break;
                    case 16:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Burned_Out);
                        break;
                    case 17:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Crawl_Space_DLC);
                        break;
                    case 18:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Dead_Of_Nuclear_Winter);
                        break;
                    case 19:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Ephemeral_Enhancement);
                        break;
                    case 20:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Fatal_Contraption_DLC);
                        break;
                    case 21:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Im_Feelin_Lucky);
                        break;
                    case 22:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Immolation_Liquidation);
                        break;
                    case 23:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Licensed_Contractor);
                        break;
                    case 24:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Phoenix_Up);
                        break;
                    case 25:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Pop_Shocks);
                        break;
                    case 26:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Respin_Cycle);
                        break;
                    case 27:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Unquenchable);
                        break;
                    case 28:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Whos_Keeping_Score);
                        break;
                    case 29:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Cache_Back);
                        break;
                    case 30:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Kill_Joy);
                        break;
                    case 31:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, On_The_House);
                        break;
                    case 32:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Undead_Man_Walking_DLC);
                        break;
                    case 33:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Wall_Power);
                        break;
                    case 34:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Head_Drama_DLC);
                        break;
                    case 35:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Killing_Time);
                        break;
                    case 36:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_2, Perkaholic);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ComboBoxGumSlot_4_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!api.Connections.isConnected)
            {
                api.Misc.windowsNotify("Error", "Not Connected!");
            }
            else
            {
                switch (ComboBoxGumSlot_4.SelectedIndex)
                {
                    case 0:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Always_Done_Swiftly);
                        break;
                    case 1:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Arms_Grace);
                        break;
                    case 2:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Coagulant);
                        break;
                    case 3:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, In_Plain_Sight);
                        break;
                    case 4:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Stock_Option);
                        break;
                    case 5:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Impatient);
                        break;
                    case 6:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Sword_Flay);
                        break;
                    case 7:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Anywhere_But_Here);
                        break;
                    case 8:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Danger_Closest);
                        break;
                    case 9:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Armamental_Accomplishment);
                        break;
                    case 10:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Firing_On_All_Cylinders);
                        break;
                    case 11:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Arsenal_Accelerator);
                        break;
                    case 12:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Lucky_Crit);
                        break;
                    case 13:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Now_You_See_Me);
                        break;
                    case 14:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Alchemical_Antithesis);
                        break;
                    case 15:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Aftertaste);
                        break;
                    case 16:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Burned_Out);
                        break;
                    case 17:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Crawl_Space_DLC);
                        break;
                    case 18:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Dead_Of_Nuclear_Winter);
                        break;
                    case 19:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Ephemeral_Enhancement);
                        break;
                    case 20:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Fatal_Contraption_DLC);
                        break;
                    case 21:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Im_Feelin_Lucky);
                        break;
                    case 22:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Immolation_Liquidation);
                        break;
                    case 23:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Licensed_Contractor);
                        break;
                    case 24:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Phoenix_Up);
                        break;
                    case 25:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Pop_Shocks);
                        break;
                    case 26:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Respin_Cycle);
                        break;
                    case 27:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Unquenchable);
                        break;
                    case 28:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Whos_Keeping_Score);
                        break;
                    case 29:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Cache_Back);
                        break;
                    case 30:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Kill_Joy);
                        break;
                    case 31:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, On_The_House);
                        break;
                    case 32:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Undead_Man_Walking_DLC);
                        break;
                    case 33:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Wall_Power);
                        break;
                    case 34:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Head_Drama_DLC);
                        break;
                    case 35:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Killing_Time);
                        break;
                    case 36:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_3, Perkaholic);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ComboBoxGumSlot_5_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!api.Connections.isConnected)
            {
                api.Misc.windowsNotify("Error", "Not Connected!");
            }
            else
            {
                switch (ComboBoxGumSlot_5.SelectedIndex)
                {
                    case 0:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Always_Done_Swiftly);
                        break;
                    case 1:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Arms_Grace);
                        break;
                    case 2:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Coagulant);
                        break;
                    case 3:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, In_Plain_Sight);
                        break;
                    case 4:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Stock_Option);
                        break;
                    case 5:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Impatient);
                        break;
                    case 6:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Sword_Flay);
                        break;
                    case 7:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Anywhere_But_Here);
                        break;
                    case 8:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Danger_Closest);
                        break;
                    case 9:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Armamental_Accomplishment);
                        break;
                    case 10:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Firing_On_All_Cylinders);
                        break;
                    case 11:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Arsenal_Accelerator);
                        break;
                    case 12:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Lucky_Crit);
                        break;
                    case 13:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Now_You_See_Me);
                        break;
                    case 14:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Alchemical_Antithesis);
                        break;
                    case 15:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Aftertaste);
                        break;
                    case 16:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Burned_Out);
                        break;
                    case 17:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Crawl_Space_DLC);
                        break;
                    case 18:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Dead_Of_Nuclear_Winter);
                        break;
                    case 19:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Ephemeral_Enhancement);
                        break;
                    case 20:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Fatal_Contraption_DLC);
                        break;
                    case 21:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Im_Feelin_Lucky);
                        break;
                    case 22:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Immolation_Liquidation);
                        break;
                    case 23:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Licensed_Contractor);
                        break;
                    case 24:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Phoenix_Up);
                        break;
                    case 25:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Pop_Shocks);
                        break;
                    case 26:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Respin_Cycle);
                        break;
                    case 27:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Unquenchable);
                        break;
                    case 28:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Whos_Keeping_Score);
                        break;
                    case 29:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Cache_Back);
                        break;
                    case 30:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Kill_Joy);
                        break;
                    case 31:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, On_The_House);
                        break;
                    case 32:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Undead_Man_Walking_DLC);
                        break;
                    case 33:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Wall_Power);
                        break;
                    case 34:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Head_Drama_DLC);
                        break;
                    case 35:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Killing_Time);
                        break;
                    case 36:
                        api.Extension.WriteByte(GetCurrentGobbleGumPack() + Slot_4, Perkaholic);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}