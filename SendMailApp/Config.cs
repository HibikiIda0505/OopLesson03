﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp
{
    public class Config
    {
        //単一のインスタンス
        private static Config instance { get; set; }
        public string Smtp { get; set; }    //SMTPサーバー
        public string MailAddress { get; set; }     //自メールアドレス（送信元）
        public string PassWord { get; set; }    //パスワード
        public int Port { get; set; }    //ポート番号
        public bool Ssl { get; set; }     //SSL設定

        //インスタンスの取得
        public static Config GetInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }
            return instance;
        }

        //コンストラクタ(外部からnewできないようにする)
        private Config()
        { }

        //初期設定用
        public void DefaultSet()
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得用
        public Config getDefaultStatus()
        {
            Config obj = new Config
            {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true,
            };
            return obj;
        }

        //設定データ更新
        //public bool UpdateStatus(Config cf)
        public bool UpdateStatus(string smtp,string mailAddress,
                                            string passWord,int port,bool ssl)
        {
            this.Smtp = smtp;
            this.MailAddress = mailAddress;
            this.PassWord = passWord;
            this.Port = port;
            this.Ssl = ssl;

            return true;
        }

        //シリアル化  
        public void Serialise()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Config));
                StreamWriter sw = new StreamWriter("Config.xml");
                Config cf = Config.GetInstance();
                xs.Serialize(sw, cf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        //逆シリアル化 
        public void DeSerialise()  
        {
            try
            {
                using (StreamReader sr = new StreamReader("Config.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Config));
                    instance = xs.Deserialize(sr) as Config;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
