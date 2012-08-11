/*
Demoders MapUpgrades
Copyright (c) 2010-2012 Demoder <demoder@demoder.me>

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; version 2 of the License only.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307
USA
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MapUpgrades.Xml
{
    [XmlRoot("Items")]
    public class ItemList
    {
        public UInt64 VersionTag = 0;
        public List<Map> Maps;
        public List<MapUpgrade> MapUpgrades;
        /// <summary>
        /// Map entry.
        /// </summary>
        public class Map
        {
            [XmlAttribute("zone")]
            public string zone;
            [XmlAttribute("name")]
            public string name;
            [XmlAttribute("mapnav")]
            public uint mapnav;

            [XmlAttribute("MapsA")]
            public UInt32 MapsA;
            [XmlAttribute("MapsB")]
            public UInt32 MapsB;
            [XmlAttribute("MapsC")]
            public UInt32 MapsC;
            [XmlAttribute("MapsD")]
            public UInt32 MapsD;
        }

        public class MapUpgrade
        {
            [XmlAttribute("name")]
            public string name;
            [XmlAttribute("mapnav")]
            public uint mapnav;
            [XmlAttribute("listname")]
            public string listname;
            [XmlAttribute("bitflag")]
            public UInt32 bitflag;
        }
    }
}
