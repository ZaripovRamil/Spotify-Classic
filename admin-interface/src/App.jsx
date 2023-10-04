import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Tracks from './tracksPage/Tracks';
import Albums from './albumsPage/Albums';
import Authors from './authorsPage/Authors';
import Menu from './components/MenuComponent';
import Authorization from './authorizationPage/Authorization';
import PromotionPage from './promotionPage/Promotion';
import { ChatPage } from './chatsPage/ChatPage';
import { ChatsPage } from './chatsPage/ChatsPage';

function App() {
  return (
    <>
      <BrowserRouter>
        <Menu />
        <Routes>
          <Route path="/tracks" element={<Tracks />} />
          <Route path="/albums" element={<Albums />} />
          <Route path="/authors" element={<Authors />} />
          <Route path="/chats" element={<ChatsPage />} />
          <Route path="/chat/:userName" element={<ChatsPage component={<ChatPage/>} />} />
          <Route path="/authorize" element={<Authorization />} />
          <Route path="/promote" element={<PromotionPage />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
