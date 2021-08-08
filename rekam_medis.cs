using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Sisteminformasirumahsakit
{
    #region Rekam_medis
    public class Rekam_medis
    {
        #region Member Variables
        protected unknown _no_pasien;
        protected string _nama_pasien;
        protected unknown _jenis_kelamin;
        protected string _status;
        protected string _poli;
        protected string _dokter;
        protected string _hasil_amnesa;
        protected string _diagnosa;
        protected string _terapi;
        #endregion
        #region Constructors
        public Rekam_medis() { }
        public Rekam_medis(unknown no_pasien, string nama_pasien, unknown jenis_kelamin, string status, string poli, string dokter, string hasil_amnesa, string diagnosa, string terapi)
        {
            this._no_pasien=no_pasien;
            this._nama_pasien=nama_pasien;
            this._jenis_kelamin=jenis_kelamin;
            this._status=status;
            this._poli=poli;
            this._dokter=dokter;
            this._hasil_amnesa=hasil_amnesa;
            this._diagnosa=diagnosa;
            this._terapi=terapi;
        }
        #endregion
        #region Public Properties
        public virtual unknown No_pasien
        {
            get {return _no_pasien;}
            set {_no_pasien=value;}
        }
        public virtual string Nama_pasien
        {
            get {return _nama_pasien;}
            set {_nama_pasien=value;}
        }
        public virtual unknown Jenis_kelamin
        {
            get {return _jenis_kelamin;}
            set {_jenis_kelamin=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        public virtual string Poli
        {
            get {return _poli;}
            set {_poli=value;}
        }
        public virtual string Dokter
        {
            get {return _dokter;}
            set {_dokter=value;}
        }
        public virtual string Hasil_amnesa
        {
            get {return _hasil_amnesa;}
            set {_hasil_amnesa=value;}
        }
        public virtual string Diagnosa
        {
            get {return _diagnosa;}
            set {_diagnosa=value;}
        }
        public virtual string Terapi
        {
            get {return _terapi;}
            set {_terapi=value;}
        }
        #endregion
    }
    #endregion
}