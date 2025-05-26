import React, { useState } from 'react';
import '../styles/Register.css';
import Logo from '../assets/Logo.png';

const Verify = () => {
  const [mobile, setMobile] = useState('');
  const [otp, setOtp] = useState('');
  const [step, setStep] = useState(1);
  const [errors, setErrors] = useState({ mobile: '', otp: '' });

  const handleSendOTP = (e) => {
    e.preventDefault();
    const newErrors = {};

    if (!mobile.match(/^\d{10}$/)) {
      newErrors.mobile = 'Please enter a valid 10-digit mobile number.';
    }

    setErrors(newErrors);

    if (Object.keys(newErrors).length === 0) {
      console.log('Sending OTP to:', mobile);
      setStep(2);
    }
  };

  const handleVerifyOTP = (e) => {
    e.preventDefault();
    const newErrors = {};

    if (otp.length !== 6 || !/^\d{6}$/.test(otp)) {
      newErrors.otp = 'Please enter a 6-digit numeric OTP.';
    }

    setErrors(newErrors);

    if (Object.keys(newErrors).length === 0) {
      console.log('Verifying OTP:', otp);
      // Continue verification
    }
  };

  return (
    <div className="register-container">
      <div className="left-pane">
        <img src={Logo} alt="mymane logo" className="logo" />
        <h2 className="title">Verify Your Mobile Number</h2>
        <p className="verify-subtitle">Enter your Mobile number to get the OTP.</p>

        <form onSubmit={step === 1 ? handleSendOTP : handleVerifyOTP} className="register-form">
          <div className="input-group">
            <label htmlFor="mobile" className="input-label">Mobile Number</label>
            <input
              type="tel"
              name="mobile"
              id="mobile"
              value={mobile}
              onChange={(e) => setMobile(e.target.value)}
              placeholder="Enter your mobile"
              disabled={step === 2}
              className="input-field"
              aria-invalid={!!errors.mobile}
              aria-describedby="mobile-error"
            />
            {errors.mobile && (
              <div id="mobile-error" className="error-text">{errors.mobile}</div>
            )}
          </div>

          {step === 1 ? (
            <button type="submit" className="submit-button">Get OTP</button>
          ) : (
            <>
              <div className="input-group">
                <label htmlFor="otp" className="input-label">OTP</label>
                <input
                  type="text"
                  name="otp"
                  id="otp"
                  value={otp}
                  onChange={(e) => setOtp(e.target.value)}
                  placeholder="Enter OTP"
                  className="input-field"
                  aria-invalid={!!errors.otp}
                  aria-describedby="otp-error"
                />
                {errors.otp && (
                  <div id="otp-error" className="error-text">{errors.otp}</div>
                )}
              </div>
              <button type="submit" className="submit-button">Verify OTP</button>
            </>
          )}
        </form>
      </div>

      <div
        className="right-pane"
        role="presentation"
        aria-label="Karnataka monument image"
      ></div>
    </div>
  );
};

export default Verify;
