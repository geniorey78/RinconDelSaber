﻿using AppNotas.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace RinconDelSaber

{
    public class AppSettings
    {
        public static string ApiFirebase = "https://pdlogin-314613-default-rtdb.firebaseio.com/";
        private static string KeyAplication = "AIzaSyDXmNFEqb04F1643VJea5eE04MIt1wLrqw";


        public static ResponseAuthentication oAuthentication { get; set; }
        private static string ApiUrlGoogleApis = "https://identitytoolkit.googleapis.com/v1/";

        public static string ApiAuthentication(string tipo)
        {
            if (tipo == "LOGIN")
                return ApiUrlGoogleApis + "accounts:signInWithPassword?key=" + KeyAplication;
            else if (tipo == "SIGNIN")
                return ApiUrlGoogleApis + "accounts:signUp?key=" + KeyAplication;
            else
                return "";
        }

    }
}
