using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;


//Decrypt MSIL injector malware: 0190c4ad7e930bd060ac766c23f4bd890c85b916

namespace MSIL_Injector_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] GTM2l903H()
        {
            return new string[]
			{
				"��˿�Ȱ������ᰬ����������Ŷ�ȿ������ᶹ��˹",
				"���������ᰬ������ά������ܰ�����������",
				"������˰������߱���",
				"�ܳ߱ȶ������ȼ�����������������ƨ����",
				"������Ŷ��˿����ƨ",
				"�����±��տ�ƨ������˹",
				"����˹���������ḥ",
				"�߿���������ά������",
				"�Ȱ����ձȵϸ�����˹���������¼�����",
				"��˹��˿�������ᰬ���°������ܰ�����",
				"����ά��������ά����",
				"����������˿�����¿��ռ�������ƨ������ά��",
				"���˰���������������ά��ά����������ά",
				"��˿�Ȱ��ᰬά����������ά��",
				"����������Ŷ�Ἢ˹���ȼ���������ά��",
				"ά��������߰���",
				"�߳�άά�ܰ�����������˹�����˹�����ᰬ��ά��",
				"�����˿��ά����Ŷ˹��������ܰ�����Ȱ���",
				"�µ°��Ͽ��µϵ�ά��",
				"����ά���������������ᰬ������",
				"���ᰬ˿��˿���ϰ���ƨ�������Ȱ�������˿�˸�",
				"�����������հ�ƨ������������������"
			};
        }

        public static string wUuYyOJswkhFGuP1wUuYyOJswkhFGuP2 = "";
        public static byte[] tJHCUMgDZPB2tJHCUMgDZPB3 = new byte[122880];
        public static int tJHCUMgDZPB4tJHCUMgDZPB5 = 0;

        public int AIFPfQXpYYspV(int len)
        {
            return len - 1;
        }

        public byte IPPXqs1()
        {
            byte[] array = dGdM3xh8lPTWw((byte[])MSIL_Injector_Decrypt.Properties.Resources.ResourceManager.GetObject(Form1.wUuYyOJswkhFGuP1wUuYyOJswkhFGuP2));
            Buffer.BlockCopy(array, 0, tJHCUMgDZPB2tJHCUMgDZPB3, tJHCUMgDZPB4tJHCUMgDZPB5, AIFPfQXpYYspV(array.Length));
            Form1.tJHCUMgDZPB4tJHCUMgDZPB5 += AIFPfQXpYYspV(array.Length);
            return 32;
        }

        private byte[] dGdM3xh8lPTWw(byte[] eQXnHKMfMd4cRJEsBTLKEUCPYP4)
		{
			for (int i = 0; i < eQXnHKMfMd4cRJEsBTLKEUCPYP4.Length; i++)
			{
				eQXnHKMfMd4cRJEsBTLKEUCPYP4[i] ^= 30;
			}
			return eQXnHKMfMd4cRJEsBTLKEUCPYP4;
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] array = GTM2l903H();
            for (int i = 0; i < array.Length; i++)
            {
                string text = array[i];
                Form1.wUuYyOJswkhFGuP1wUuYyOJswkhFGuP2 = text;
                IPPXqs1();
            }

            //tJHCUMgDZPB2tJHCUMgDZPB3
            FileStream fs = new FileStream("payload.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(tJHCUMgDZPB2tJHCUMgDZPB3);
            bw.Close();
            fs.Close();
            MessageBox.Show("Decrypted file: payload.bin", "Decrypted!");
            this.Close();
        }
    }
}
