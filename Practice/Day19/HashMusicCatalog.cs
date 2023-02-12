#nullable enable
using System.Collections.Generic;
using System.Linq;
using System;

namespace Day19
{
    public class HashMusicCatalog
    {
        Dictionary<string, MusicCatalog> _catalogMusic;

        public HashMusicCatalog(string[] nameDisks, MusicCatalog[] titleMusic)
        {
            if (nameDisks.Length != titleMusic.Length &&
                nameDisks.Contains(null) == false && titleMusic.Contains(null) == false)
                throw new ArgumentException("Error");

            _catalogMusic = new Dictionary<string, MusicCatalog>();
            for (int i = 0; i < nameDisks.Length; i++)
            {
                _catalogMusic.Add(nameDisks[i], titleMusic[i]);
            }
        }

        public HashMusicCatalog(Dictionary<string, MusicCatalog>? catalogMusic)
        {
            _catalogMusic = catalogMusic ?? new Dictionary<string, MusicCatalog>();
        }


        public void AddDisk(string nameDisk, MusicCatalog diskMusic)
        {
            if (!_catalogMusic.Keys.Contains(nameDisk))
            {
                _catalogMusic.Add(nameDisk, diskMusic);
            }
            else Console.WriteLine("Error");
        }

        public void RemoveDisk(string nameDisk)
        {
            if (_catalogMusic.Keys.Contains(nameDisk))
            {
                _catalogMusic.Remove(nameDisk);
            }
            else Console.WriteLine("Error");
        }


        public void AddMusic(string nameDisk, string nameMusic, string nameAuthor = "Unknown")
        {
            if (_catalogMusic.Keys.Contains(nameDisk))
            {
                Console.WriteLine("Error");
                _catalogMusic[nameDisk].Add((nameMusic, nameAuthor));
            }
            else Console.WriteLine("Error");
        }

        public void RemoveMusic(string nameDisk, string nameMusic)
        {
            if (_catalogMusic.Keys.Contains(nameDisk))
            {
                _catalogMusic[nameDisk].Remove(nameMusic);
            }
            else Console.WriteLine("Error");
        }


        public void ShowAllMusicFromCatalogMusic()
        {
            foreach (string nameDisk in _catalogMusic.Keys)
            {
                Console.WriteLine($"Disk \"{nameDisk}\": ");
                Console.WriteLine(_catalogMusic[nameDisk].ToString());
            }
        }

        public void ShowAllMusicFromDisk(string nameDisk)
        {
            if (_catalogMusic.ContainsKey(nameDisk))
            {
                Console.WriteLine(_catalogMusic[nameDisk]);
            }
        }

        public void ShowAllMusicOfAuthor(string nameAuthor)
        {
            Console.WriteLine($"From {nameAuthor}: ");
            foreach (var key in _catalogMusic.Keys)
            {
                Console.WriteLine(String.Join(", ", _catalogMusic[key].GetMusicOfAuthor(nameAuthor)));
            }
        }
    }

    public class MusicCatalog
    {
        private List<ValueTuple<string, string>> _music;

        public MusicCatalog(string[] music, string[] authors)
        {
            if (music.Length != authors.Length)
                throw new ArgumentException("Error");
            _music = new List<(string, string)>();
            for (int i = 0; i < music.Length; i++)
            {
                _music.Add((music[i], authors[i]));
            }
        }

        public MusicCatalog() => _music = new List<ValueTuple<string, string>>();

        public void Add(ValueTuple<string, string> newMusic)
        {
            if (!_music.Contains(newMusic)) _music.Add(newMusic);
        }

        public void Remove(ValueTuple<string, string> newMusic)
        {
            if (_music.Contains(newMusic)) _music.Remove(newMusic);
        }

        public void Add(string nameMusic, string nameAuthor)
        {
            if (!_music.Contains((nameMusic, nameAuthor))) _music.Add((nameMusic, nameAuthor));
        }

        public void Remove(string nameMusic, string nameAuthor)
        {
            if (_music.Contains((nameMusic, nameAuthor))) _music.Remove((nameMusic, nameAuthor));
        }

        public void Add(string nameMusic)
        {
            if (!_music.Contains((nameMusic, "Unknown")))
                _music.Add((nameMusic, "Unknown"));
        }

        public void Remove(string nameMusic)
        {
            _music.Remove(_music.FirstOrDefault(x => x.Item1 == nameMusic));
        }

        public (string, string) this[string nameMusic]
        {
            get { return _music.FirstOrDefault(x => x.Item1 == nameMusic); }
            set
            {
                for (int i = 0; i < _music.Count; i++)
                {
                    if (nameMusic == _music[i].Item1)
                    {
                        _music[i] = value;
                        break;
                    }
                }
            }
        }

        public string[] GetMusicOfAuthor(string nameAuthor)
        {
            string[] musicOfAuthor = _music.Where(x => x.Item2 == nameAuthor).Select(x => x.Item1).ToArray();
            return musicOfAuthor;
        }

        public override string ToString()
        {
            return
                $"Musics: {String.Join(", ", _music.Select(x => x.Item1).ToArray())}.\n" +
                $"Authors: {String.Join(", ", _music.Select(x => x.Item2).ToArray())}.";
        }
    }
}