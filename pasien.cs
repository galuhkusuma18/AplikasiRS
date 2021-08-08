using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Sisteminformasirumahsakit
{
    #region Pasien
    public class Pasien
    {
        #region Member Variables
        protected unknown _no_pasien;
        protected string _nama_pasien;
        protected unknown _jenis_kelamin;
        protected string _tempat_lahir;
        protected unknown _tanggal_lahir;
        protected int _no_hp;
        protected string _alamat;
        protected string _dokter;
        protected string _poli;
        #endregion
        #region Constructors
        public Pasien() { }
        public Pasien(string nama_pasien, unknown jenis_kelamin, string tempat_lahir, unknown tanggal_lahir, int no_hp, string alamat, string dokter, string poli)
        {
            this._nama_pasien=nama_pasien;
            this._jenis_kelamin=jenis_kelamin;
            this._tempat_lahir=tempat_lahir;
            this._tanggal_lahir=tanggal_lahir;
            this._no_hp=no_hp;
            this._alamat=alamat;
            this._dokter=dokter;
            this._poli=poli;
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
        public virtual string Tempat_lahir
        {
            get {return _tempat_lahir;}
            set {_tempat_lahir=value;}
        }
        public virtual unknown Tanggal_lahir
        {
            get {return _tanggal_lahir;}
            set {_tanggal_lahir=value;}
        }
        public virtual int No_hp
        {
            get {return _no_hp;}
            set {_no_hp=value;}
        }
        public virtual string Alamat
        {
            get {return _alamat;}
            set {_alamat=value;}
        }
        public virtual string Dokter
        {
            get {return _dokter;}
            set {_dokter=value;}
        }
        public virtual string Poli
        {
            get {return _poli;}
            set {_poli=value;}
        }
        #endregion
    }
    #endregion
}