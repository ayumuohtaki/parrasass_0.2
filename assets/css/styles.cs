@charset "UTF-8";
/* ------------------------------------------------


* Style Index
	#. Cores
	#. Layouts    :prefix[l-]
	#. Components :prefix[c-]
	#. Units
	#. Utilities  :prefix[u-]
	// #. Functions :prefix[js-]

------------------------------------------------ */
/* ------------------------------------------------
# Cores
------------------------------------------------ */
/*!
html5doctor.com Reset Stylesheet
v1.6.1
Last Updated: 2010-09-17
Author: Richard Clark - http://richclarkdesign.com
Twitter: @rich_clark
*/
html, body, div, span, object, iframe, h1, h2, h3, h4, h5, h6, p, blockquote, pre, abbr, address, cite, code, del, dfn, em, img, ins, kbd, q, samp, small, strong, sub, sup, var, b, i, dl, dt, dd, ol, ul, li, fieldset, form, label, legend, table, caption, tbody, tfoot, thead, tr, th, td, article, aside, canvas, details, figcaption, figure, footer, header, hgroup, menu, nav, section, summary, time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  outline: 0;
  font-size: 100%;
  vertical-align: baseline;
  background: transparent;
}

body {
  line-height: 1;
}

article, aside, details, figcaption, figure, footer, header, hgroup, menu, nav, section {
  display: block;
}

nav ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after, q:before, q:after {
  content: "";
  content: none;
}

a {
  margin: 0;
  padding: 0;
  font-size: 100%;
  vertical-align: baseline;
  background: transparent;
}

/* change colours to suit your needs */
ins {
  background-color: #ff9;
  color: #000;
  text-decoration: none;
}

/* change colours to suit your needs */
mark {
  background-color: #ff9;
  color: #000;
  font-style: italic;
  font-weight: bold;
}

del {
  text-decoration: line-through;
}

abbr[title], dfn[title] {
  border-bottom: 1px dotted;
  cursor: help;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

/* change border colour to suit your needs */
hr {
  display: block;
  height: 1px;
  border: 0;
  border-top: 1px solid #ccc;
  margin: 1em 0;
  padding: 0;
}

input, select {
  vertical-align: middle;
}

* {
  box-sizing: border-box;
}

*:before, *:after {
  box-sizing: inherit;
}

html {
  font-size: 62.5%;
  width: 100%;
  height: 100%;
  overflow-x: hidden;
}

body {
  font-size: 1.4rem;
  font-family: "繝偵Λ繧ｮ繝手ｧ偵ざ ProN W3", "Hiragino Kaku Gothic ProN", Meiryo, sans-serif;
  font-weight: 400;
  line-height: 1.76;
  letter-spacing: 1px;
  color: #343434;
  -webkit-font-feature-settings: "palt" 1;
  font-feature-settings: "palt" 1;
  -webkit-text-size-adjust: 100%;
}

img {
  width: 100%;
  height: auto;
  vertical-align: bottom;
  object-fit: cover;
}

svg {
  width: auto;
  height: auto;
  pointer-events: none;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
}

ul {
  list-style: none;
}

button {
  font-family: "繝偵Λ繧ｮ繝手ｧ偵ざ ProN W3", "Hiragino Kaku Gothic ProN", Meiryo, sans-serif;
  background: transparent;
  border: none;
  border-radius: 0;
  cursor: pointer;
  outline: none;
  padding: 0;
}

a {
  display: inline-block;
  color: #343434;
  opacity: 1;
  text-decoration: none;
  cursor: pointer;
}

input {
  border-radius: 0;
}

@-webkit-keyframes menu-barTop {
  0% {
    -webkit-transform: translateY(7px) rotate(45deg);
    transform: translateY(7px) rotate(45deg);
  }
  50% {
    -webkit-transform: translateY(7px) rotate(0);
    transform: translateY(7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
}
@keyframes menu-barTop {
  0% {
    -webkit-transform: translateY(7px) rotate(45deg);
    transform: translateY(7px) rotate(45deg);
  }
  50% {
    -webkit-transform: translateY(7px) rotate(0);
    transform: translateY(7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
}
@-webkit-keyframes menu-barBottom {
  0% {
    -webkit-transform: translateY(-7px) rotate(-45deg);
    transform: translateY(-7px) rotate(-45deg);
  }
  50% {
    -webkit-transform: translateY(-7px) rotate(0);
    transform: translateY(-7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
}
@keyframes menu-barBottom {
  0% {
    -webkit-transform: translateY(-7px) rotate(-45deg);
    transform: translateY(-7px) rotate(-45deg);
  }
  50% {
    -webkit-transform: translateY(-7px) rotate(0);
    transform: translateY(-7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
}
@-webkit-keyframes active-menu-barTop {
  0% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
  50% {
    -webkit-transform: translateY(7px) rotate(0);
    transform: translateY(7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(7px) rotate(45deg);
    transform: translateY(7px) rotate(45deg);
  }
}
@keyframes active-menu-barTop {
  0% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
  50% {
    -webkit-transform: translateY(7px) rotate(0);
    transform: translateY(7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(7px) rotate(45deg);
    transform: translateY(7px) rotate(45deg);
  }
}
@-webkit-keyframes active-menu-barBottom {
  0% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
  50% {
    -webkit-transform: translateY(-7px) rotate(0);
    transform: translateY(-7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(-7px) rotate(-45deg);
    transform: translateY(-7px) rotate(-45deg);
  }
}
@keyframes active-menu-barBottom {
  0% {
    -webkit-transform: translateY(0) rotate(0);
    transform: translateY(0) rotate(0);
  }
  50% {
    -webkit-transform: translateY(-7px) rotate(0);
    transform: translateY(-7px) rotate(0);
  }
  100% {
    -webkit-transform: translateY(-7px) rotate(-45deg);
    transform: translateY(-7px) rotate(-45deg);
  }
}
#header {
  width: 100%;
  position: absolute;
  top: 0;
  right: 0;
  padding: 32px 0 24px;
  -webkit-transition: none;
  transition: none;
  z-index: 100;
}
#header .header-inner {
  margin: auto;
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
  -webkit-flex-direction: row;
  -ms-flex-direction: row;
  flex-direction: row;
  -webkit-box-pack: justify;
  -webkit-justify-content: space-between;
  -ms-flex-pack: justify;
  justify-content: space-between;
  -webkit-box-align: center;
  -webkit-align-items: center;
  -ms-flex-align: center;
  align-items: center;
  max-width: 1280px;
  min-width: 960px;
  width: 76%;
}
#header .header-inner .toggle-menu {
  display: none;
  z-index: 150;
}
#header .header-inner .logo {
  width: 248px;
  line-height: 1;
  z-index: 150;
}
#header .header-inner .logo .main-logo {
  display: block;
}
#header .header-inner .logo .fixed-logo {
  display: none;
}
#header .header-nav {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
  -webkit-flex-direction: row;
  -ms-flex-direction: row;
  flex-direction: row;
}
#header .header-nav .global-nav {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
  -webkit-flex-direction: row;
  -ms-flex-direction: row;
  flex-direction: row;
}
#header .header-nav .global-nav .menu-item {
  margin: 0 16px;
}
#header .header-nav .global-nav .menu-item .nav-link {
  padding-bottom: 8px;
  font-family: "Vollkorn";
  font-size: 1.4rem;
  color: #fff;
  position: relative;
}
#header .header-nav .global-nav .menu-item .nav-link.active::after {
  opacity: 1;
}
#header .header-nav .global-nav .menu-item .nav-link::after {
  content: "";
  position: absolute;
  bottom: 0;
  left: 0;
  width: 100%;
  height: 1px;
  background: #fff;
  opacity: 0;
  -webkit-transition: opacity 0.4s ease-out;
  transition: opacity 0.4s ease-out;
}
#header .header-nav .global-nav .menu-item .nav-link:hover::after {
  opacity: 1;
}
#header .search-form {
  margin-left: 13px;
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
  -webkit-flex-direction: row;
  -ms-flex-direction: row;
  flex-direction: row;
}
#header .search-form .search-box::before {
  content: "";
  position: absolute;
  top: 0;
  left: 0;
  width: 40px;
  height: 40px;
  background-image: url("../images/svg/icon-search-white.svg");
  background-size: 22px 22px;
  background-repeat: no-repeat;
  background-position: center;
}
#header .search-form .search-box {
  display: none;
  margin-right: 12px;
  position: relative;
}
#header .search-form .search-box .search-input {
  padding: 0 40px;
  width: 322px;
  height: 40px;
  color: #fff;
  font-size: 1.4rem;
  letter-spacing: 0.1em;
  border: 1px solid #d0d0d0;
  background-color: transparent;
  outline: none;
}
#header .search-form .search-buttons .close-icon {
  display: none;
  height: 100%;
  background-image: url("../images/svg/icon-close-white.svg");
  background-position: center center;
}
#header .search-form .search-buttons .search-icon {
  display: block;
  height: 30px;
  background-image: url("../images/svg/icon-search-white.svg");
  background-position: center top;
  position: relative;
}
#header .search-form .search-buttons .search-icon::after {
  content: "";
  position: absolute;
  bottom: 0;
  left: 0;
  width: 100%;
  height: 1px;
  background: #fff;
  opacity: 0;
  -webkit-transition: opacity 0.4s ease-out;
  transition: opacity 0.4s ease-out;
}
#header .search-form .search-buttons .search-icon:hover::after {
  opacity: 1;
}
#header .search-mode {
  background-color: rgba(255, 255, 255, 0.43);
}
#header .search-mode .global-nav {
  display: none;
}
#header .search-mode .search-box {
  display: block;
}
#header .search-mode .search-buttons .close-icon {
  display: block;
}
#header .search-mode .search-buttons .search-icon {
  display: none;
}
#header .standby {
  position: fixed;
  padding: 24px 0;
  background-color: #fff;
  -webkit-transform: translateY(-100%);
  -ms-transform: translateY(-100%);
  transform: translateY(-100%);
}
#header .fixed {
  -webkit-transform: translateY(0);
  -ms-transform: translateY(0);
  transform: translateY(0);
  box-shadow: 0 3px 4px 0 rgba(0, 0, 0, 0.07);
}
#header .fixed .logo .main-logo {
  display: none;
}
#header .fixed .logo .fixed-logo {
  display: block;
}
#header .fixed .global-nav .menu-item .nav-link {
  color: #343434;
}
#header .fixed .global-nav .menu-item .nav-link::after {
  content: "";
  background: -webkit-linear-gradient(left, #c41a30, #494544);
  background: linear-gradient(to right, #c41a30, #494544);
}
#header .fixed .search-form .search-box::before {
  background-image: url("../images/svg/icon-search-black.svg");
}
#header .fixed .search-form .search-box .search-input {
  color: #343434;
  border: 1px solid #d0d0d0;
}
#header .fixed .search-form .search-buttons .close-icon {
  background-image: url("../images/svg/icon-close-black.svg");
}
#header .fixed .search-form .search-buttons .search-icon {
  background-image: url("../images/svg/icon-search-black.svg");
}
#header .fixed .search-form .search-buttons .search-icon::after {
  background: -webkit-linear-gradient(left, #127dd6, #4ec9e5);
  background: linear-gradient(to right, #127dd6, #4ec9e5);
}

.search-form .search-buttons .close-icon, #header .search-form .search-buttons .search-icon {
  width: 30px;
  height: 30px;
  background-size: 22px 22px;
  background-repeat: no-repeat;
}

/* --------------------------------
 * smart phone
 * -------------------------------- */
@media screen and (max-width: 959px) {
  #header {
    -webkit-box-align: center;
    -webkit-align-items: center;
    -ms-flex-align: center;
    align-items: center;
    padding: 10px 15px;
  }
  #header .header-inner {
    min-width: auto;
    width: auto;
  }
  #header .header-inner .toggle-menu {
    display: block;
    width: 40px;
    height: 30px;
    position: relative;
  }
  #header .header-inner .toggle-menu .toggle-line {
    display: block;
    position: absolute;
    top: 0;
    left: 0;
    bottom: 0;
    right: 0;
    margin: auto;
    text-indent: -9999px;
    width: 27px;
    height: 1px;
    background-color: #000;
  }
  #header .header-inner .toggle-menu .toggle-line::before {
    top: -7px;
    -webkit-animation: menu-barTop 0.6s forwards;
    animation: menu-barTop 0.6s forwards;
  }
  #header .header-inner .toggle-menu .toggle-line::after {
    top: 7px;
    -webkit-animation: menu-barBottom 0.6s forwards;
    animation: menu-barBottom 0.6s forwards;
  }
  #header .header-inner .logo {
    width: 159px;
  }
  #header .header-inner .logo .fixed-logo {
    display: none;
  }
  #header .header-nav {
    position: fixed;
    top: 0;
    left: 0;
    padding: 110px 15px 0;
    display: -webkit-box;
    display: -webkit-flex;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -webkit-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    width: 100vw;
    height: 100vh;
    background-color: rgba(0, 0, 0, 0.98);
    z-index: 90;
    -webkit-transform: translateX(100%);
    -ms-transform: translateX(100%);
    transform: translateX(100%);
    -webkit-transition: 0.3s ease-out;
    transition: 0.3s ease-out;
  }
  #header .global-nav {
    -webkit-box-ordinal-group: 3;
    -webkit-order: 2;
    -ms-flex-order: 2;
    order: 2;
    margin-top: 45px;
  }
  #header .global-nav .menu {
    -webkit-box-orient: vertical;
    -webkit-box-direction: normal;
    -webkit-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
  }
  #header .global-nav .menu-item {
    margin: 0;
    border-top: 1px solid #333;
  }
  #header .global-nav .menu-item .nav-link {
    display: block;
    padding: 13px 0;
    font-size: 1.5rem;
  }
  #header .global-nav .menu-item .nav-link::after {
    content: none;
  }
  #header .global-nav .menu-item:last-child {
    border-bottom: 1px solid #333;
  }
  #header .search-form {
    -webkit-box-ordinal-group: 2;
    -webkit-order: 1;
    -ms-flex-order: 1;
    order: 1;
    margin-left: 0;
  }
  #header .search-form .search-box {
    display: -webkit-box;
    display: -webkit-flex;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    -webkit-flex-direction: row;
    -ms-flex-direction: row;
    flex-direction: row;
    margin-right: 0;
    width: 100%;
    position: relative;
  }
  #header .search-form .search-box ::before {
    content: none;
  }
}
#header .toggle-menu .toggle-line::before, #header .toggle-menu .toggle-line::after {
  content: "";
  position: absolute;
  left: 0;
  width: 27px;
  height: 1px;
  background-color: #000;
}

/*# sourceMappingURL=styles.cs.map */
