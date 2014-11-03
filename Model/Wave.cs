using System;
using System.Net.Sockets;

namespace Model
{
	/// <summary>
	/// id号和time由数据库负责
	/// </summary>
	public class Wave
	{
		enum Stimulator : byte
		{
			close = 1,             ///关闭
			singleStimulate = 2,   ///单刺激
			doubleStimulate = 3,   ///双刺激
		}

		public Wave ()
		{

		}

		public int id { get; private set; }
		public NetworkStream pointData { get; set; }
		public NetworkStream remarkData { get; set; }
		public string textData { get; set; }
		public bool selected { get; set; }         ///是否选中
		public float sensitive { get; set; }
		public float sampleFrequency { get; set; }
		public float timeHistory { get; set; }
		public float sampleDelay { get; set; }
		public float stimulateIntensity { get; set; }
		public float stimulateFrequency { get; set; }
		public float upFrequency { get; set; }
		public float downFrequency { get; set; }
		public Stimulator stimulatorA { get; set; }
		public Stimulator stimulatorB { get; set; }
		public float intervalA { get; set; }
		public float intervalB { get; set; }
		public flaot currentWidth { get; set; }
		public int voiceIntensity  { get; set; }    ///声音强度 dB
		public int targetIntensity { get; set; }    ///靶强度  %
		public DateTime time { get; private set; }

		public override string ToString ()
		{
			return string.Format ("[Wave: id={0}, pointData={1}, remarkData={2}, textData={3}, selected={4}, sensitive={5}, sampleFrequency={6}, timeHistory={7}, sampleDelay={8}, stimulateIntensity={9}, stimulateFrequency={10}, upFrequency={11}, downFrequency={12}, stimulatorA={13}, stimulatorB={14}, intervalA={15}, intervalB={16}, currentWidth={17}, voiceIntensity={18}, targetIntensity={19}, time={20}]", id, pointData, remarkData, textData, selected, sensitive, sampleFrequency, timeHistory, sampleDelay, stimulateIntensity, stimulateFrequency, upFrequency, downFrequency, stimulatorA, stimulatorB, intervalA, intervalB, currentWidth, voiceIntensity, targetIntensity, time);
		}
	}
}