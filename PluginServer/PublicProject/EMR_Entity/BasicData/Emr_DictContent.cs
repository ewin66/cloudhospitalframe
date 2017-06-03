﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFWCoreLib.CoreFrame.Orm;
using EFWCoreLib.CoreFrame.Business;

namespace EMR_Entity.BasicData
{
    [Serializable]
    [Table(TableName = "Emr_DictContent", EntityType = EntityType.Table, IsGB = false)]
    public class Emr_DictContent:AbstractEntity
    {
        private int  _id;
        /// <summary>
        /// ID
        /// </summary>
        [Column(FieldName = "Id", DataKey = true, Match = "", IsInsert = false)]
        public int Id
        {
            get { return  _id; }
            set {  _id = value; }
        }

        private int  _classid;
        /// <summary>
        /// 分类ID
        /// </summary>
        [Column(FieldName = "ClassId", DataKey = false, Match = "", IsInsert = true)]
        public int ClassId
        {
            get { return  _classid; }
            set {  _classid = value; }
        }

        private string  _code;
        /// <summary>
        /// 项目代码
        /// </summary>
        [Column(FieldName = "Code", DataKey = false, Match = "", IsInsert = true)]
        public string Code
        {
            get { return  _code; }
            set {  _code = value; }
        }

        private string  _name;
        /// <summary>
        /// 项目名称
        /// </summary>
        [Column(FieldName = "Name", DataKey = false, Match = "", IsInsert = true)]
        public string Name
        {
            get { return  _name; }
            set {  _name = value; }
        }

        private string  _pym;
        /// <summary>
        /// 拼音码
        /// </summary>
        [Column(FieldName = "Pym", DataKey = false, Match = "", IsInsert = true)]
        public string Pym
        {
            get { return  _pym; }
            set {  _pym = value; }
        }

        private string  _wbm;
        /// <summary>
        /// 五笔码
        /// </summary>
        [Column(FieldName = "Wbm", DataKey = false, Match = "", IsInsert = true)]
        public string Wbm
        {
            get { return  _wbm; }
            set {  _wbm = value; }
        }

        private string  _szm;
        /// <summary>
        /// 数字码
        /// </summary>
        [Column(FieldName = "Szm", DataKey = false, Match = "", IsInsert = true)]
        public string Szm
        {
            get { return  _szm; }
            set {  _szm = value; }
        }

        private string  _memo;
        /// <summary>
        /// 备注
        /// </summary>
        [Column(FieldName = "Memo", DataKey = false, Match = "", IsInsert = true)]
        public string Memo
        {
            get { return  _memo; }
            set {  _memo = value; }
        }

        private int  _delflag;
        /// <summary>
        /// 删除标志 0否1是
        /// </summary>
        [Column(FieldName = "DelFlag", DataKey = false, Match = "", IsInsert = true)]
        public int DelFlag
        {
            get { return  _delflag; }
            set {  _delflag = value; }
        }

        private int  _sortorder;
        /// <summary>
        /// 排序
        /// </summary>
        [Column(FieldName = "SortOrder", DataKey = false, Match = "", IsInsert = true)]
        public int SortOrder
        {
            get { return  _sortorder; }
            set {  _sortorder = value; }
        }

        private int  _cityflag;
        /// <summary>
        /// 城市标识
        /// </summary>
        [Column(FieldName = "CityFlag", DataKey = false, Match = "", IsInsert = true)]
        public int CityFlag
        {
            get { return  _cityflag; }
            set {  _cityflag = value; }
        }

    }
}
