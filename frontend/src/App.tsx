/** @jsxImportSource @emotion/react */
import { css } from '@emotion/react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import { Header } from './Header';
import { HomePage } from './HomePage';
import { AskPage } from './AskPage';
import { SearchPage } from './SearchPage';
import { SignInPage } from './SignInPage';
import { NotFoundPage } from './NotFoundPage';
import { QuestionPage } from './QuestionPage';

import { fontFamily, fontSize, gray2 } from './Styles';
import React from 'react';

function App() {
  return (
    <BrowserRouter>
      <div
        css={css`
          font-family: ${fontFamily};
          font-size: ${fontSize};
          color: ${gray2};
        `}
      >
        <Header />
        <Routes>
          <Route path="" element={<HomePage/>} />
          <Route path="search" element={<SearchPage/>} />
          <Route path="ask" element={<AskPage/>} />
          <Route path="signin" element={<SignInPage/>} />
          <Route path="questions/:questionId" element={<QuestionPage/>} />
          <Route path="*" element={<NotFoundPage/>} />
        </Routes>
        <HomePage />
      </div>
    </BrowserRouter>
  );
}


export default App;