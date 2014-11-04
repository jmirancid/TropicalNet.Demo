//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Xml.Serialization;


namespace Demo.Entities
{
    [Serializable]
    public partial class Album
    {
        #region Primitive Properties
    
        public virtual int AlbumId
        {
            get;
            set;
        }
    
        public virtual string Title
        {
            get;
            set;
        }
    
        public virtual int ArtistId
        {
            get { return _artistId; }
            set
            {
                if (_artistId != value)
                {
                    if (Artist != null && Artist.ArtistId != value)
                    {
                        Artist = null;
                    }
                    _artistId = value;
                }
            }
        }
        private int _artistId;

        #endregion
        #region Navigation Properties
    
        public virtual Artist Artist
        {
            get { return _artist; }
            set
            {
                if (!ReferenceEquals(_artist, value))
                {
                    var previousValue = _artist;
                    _artist = value;
                    FixupArtist(previousValue);
                }
            }
        }
        private Artist _artist;
    
    	//[XmlElement("Track", typeof(Collection<Track>))]
        public virtual ICollection<Track> Track
        {
            get
            {
                if (_track == null)
                {
                    var newCollection = new FixupCollection<Track>();
                    newCollection.CollectionChanged += FixupTrack;
                    _track = newCollection;
                }
                return _track;
            }
            set
            {
                if (!ReferenceEquals(_track, value))
                {
                    var previousValue = _track as FixupCollection<Track>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupTrack;
                    }
                    _track = value;
                    var newValue = value as FixupCollection<Track>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupTrack;
                    }
                }
            }
        }
    	//[XmlElement("Track", typeof(Collection<Track>))]
        private ICollection<Track> _track;

        #endregion
        #region Association Fixup
    
        private void FixupArtist(Artist previousValue)
        {
            if (previousValue != null && previousValue.Album.Contains(this))
            {
                previousValue.Album.Remove(this);
            }
    
            if (Artist != null)
            {
                if (!Artist.Album.Contains(this))
                {
                    Artist.Album.Add(this);
                }
                if (ArtistId != Artist.ArtistId)
                {
                    ArtistId = Artist.ArtistId;
                }
            }
        }
    
        private void FixupTrack(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Track item in e.NewItems)
                {
                    item.Album = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Track item in e.OldItems)
                {
                    if (ReferenceEquals(item.Album, this))
                    {
                        item.Album = null;
                    }
                }
            }
        }

        #endregion
    }
}