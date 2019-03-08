using NewXmlWork.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NewXmlWork.Model;
using NewXmlWork.Logic;
using System.Globalization;
using System.Diagnostics;

namespace NewXmlWork.Logic
{
    public class BetRadarDatLogic
    {
        static Stopwatch watch = new Stopwatch();
        static DapperHelper dapperLogic = new DapperHelper();
        string FilePath { get; set; }
        string FilePathToMove { get; set; }
        public BetRadarDatLogic(string filepath, string filePathToMove)
        {
            FilePath = filepath;
            FilePathToMove = filePathToMove;
        }

        public void ReadBetRadarDataFromXml()
        {
            FileSearchHelper fileHelper = new FileSearchHelper(FilePath);
            var files = fileHelper.AllFilesFromFolder();

            if (files.Length != 0)
            {
                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file);
                    Console.WriteLine("Reading file....: " + file);
                    if (file != null)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(BetradarBetData));
                        using (FileStream fileStream = new FileStream(file, FileMode.Open))
                        {
                            BetradarBetData betData = (BetradarBetData)serializer.Deserialize(fileStream);
                            //var sports = betData.Sports.Sport;

                            if (betData.Sports.Sport != null)
                            {
                                foreach (var s in betData.Sports.Sport)
                                {
                                    Model.Sport sportToAdd = new Model.Sport();
                                    sportToAdd.SportID = Convert.ToInt32(s.BetradarSportID);
                                    foreach (var sTexts in s.Texts.Text)
                                    {
                                        if (sTexts.Language.ToLower() == "bet")
                                        {
                                            sportToAdd.SportName = sTexts.Value;
                                        }
                                    }
                                    dapperLogic.AddSport(sportToAdd);

                                    if (s.Category != null)
                                    {
                                        //watch.Start();
                                        foreach (var c in s.Category)
                                        {
                                            Model.Category categoryToAdd = new Model.Category();
                                            categoryToAdd.CategoryID = Convert.ToInt32(c.BetradarCategoryID);
                                            if (c.Texts.Text != null)
                                            {
                                                foreach (var ct in c.Texts.Text)
                                                {
                                                    if (ct.Language.ToLower() == "bet")
                                                    {
                                                        categoryToAdd.CategoryName = ct.Value;
                                                    }
                                                    dapperLogic.AddCategory(categoryToAdd);

                                                    if (c.Tournament != null)
                                                    {
                                                        Model.Tournament tournamentToAdd = new Model.Tournament();
                                                        tournamentToAdd.TournamentID = Convert.ToInt32(c.Tournament.BetradarTournamentID);
                                                        tournamentToAdd.SportID = sportToAdd.SportID;
                                                        tournamentToAdd.CategoryID = categoryToAdd.CategoryID;
                                                        if (c.Tournament.Texts.Text != null)
                                                        {
                                                            foreach (var tourn in c.Tournament.Texts.Text)
                                                            {
                                                                if (tourn.Language.ToLower() == "bet")
                                                                {
                                                                    tournamentToAdd.TournamentName = tourn.Value;
                                                                }
                                                                dapperLogic.AddTournament(tournamentToAdd);
                                                            }

                                                            if (c.Tournament.Match != null)
                                                            {
                                                                foreach (var tmatch in c.Tournament.Match)
                                                                {
                                                                    Model.Event matchEventToAdd = new Model.Event();
                                                                    matchEventToAdd.EventID = Convert.ToInt32(tmatch.BetradarMatchID);
                                                                    matchEventToAdd.SportID = sportToAdd.SportID;
                                                                    matchEventToAdd.TournamentID = tournamentToAdd.TournamentID;

                                                                    if (tmatch.Fixture.DateInfo != null)
                                                                    {
                                                                        matchEventToAdd.EventDate = tmatch.Fixture.DateInfo.MatchDate;
                                                                    }
                                                                    if (tmatch.Fixture.StatusInfo != null)
                                                                    {
                                                                        matchEventToAdd.EventStatusInfo = Convert.ToInt32(tmatch.Fixture.StatusInfo.Off);
                                                                    }
                                                                    if (tmatch.Fixture.NeutralGround != null)
                                                                    {
                                                                        matchEventToAdd.NeutralGround = Convert.ToInt32(tmatch.Fixture.NeutralGround);
                                                                    }
                                                                    if (tmatch.Fixture.RoundInfo != null)
                                                                    {
                                                                        if (tmatch.Fixture.RoundInfo.Round != null)
                                                                        {
                                                                            matchEventToAdd.RoundInfo = Convert.ToInt32(tmatch.Fixture.RoundInfo.Round);
                                                                        }
                                                                    }

                                                                    dapperLogic.AddEvent(matchEventToAdd);

                                                                    if (tmatch.Fixture != null)
                                                                    {
                                                                        if (tmatch.Fixture.Competitors != null)
                                                                        {
                                                                            if (tmatch.Fixture.Competitors.Texts != null)
                                                                            {

                                                                                foreach (var comp in tmatch.Fixture.Competitors.Texts)
                                                                                {
                                                                                    foreach (var cT in comp.Text)
                                                                                    {
                                                                                        foreach (var ctttt in cT.TextProperty)
                                                                                        {
                                                                                            if (ctttt.Language.ToLower() == "bet")
                                                                                            {
                                                                                                Model.Competitor competitorToAdd = new Model.Competitor();
                                                                                                competitorToAdd.CompetitorName = ctttt.Value;
                                                                                                competitorToAdd.EventID = matchEventToAdd.EventID;
                                                                                                dapperLogic.AddCompetitor(competitorToAdd);
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }

                                                                    if (tmatch.MatchOdds != null)
                                                                    {
                                                                        if (tmatch.MatchOdds.Bet != null)
                                                                        {
                                                                            foreach (var mo in tmatch.MatchOdds.Bet)
                                                                            {
                                                                                Model.BetType betType = new Model.BetType();
                                                                                betType.BetTypeValue = Convert.ToInt32(mo.OddsType);
                                                                                betType.EventID = matchEventToAdd.EventID;
                                                                                dapperLogic.AddBetType(betType);
                                                                                if (mo.Odds != null)
                                                                                {
                                                                                    foreach (var odds in mo.Odds)
                                                                                    {
                                                                                        decimal d = 0;
                                                                                        Model.Markets marketsToAdd = new Model.Markets();
                                                                                        marketsToAdd.MarketOutcome = Convert.ToString(odds.OutCome);
                                                                                        Decimal.TryParse(odds.Text, out d);
                                                                                        if (d != 0)
                                                                                        {
                                                                                            marketsToAdd.MarketOdds = d;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            Decimal.TryParse(odds.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out d);
                                                                                            marketsToAdd.MarketOdds = d;
                                                                                        }
                                                                                        marketsToAdd.BetType = betType.BetTypeValue;
                                                                                        dapperLogic.AddMarket(marketsToAdd);
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        //watch.Stop();
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine("File has been Read");
                    //File.Move(file, FilePathToMove + fileName);
                }
                Console.WriteLine("Successfully Read All BetRadarBetData XML Files");
                Console.WriteLine("Amount of time (): " + watch.ElapsedMilliseconds);
            }
            else
            {
                Console.WriteLine("No Files to read");
            }
        }
    }
}
