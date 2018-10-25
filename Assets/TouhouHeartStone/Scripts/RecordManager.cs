﻿using System.Linq;
using System.Collections.Generic;

using UnityEngine;
using System.Collections;

namespace TouhouHeartstone
{
    public class RecordManager : THManager, IEnumerable<Record>
    {
        public void addRecord(Record record)
        {
            if (record == null)
                return;
            _recoderList.Add(record);
            onWitness.Invoke(record.apply(game));
        }
        public Record this[int index]
        {
            get { return _recoderList[index]; }
        }
        public int count
        {
            get { return _recoderList.Count; }
        }
        public IEnumerator<Record> GetEnumerator()
        {
            return ((IEnumerable<Record>)_recoderList).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Record>)_recoderList).GetEnumerator();
        }
        [SerializeField]
        List<Record> _recoderList = new List<Record>();
        public WitnessByPlayerEvent onWitness
        {
            get { return _onWitness; }
        }
        [SerializeField]
        WitnessByPlayerEvent _onWitness = new WitnessByPlayerEvent();
    }
}