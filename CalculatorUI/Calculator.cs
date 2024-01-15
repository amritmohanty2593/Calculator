using CalculatorUI.Core.ApplicationConstant;
using CalculatorUI.Core.Core;
using CalculatorUI.Core.Interface;
using CalculatorUI.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace CalculatorUI
{
    public partial class Calculator : Form
    {
        double result = 0;
        string operation = string.Empty;
        bool enterValue = false;
        bool isNumberPressed = false;
        bool isEqualPressed = false;
        #region ReadOnly Object
        private readonly IStandardArithmaticOps _iStandardArithmaticCalc;
        private readonly ICommonArithmaticOps _iCommonArithmaticCalc;
        private readonly ILogger _logger;
        public readonly ICoreLogic _iCoreLogic;
        #endregion
        public Calculator(IStandardArithmaticOps iStandardArithmaticCalc, ICommonArithmaticOps iCommonArithmaticCalc, ILogger<Calculator> iLogger, ICoreLogic iCoreLogic)
        {
            _iCommonArithmaticCalc = iCommonArithmaticCalc;
            _iStandardArithmaticCalc = iStandardArithmaticCalc;
            _logger = iLogger;
            _iCoreLogic = iCoreLogic;
            InitializeComponent();
            lblClearHistory.Visible = false;
            trvCalcList.Visible = false;
        }
        private void OnClickNumbers(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("OnClickNumbers Button Clicked");
                Button btnNumbers = (Button)sender;
                _logger.LogInformation("Button Pressed:"+ btnNumbers.Text);
                if (txtCalculations.Text == "0" || enterValue)
                {
                    txtCalculations.Text = string.Empty;
                    enterValue = false;
                }
                if (btnNumbers.Text == ".")
                {
                    if (!txtCalculations.Text.Contains("."))
                    {
                        txtCalculations.Text += btnNumbers.Text;
                        isNumberPressed = true;
                    }

                }
                else
                {
                    if (isEqualPressed)
                    {
                        txtCalculations.Text = btnNumbers.Text;
                        isEqualPressed = false;
                        _logger.LogInformation(txtCalculations.Text);
                    }
                    else
                    {
                        txtCalculations.Text += btnNumbers.Text;
                        _logger.LogInformation(txtCalculations.Text);
                    }

                }
            }
            catch (Exception ex)
            {
                txtCalculations.Text = ex.Message;
                _logger.LogError("OnClickNumbers():" + " " + ex.Message);
            }
        }
        private void OnClickArithmaticSymbol(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("OnClickArithmaticSymbol Button Clicked");
                Button btnOperation = (Button)sender;
                operation = btnOperation.Text;
                _logger.LogInformation("Operator Pressed:" + btnOperation.Text);
                if (result == ApplicationConstants.ARITHMATICDBL_VALUE0 && txtCalculations.Text != ApplicationConstants.ARITHMATICSTR_VALUE0)
                {
                    result = txtCalculations.Text.ToDouble();
                    enterValue = true;
                }
                else if (result != ApplicationConstants.ARITHMATICDBL_VALUE0 && txtCalculations.Text != ApplicationConstants.ARITHMATICSTR_VALUE0)
                {
                    if (isEqualPressed)
                    {
                        result = txtCalculations.Text.ToDouble();
                        enterValue = true;
                    }
                    else
                    {
                        result = _iCoreLogic.PerformCalculation(result, txtCalculations.Text.ToDouble(), btnOperation.Text);
                        enterValue = true;
                    }

                }
                txtCalculations.Text = result.ToString();
                lblOutput.Text = result.ToString() + " " + btnOperation.Text;
                _logger.LogInformation(result.ToString() + " " + btnOperation.Text);

            }
            catch (Exception ex)
            {
                _logger.LogError("OnClickArithmaticSymbol():" + " " + ex.Message);
                txtCalculations.Text = ex.Message;
            }
        }
        private void OnClickCommonArtSymbol(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("OnClickCommonArtSymbol Button Clicked");
                Button btnOperation = (Button)sender;
                operation = btnOperation.Text;
                _logger.LogInformation(txtCalculations.Text+" "+operation);
                txtCalculations.Text = (operation == btnPlusMinus.Text) ? _iCoreLogic.PerformCommonCalculation(txtCalculations.Text.ToDouble(), operation).ToString() :
                    _iCoreLogic.PerformCommonCalculation(txtCalculations.Text.ToDouble(), operation).ToString("0.000000");
                _logger.LogInformation(txtCalculations.Text);
            }
            catch (Exception ex)
            {
                txtCalculations.Text = ex.Message;
                _logger.LogError("OnClickCommonArtSymbol():" + " " + ex.Message);
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Equal Button Clicked");
                lblOutput.Text = string.Empty;
                lblOutput.Text = result.ToString() + " " + operation + " " + txtCalculations.Text + " " + btnEqual.Text;
                double opResult = _iCoreLogic.PerformCalculation(result, txtCalculations.Text.ToDouble(), operation);
                isEqualPressed = true;
                txtCalculations.Text = ((operation == btnDivision.Text) && (_iCommonArithmaticCalc.CalculateModularDiv(result, txtCalculations.Text.ToDouble()) > 0)) ?
                    opResult.ToString("0.00000") : opResult.ToString();
                _logger.LogInformation(txtCalculations.Text);
                if (opResult == 0)
                {
                    lblOutput.Text = result.ToString() + " " + btnEqual.Text;
                    _logger.LogInformation(lblOutput.Text);
                }
                result = double.Parse(txtCalculations.Text);
                operation = string.Empty;
                if (txtHistoryNMemory.Text == ApplicationConstants.HISTORY_TEXT)
                {
                    txtHistoryNMemory.Text = string.Empty;
                }
                lblClearHistory.Visible = true;
                txtHistoryNMemory.AppendText((opResult == 0) ? Environment.NewLine + result.ToString() + " " + btnEqual.Text :
                    Environment.NewLine + lblOutput.Text + " " + Environment.NewLine + result);
                _logger.LogInformation((opResult == 0) ? Environment.NewLine + result.ToString() + " " + btnEqual.Text :
                    Environment.NewLine + lblOutput.Text + " " + Environment.NewLine + result);

            }
            catch (Exception ex)
            {
                txtCalculations.Text = ex.Message;
                _logger.LogError("btnEqual_Click():" + " " + ex.Message);
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("btnClear_Click Button Clicked");
                if (txtCalculations.Text.Length > 0)
                {
                    txtCalculations.Text = txtCalculations.Text.ToClear();
                }
                else if (string.IsNullOrEmpty(txtCalculations.Text))
                {
                    txtCalculations.Text = ApplicationConstants.ARITHMATICSTR_VALUE0;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("btnClear_Click():"+" "+ex.Message);
                txtCalculations.Text = ex.Message;
            }


        }
        private void btnResetClick(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("btnResetClick Button Clicked");
                Button btnResetOperation = (Button)sender;
                txtCalculations.Text = ApplicationConstants.ARITHMATICSTR_VALUE0;
                lblOutput.Text = string.Empty;
                if (btnResetOperation.Text == ApplicationConstants.RESET_C)
                {
                    result = ApplicationConstants.ARITHMATICDBL_VALUE0;
                    _logger.LogWarning(result.ToString());
                }
            }
            catch (Exception ex)
            {
                txtCalculations.Text = ex.Message;
                _logger.LogError("btnResetClick():"+" "+ex.Message);
            }
        }
        private void lblClearHistory_Click(object sender, EventArgs e)
        {
            try
            {
                txtHistoryNMemory.Clear();
                txtHistoryNMemory.Text = ApplicationConstants.HISTORY_TEXT;
                lblClearHistory.Visible = false;
            }
            catch (Exception ex)
            {
                txtCalculations.Text = ex.Message;
                _logger.LogError("lblClearHistory_Click():"+" "+ex.Message);
            }
        }
        private void lblOption_Click(object sender, EventArgs e)
        {
            try
            {
                trvCalcList.Visible = (trvCalcList.Visible == true) ? false : true;
            }
            catch (Exception ex)
            {
                txtCalculations.Text = ex.Message;
                _logger.LogError("lblOption_Click():" + " " + ex.Message);
            }


        }
    }
}
