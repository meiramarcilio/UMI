using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.Status;
using System.Net;
using System.IO;
using System.Collections;

namespace umi.device.business
{
    class conetividade
    {
        #region Atributos

        private bool boolIntranetAcessivel = false;
        private bool boolInternetAcessivel = false;
        private bool boolConectadoRede = false;

        private ArrayList stateList = new ArrayList();

        private static Uri uriServidorIntranetUrl = new Uri(@"http://endpoint-intranet-umi:8080/intranet.txt");
        private static Uri uriServidorInternetUrl = new Uri(@"http://webservice.endpoint/internet.txt");

        /*private object boolWifiLigada = false;
        private object boolWifiConectado = false;
        private object boolWifiConectando = false;
        private object boolWifiRedesDisponiveis = false;*/

        #endregion

        #region Constantes

        private const string strTextoEsperadoServidorIntranet = @"intranet";
        private const string strTextoEsperadoServidorInternet = @"internet";

        #endregion

        #region Propriedades

        /// <summary>
        /// Determina se o dispositivo est� conectado � rede (Internet ou intranet).
        /// </summary>
        public bool ConectadoRede
        {
            get { return boolConectadoRede; }
        }

        /// <summary>
        /// Determina se a Internet est� acess�vel.
        /// </summary>
        public bool InternetAcessivel
        {
            get { return boolInternetAcessivel; }
        }

        /// <summary>
        /// Determina se a Intranet est� acess�vel.
        /// </summary>
        public bool IntranetAcessivel
        {
            get { return boolIntranetAcessivel; }
        }

        /// <summary>
        /// N�mero de conex�es de Rede
        /// </summary>
        public int RedeConexoesNumero
        {            
            get { return ConvertToInt32(SystemState.GetValue(SystemProperty.ConnectionsNetworkCount)); }
        }
        
        /// <summary>
        /// Descri��es das conex�es de Rede (separados por v�rgula)
        /// </summary>
        public string RedeConexoes
        {            
            get { return ConvertToString(SystemState.GetValue(SystemProperty.ConnectionsNetworkDescriptions)); }
        }

        /// <summary>
        /// Nome dos adaptadres de cada conex�o de Rede (separados por v�rgula)
        /// </summary>
        public string RedeConexoesAdaptadores
        {
            get { return ConvertToString(SystemState.GetValue(SystemProperty.ConnectionsNetworkAdapters)); }
        }

        /// <summary>
        /// Determina se o dispositivo est� conectao � rede Wifi.
        /// </summary>
        public bool WifiConectadoRede
        {            
            get { return ConvertToBoolean(SystemState.GetValue(SystemProperty.WiFiStateConnected)); }
        }

        /// <summary>
        /// Determina se o dispositivo est� conectando � rede Wifi.
        /// </summary>
        public bool WifiConectandoRede
        {
            get { return ConvertToBoolean(SystemState.GetValue(SystemProperty.WiFiStateConnecting)); }
        }

        /// <summary>
        /// Determina se o dispositivo est� com a Wifi ligada.
        /// </summary>
        public bool WifiLigada
        {
            get { return ConvertToBoolean(SystemState.GetValue(SystemProperty.WiFiStatePowerOn)); }
        }

        /// <summary>
        /// Determina se h� redes Wifi dispon�veis.
        /// </summary>        
        public bool WifiRedesDisponiveis
        {
            get { return ConvertToBoolean(SystemState.GetValue(SystemProperty.WiFiStateNetworksAvailable)); }
        }        

        /// <summary>
        /// Indica se o telefone n�o est� conectado a uma rede de celular
        /// </summary>
        public bool TelefoneSemServico
        {            
            get { return ConvertToBoolean(SystemState.GetValue(SystemProperty.PhoneNoService)); }
        }

        /// <summary>
        /// Indica o n�vel do sinal de celular (em porcentagem)
        /// </summary>
        public int TelefoneSinal
        {            
            get { return ConvertToInt32(SystemState.GetValue(SystemProperty.PhoneSignalStrength)); }
        }

        /// <summary>
        /// Determina se h� cobertura de GPRS
        /// </summary>
        public bool TelefoneGPRSCobertura
        {            
            get { return ConvertToBoolean(SystemState.GetValue(SystemProperty.PhoneGprsCoverage)); }
        }

        /// <summary>
        /// N�mero de conex�es de celular atualmente conectadas
        /// </summary>
        public int TelefoneConexoesNumero
        {            
            get { return ConvertToInt32(SystemState.GetValue(SystemProperty.ConnectionsCellularCount)); }
        }

        /// <summary>
        /// Descri��es das conex�es de celular atualmente conectadas (separadas por v�rgulas)
        /// </summary>
        public string TelefoneConexoes
        {
            get { return ConvertToString(SystemState.GetValue(SystemProperty.ConnectionsCellularDescriptions)); }
        }

        #endregion

        #region Construtor

        public conetividade()
        {            
            adicionarNotificacoes();
            determinarEstadoRede((int)SystemProperty.ConnectionsCount);
        }        

        #endregion

        #region Eventos

        void sysStateConnecCount_Changed(object sender, ChangeEventArgs args)
        {
            int intTotalConexoes = (int)args.NewValue;
            determinarEstadoRede(intTotalConexoes);
        }

        void ChangeOccurred(object sender, ChangeEventArgs args)
        {
            SystemState state = (SystemState)sender;
        }        

        #endregion

        #region M�todos

        /// <summary>
        /// Seta o programa para escutar as notifica��es 
        /// adicionadas � lista de estados (stateList)
        /// </summary>
        private void adicionarNotificacoes()
        {
            SystemState s;

            //GPRS:
            s = new SystemState(SystemProperty.PhoneGprsCoverage);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Sem servi�o:
            s = new SystemState(SystemProperty.PhoneNoService);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Telefone procurando por servi�o:
            s = new SystemState(SystemProperty.PhoneSearchingForService);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //N�mero de conex�es atualmente conetadas:
            s = new SystemState(SystemProperty.ConnectionsCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);                        
            stateList.Add(s);

            //N�mero de conex�es ativas de celular:
            s = new SystemState(SystemProperty.ConnectionsCellularCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Descri��o de cada conex�o de celular:
            s = new SystemState(SystemProperty.ConnectionsCellularDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //N�mero de conex�es de rede conectadas:
            s = new SystemState(SystemProperty.ConnectionsNetworkCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Descri��es das conex�es de rede ativas:
            s = new SystemState(SystemProperty.ConnectionsNetworkDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Lista de adapters de cada conex�o de rede:
            s = new SystemState(SystemProperty.ConnectionsNetworkAdapters);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Determina se Wifi est� conectada:
            s = new SystemState(SystemProperty.WiFiStateConnected);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Determina se Wifi est� conectando:
            s = new SystemState(SystemProperty.WiFiStateConnecting);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Determina se o Hardware de Wifi est� presente:
            s = new SystemState(SystemProperty.WiFiStateHardwarePresent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Determina se h� redes Wifi dispon�veis:
            s = new SystemState(SystemProperty.WiFiStateNetworksAvailable);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

            //Determina se o Wifi est� ligado no dispositivo:
            s = new SystemState(SystemProperty.WiFiStatePowerOn);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
        }

        /// <summary>
        /// Converte um objeto em string
        /// </summary>
        /// <param name="o">objeto</param>
        /// <returns>string de retorno</returns>
        private string ConvertToString(object o)
        {
            return (o == null) ? string.Empty : o.ToString();
        }

        /// <summary>
        /// Converte um objeto em Boolean
        /// </summary>
        /// <param name="o">objeto</param>
        /// <returns>bool</returns>
        private bool ConvertToBoolean(object o)
        {
            return (o == null) ? false : Convert.ToBoolean(o);
        }

        /// <summary>
        /// COnverte um objeto em Inteiro (Int32)
        /// </summary>
        /// <param name="o">objeto</param>
        /// <returns>int</returns>
        private int ConvertToInt32(object o)
        {
            return (o == null) ? 0 : Convert.ToInt32(o);
        }

        private void determinarEstadoRede(int intTotalConexoes) 
        {
            if (intTotalConexoes > 0)
            {
                boolConectadoRede = true;
                boolIntranetAcessivel = urlAcessivel(uriServidorIntranetUrl, strTextoEsperadoServidorIntranet);
                boolInternetAcessivel = boolIntranetAcessivel ? true :
                    urlAcessivel(uriServidorInternetUrl, strTextoEsperadoServidorInternet);
            }
            else
            {
                boolConectadoRede = false;
                boolInternetAcessivel = false;
                boolIntranetAcessivel = false;
            }
        }

        private bool urlAcessivel(Uri url, string strTextoEsperado)
        {
            HttpWebRequest httpReq = null;
            HttpWebResponse httpResp = null;
            Stream stResponseStream = null;
            StreamReader srResponseReader = null;
            try
            {
                httpReq = (HttpWebRequest)WebRequest.Create(url);
                httpReq.Method = "GET";
                httpResp = (HttpWebResponse)httpReq.GetResponse();
                stResponseStream = httpResp.GetResponseStream();
                srResponseReader = new StreamReader(stResponseStream);
                string strResponseText = srResponseReader.ReadToEnd();
                return (strTextoEsperado == null ||
                    strResponseText.IndexOf(strTextoEsperado) >= 0);
            }
            catch (Exception)
            {                
                //throw;
            }
            finally
            {
                if (srResponseReader != null) srResponseReader.Close();
                if (stResponseStream != null) stResponseStream.Close();
                if (httpResp != null) httpResp.Close();
            }
            return false;
        }

        #endregion

        #region Biblioteca de m�todos

        /*public void SetUpNotifications()
        {
            SystemState s;
            s = new SystemState(SystemProperty.ActiveApplication);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.DisplayRotation);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.KeyboardPresent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CradlePresent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CameraPresent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingSmsUnread);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingVoiceMailTotalUnread);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingVoiceMail1Unread);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingVoiceMail2Unread);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingActiveSyncEmailUnread);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingTotalEmailUnread);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingOtherEmailUnread);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingLastEmailAccountName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingSmsAccountName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MessagingActiveSyncAccountName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.TasksActive);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.TasksHighPriority);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.TasksDueToday);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.TasksOverdue);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointmentSubject);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointmentLocation);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointmentStart);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointmentEnd);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerAlbumArtist);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerTrackBitrate);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerTrackTitle);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerAlbumTitle);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerTrackArtist);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerTrackNumber);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerTrackGenre);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.MediaPlayerTrackTimeElapsed);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PowerBatteryStrength);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PowerBatteryState);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PowerBatteryBackupStrength);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PowerBatteryBackupState);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.Time);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.Date);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneSignalStrength);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneOperatorName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneTalkingCallerName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneActiveCallCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneProfileName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneProfile);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneCellBroadcast);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointmentHasConflict);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.OwnerName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.OwnerPhoneNumber);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.OwnerEmail);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.OwnerNotes);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ActiveSyncStatus);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneMissedCalls);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.HeadsetPresent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CarKitPresent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.SpeakerPhoneActive);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneMultiLine);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneSimFull);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneNoSim);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneInvalidSim);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneBlockedSim);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneRadioOff);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneRadioPresent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneRingerOff);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneLine1Selected);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneLine2Selected);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneRoaming);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneCallForwardingOnLine1);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneMissedCall);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneActiveDataCall);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneCallBarring);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneCallOnHold);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneConferenceCall);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneIncomingCall);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneCallCalling);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneGprsCoverage);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneNoService);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneSearchingForService);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneHomeService);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.Phone1xRttCoverage);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneCallTalking);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneCallForwardingOnLine2);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointment);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointmentBusyStatus);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarNextAppointmentCategories);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointment);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointmentSubject);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointmentLocation);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointmentStartTime);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointmentEndTime);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointmentHasConflict);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointmentBusyStatus);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarAppointmentCategories);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointment);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointmentSubject);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointmentLocation);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointmentStartTime);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointmentEndTime);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointmentHasConflict);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointmentBusyStatus);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarHomeScreenAppointmentCategories);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneIncomingCallerName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneLastIncomingCallerName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneIncomingCallerNumber);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneLastIncomingCallerNumber);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneIncomingCallerContactPropertyName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneLastIncomingCallerContactPropertyName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneIncomingCallerContactPropertyID);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneLastIncomingCallerContactPropertyID);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneIncomingCallerContact);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneLastIncomingCallerContact);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneTalkingCallerNumber);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneTalkingCallerContactPropertyName);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneTalkingCallerContactPropertyID);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.PhoneTalkingCallerContact);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsBluetoothCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsBluetoothDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsCellularCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsCellularDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsNetworkCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsNetworkDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsNetworkAdapters);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsDesktopCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsDesktopDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsProxyCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsProxyDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsModemCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsModemDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsUnknownCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsUnknownDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsVpnCount);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.ConnectionsVpnDescriptions);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEvent);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEventSubject);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEventLocation);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEventStartTime);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEventEndTime);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEventHasConflict);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEventBusyStatus);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);
            s = new SystemState(SystemProperty.CalendarEventCategories);
            s.Changed += new ChangeEventHandler(ChangeOccurred);
            stateList.Add(s);

        }*/

        /// <summary>
        /// Detecta conex�o sem fio
        /// </summary>
        //public void discoveryWifi()
        //{
        //    try
        //    {
        //        strConectado = string.Empty;
        //        strSinal = string.Empty;
        //        strQualidade = string.Empty;
        //        strIP = string.Empty;

        //        string hostName = System.Net.Dns.GetHostName();
        //        System.Net.IPHostEntry thisHost = System.Net.Dns.GetHostEntry(hostName);
        //        string thisIPAddr = thisHost.AddressList[0].ToString();

        //        if (thisIPAddr != "127.0.0.1")
        //        {
        //            Adapter ethernetAdapter = getEthernetAdapter();
        //            if (ethernetAdapter != null)
        //            {
        //                strConectado = ethernetAdapter.AssociatedAccessPoint;
        //                strSinal = string.Format("{0} dB", ethernetAdapter.SignalStrengthInDecibels.ToString());
        //                strQualidade = ethernetAdapter.SignalStrength.Strength.ToString();
        //                strIP = ethernetAdapter.CurrentIpAddress;
        //                //OpenNETCF.Net.AdapterCollection adapters = OpenNETCF.Net.Networking.GetAdapters();
        //                //adapters[0].IsWireless;
        //                //adapters[0].IsWirelessZeroConfigCompatible;
        //                //OpenNETCF.Net.AccessPointCollection aps = adapters[0].NearbyAccessPoints;
        //            }
        //            else
        //            {
        //                strConectado = "indispon�vel";
        //            }
        //        }
        //        else
        //        {
        //            strConectado = "desconectado";
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return;
        //    }
        //}

        /// <summary>
        /// Recupera o adapter referente a Wi-fi
        /// </summary>
        /// <returns>Adapter do tipo Ethernet</returns>
        //private Adapter getEthernetAdapter()
        //{
        //    AdapterCollection adapters = Networking.GetAdapters();
        //    foreach (Adapter adapt in adapters)
        //    {
        //        if (adapt.Type == AdapterType.Ethernet && adapt.IsWireless) return adapt;
        //    }
        //    return null;
        //}

        /// <summary>
        /// Verifica se conecta com o GPRS
        /// </summary>
        /// <returns>true => h� conectividade GPRS; false => sem conectividade</returns>
        //public bool discoveryGPRS()
        //{
        //    connMan.Timeout = 60000; //60 segundos

        //    DestinationInfoCollection DIC = connMan.EnumDestinations(); //lista os diferentes tipos de conex�es do sistema            
        //    bool connected = false;
        //    try
        //    {
        //        foreach (DestinationInfo di in DIC)
        //        {
        //            try
        //            {                        
        //                connMan.Connect(di.Guid, false, ConnectionMode.Synchronous);
        //                connected = (connMan.Status == ConnectionStatus.Connected);
        //                if (connected) {
        //                    strDestinoConexao = di.Description;
        //                    connMan.RequestDisconnect();
        //                    break; 
        //                }
        //            }
        //            catch (Exception) { /*faz nada*/ }
        //        }
        //    }
        //    catch (Exception)
        //    { throw; }

        //    return connected;
        //}

        #endregion
    }
}