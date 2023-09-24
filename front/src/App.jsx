import "./App.css";
import React from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Player from "./player/Player";
import { AuthorizationPage } from "./authorization/AuthorizationPage";
import { RegistrationPage } from "./authorization/RegistrationPage";
import { PageBuilder } from "./page_builder/PageBuilder";
import { MainPageSection } from "./mainPage/MainPageSection";
import { UserProfile } from "./userPage/UserProfile";
import { UserHistory } from "./userPage/userHistory/UserHistory";
import { UserMain } from "./userPage/userMain/UserMain";
import GoAwayPage from "./goAwayPage";
import { PlaylistPage } from "./playlistPage/PlaylistPage";
import { UserEdit } from "./userPage/UserEdit/UserEdit";
import { UserSettings } from "./userPage/UserEdit/UserSettings";
import { UserPassword } from "./userPage/UserEdit/UserPassword";
import { SearchPage } from "./searchPage/SearchPage";
import { ContactPage } from "./ContactPage/ContactPage";
import { ChatPage } from "./Chat/ChatPage";
import { UserStatisctics } from "./userPage/userStatistic/UserStatistic";
import { UserSubscription } from "./userPage/userSubscription/UserSubscription";
import GoogleCallbackPage from "./authorization/oauth/GoogleCallbackPage";

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route
            path="/playlist"
            element={<PageBuilder component={<PlaylistPage />} />}
          />
          <Route
            path="/album"
            element={<PageBuilder component={<PlaylistPage />} />}
          />
          <Route
            path="/authorize"
            element={<PageBuilder component={<AuthorizationPage />} />}
          />
          <Route
            path="/register"
            element={<PageBuilder component={<RegistrationPage />} />}
          />
          <Route
            path="/player"
            element={<PageBuilder component={<Player />} />}
          />
          <Route
            path="/main"
            element={<PageBuilder component={<MainPageSection />} />}
          />{" "}
          <Route
            path="/search"
            element={<PageBuilder component={<SearchPage />} />}
          />
          <Route
            path="/user/edit"
            element={
              <PageBuilder
                component={<UserEdit content={<UserSettings />} />}
              />
            }
          />
          <Route
            path="/user/statistic"
            element={<PageBuilder component={<UserStatisctics />} />}
          />
          <Route
            path="/user/subscription"
            element={<PageBuilder component={<UserSubscription />} />}
          />
          <Route
            path="/user/password"
            element={
              <PageBuilder
                component={<UserEdit content={<UserPassword />} />}
              />
            }
          />
          <Route
            path="/history"
            element={
              <PageBuilder
                component={<UserProfile component={<UserHistory />} />}
              />
            }
          />
          <Route
            path="/user"
            element={
              <PageBuilder
                component={<UserProfile component={<UserMain />} />}
              />
            }
          />
          <Route
            path="/contacts"
            element={<PageBuilder component={<ContactPage />} />}
          />
          <Route
            path="/chat"
            element={<PageBuilder component={<ChatPage />} />}
          />
          <Route
            path="/oauth/google/callback"
            element={<GoogleCallbackPage />}
          />
          {/* <Route path="/a" element={<PageBuilder component={<A />} />} />
          <Route path="/b" element={<PageBuilder component={<B />} />} /> */}
          <Route path="*" element={<GoAwayPage />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
