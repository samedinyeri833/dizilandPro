/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/

html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed, 
figure, figcaption, footer, header, hgroup, 
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
	margin: 0;
	padding: 0;
	border: 0;
	font-size: 100%;
	font: inherit;
	vertical-align: baseline;
}
/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure, 
footer, header, hgroup, menu, nav, section {
	display: block;
}
body {
	line-height: 1;
}
ol, ul {
	list-style: none;
}
blockquote, q {
	quotes: none;
}
blockquote:before, blockquote:after,
q:before, q:after {
	content: '';
	content: none;
}
table {
	border-collapse: collapse;
	border-spacing: 0;
}
/**
*** SIMPLE GRID
*** (C) ZACH COLE 2016
**/
/* UNIVERSAL */

html,
body {
  width: 100%;
  margin: 0;
  padding: 0;
  left: 0;
  top: 0;
  font-size: 100%;
}

/* TYPOGRAPHY */

h1 {
  font-size: 2.5rem;
}

h2 {
  font-size: 2rem;
}

h3 {
  font-size: 1.375rem;
}

h4 {
  font-size: 1.125rem;
}

h5 {
  font-size: 1rem;
}

h6 {
  font-size: 0.875rem;
}

p {
  font-size: 1.125rem;
  font-weight: 200;
  line-height: 1.8;
}

.font-light {
  font-weight: 300;
}

.font-regular {
  font-weight: 400;
}

.font-heavy {
  font-weight: 700;
}

/* POSITIONING */

.left {
  text-align: left;
}

.right {
  text-align: right;
}

.f-left{
	float: left;
}

.f-right{
	float: right;
}

.center {
  text-align: center;
  margin-left: auto;
  margin-right: auto;
}

.justify {
  text-align: justify;
}

/* ==== GRID SYSTEM ==== */

.container {
  width: 90%; max-width: 1600px;
  margin-left: auto;
  margin-right: auto;
}
.row {
  position: relative;
  width: 100%;
}
.row [class^="col"] {
  float: left;
  margin: 0 2%;
  min-height: 0.125rem;
}
.col-1,
.col-2,
.col-3,
.col-4,
.col-5,
.col-6,
.col-7,
.col-8,
.col-9,
.col-10,
.col-11,
.col-12 {
  width: 96%;
}
.col-1-sm {
  width: 4.33%;
}
.col-2-sm {
  width: 12.66%;
}
.col-3-sm {
  width: 21%;
}
.col-4-sm {
  width: 29.33%;
}
.col-5-sm {
  width: 37.66%;
}
.col-6-sm {
  width: 46%;
}
.col-7-sm {
  width: 54.33%;
}
.col-8-sm {
  width: 62.66%;
}
.col-9-sm {
  width: 71%;
}
.col-10-sm {
  width: 79.33%;
}
.col-11-sm {
  width: 87.66%;
}
.col-12-sm {
  width: 96%;
}
.row::after {
	content: "";
	display: table;
	clear: both;
}
.hidden-sm {
  display: none;
}
.clearfix::after {
  content: "";
  clear: both;
  display: table;
}
@media only screen and (max-width: 33.75em) {  /* 540px */
  .container {
    width: 100%;
  }
}
@media only screen and (max-width: 33.75em) {  /* 540px - 720px */

  .col-3-md,
  .col-9-md, {
    width: 46%;
  }

}
@media only screen and (min-width: 48em) {  /* 720px */
  .col-1 {
    width: 4.33%;
  }
  .col-2 {
    width: 12.66%;
  }
  .col-3 {
    width: 21%;
  }
  .col-4 {
    width: 29.33%;
  }
  .col-5 {
    width: 37.66%;
  }
  .col-6 {
    width: 46%;
  }
  .col-7 {
    width: 54.33%;
  }
  .col-8 {
    width: 62.66%;
  }
  .col-9 {
    width: 71%;
  }
  .col-10 {
    width: 79.33%;
  }
  .col-11 {
    width: 87.66%;
  }
  .col-12 {
    width: 96%;
  }
  .hidden-sm {
    display: block;
  }
}
@font-face {
	font-family: 'Saira';
	src: url('../fonts/SairaSemiCondensed-ExtraLight.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-ExtraLight.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-ExtraLight.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-ExtraLight.svg') format('svg');
	font-weight: 200;
	font-style: normal;
}
@font-face {
	font-family: 'Saira';
	src: url('../fonts/SairaSemiCondensed-Light.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-Light.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-Light.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-Light.svg') format('svg');
	font-weight: 300;
	font-style: normal;
}
@font-face {
	font-family: 'Saira';
	src: url('../fonts/SairaSemiCondensed-Regular.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-Regular.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-Regular.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-Regular.svg') format('svg');
	font-weight: 400;
	font-style: normal;
}
@font-face {
	font-family: 'Saira';
	src: url('../fonts/SairaSemiCondensed-Medium.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-Medium.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-Medium.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-Medium.svg') format('svg');
	font-weight: 500;
	font-style: normal;
}
@font-face {
	font-family: 'Saira';
	src: url('../SairaSemiCondensed-SemiBold.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-SemiBold.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-SemiBold.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-SemiBold.svg') format('svg');
	font-weight: 600;
	font-style: normal;
}
@font-face {
	font-family: 'Saira';
	src: url('../fonts/SairaSemiCondensed-Bold.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-Bold.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-Bold.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-Bold.svg') format('svg');
	font-weight: 700;
	font-style: normal;
}
@font-face {
	font-family: 'Saira';
	src: url('../fonts/SairaSemiCondensed-ExtraBold.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-ExtraBold.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-ExtraBold.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-ExtraBold.svg') format('svg');
	font-weight: 800;
	font-style: normal;
}
@font-face {
	font-family: 'Saira';
	src: url('../fonts/SairaSemiCondensed-Black.eot');
    src: local('â˜º'),
    url('../fonts/SairaSemiCondensed-Black.woff') format('woff'),
    url('../fonts/SairaSemiCondensed-Black.ttf') format('truetype'),
    url('../fonts/SairaSemiCondensed-Black.svg') format('svg');
	font-weight: 900;
	font-style: normal;
}


@font-face {
    font-family: 'FOXPLAY';
    src: url('../fonts/FOXPLAY.eot');
    src: url('../fonts/FOXPLAY.eot?#iefix') format('embedded-opentype'),
         url('../fonts/FOXPLAY.woff') format('woff'),
         url('../fonts/FOXPLAY.ttf') format('truetype'),
         url('../fonts/FOXPLAY.svg#FOXPLAY') format('svg');
    font-weight: normal;
    font-style: normal;
}
[class*='icon-']:before{
	display: inline-block;
   font-family: 'FOXPLAY';
   font-style: normal;
   font-weight: normal;
   line-height: 1;
   -webkit-font-smoothing: antialiased;
   -moz-osx-font-smoothing: grayscale;
   text-rendering: auto;
}
.icon-logo-fox:before{content:'\0041';}
.icon-logo-play:before{content:'\0042';}
.icon-logo-fox-original:before{content:'\0043';}
.icon-app-store:before{content:'\0044';}
.icon-google-play:before{content:'\0045';}
.icon-play:before{content:'\0046';}
.icon-arrow-right:before{content:'\0047';}
.icon-arrow-left:before{content:'\0048';}
.icon-arrow-down:before{content:'\0049';}
.icon-arrow-top:before{content:'\004a';}
.icon-plus:before{content:'\004b';}
.icon-cancel:before{content:'\004c';}
.icon-facebook:before{content:'\004d';}
.icon-twitter:before{content:'\004e';}
.icon-instagram:before{content:'\004f';}
.icon-youtube:before{content:'\0050';}
.icon-g-plus:before{content:'\0051';}
.icon-pinterest:before{content:'\0052';}
.icon-search:before{content:'\0053';}
.icon-profile:before{content:'\0054';}
.icon-hamburger:before{content:'\0055';}
.icon-check:before{content:'\0056';}
.icon-mark:before{content:'\0057';}
/**
 * Owl Carousel v2.3.4
 * Copyright 2013-2018 David Deutsch
 * Licensed under: SEE LICENSE IN https://github.com/OwlCarousel2/OwlCarousel2/blob/master/LICENSE
 */
/*
 *  Owl Carousel - Core
 */
.owl-carousel {
  display: none;
  width: 100%;
  -webkit-tap-highlight-color: transparent;
  /* position relative and z-index fix webkit rendering fonts issue */
  position: relative;
  z-index: 1; }
  .owl-carousel .owl-stage {
    position: relative;
    -ms-touch-action: pan-Y;
    touch-action: manipulation;
    -moz-backface-visibility: hidden;
    /* fix firefox animation glitch */ }
  .owl-carousel .owl-stage:after {
    content: ".";
    display: block;
    clear: both;
    visibility: hidden;
    line-height: 0;
    height: 0; }
  .owl-carousel .owl-stage-outer {
    position: relative;
    overflow: hidden;
    /* fix for flashing background */
    -webkit-transform: translate3d(0px, 0px, 0px); }
  .owl-carousel .owl-wrapper,
  .owl-carousel .owl-item {
    -webkit-backface-visibility: hidden;
    -moz-backface-visibility: hidden;
    -ms-backface-visibility: hidden;
    -webkit-transform: translate3d(0, 0, 0);
    -moz-transform: translate3d(0, 0, 0);
    -ms-transform: translate3d(0, 0, 0); }
  .owl-carousel .owl-item {
    position: relative;
    min-height: 1px;
    overflow: hidden;
    float: left;
    -webkit-backface-visibility: hidden;
    -webkit-tap-highlight-color: transparent;
    -webkit-touch-callout: none; }
  .owl-carousel .owl-item img {
    display: block;
    width: 100%; }
  .owl-carousel .owl-nav.disabled,
  .owl-carousel .owl-dots.disabled {
    display: none; }
  .owl-carousel .owl-nav .owl-prev,
  .owl-carousel .owl-nav .owl-next,
  .owl-carousel .owl-dot {
    cursor: pointer;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none; }
  .owl-carousel .owl-nav button.owl-prev,
  .owl-carousel .owl-nav button.owl-next,
  .owl-carousel button.owl-dot {
    background: none;
    color: inherit;
    border: none;
    padding: 0 !important;
    font: inherit; }
  .owl-carousel.owl-loaded {
    display: block; }
  .owl-carousel.owl-loading {
    opacity: 0;
    display: block; }
  .owl-carousel.owl-hidden {
    opacity: 0; }
  .owl-carousel.owl-refresh .owl-item {
    visibility: hidden; }
  .owl-carousel.owl-drag .owl-item {
    -ms-touch-action: pan-y;
        touch-action: pan-y;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none; }
  .owl-carousel.owl-grab {
    cursor: move;
    cursor: grab; }
  .owl-carousel.owl-rtl {
    direction: rtl; }
  .owl-carousel.owl-rtl .owl-item {
    float: right; }

/* No Js */
.no-js .owl-carousel {
  display: block; }

/*
 *  Owl Carousel - Animate Plugin
 */
.owl-carousel .animated {
  animation-duration: 1000ms;
  animation-fill-mode: both; }

.owl-carousel .owl-animated-in {
  z-index: 0; }

.owl-carousel .owl-animated-out {
  z-index: 1; }

.owl-carousel .fadeOut {
  animation-name: fadeOut; }

@keyframes fadeOut {
  0% {
    opacity: 1; }
  100% {
    opacity: 0; } }

/*
 * 	Owl Carousel - Auto Height Plugin
 */
.owl-height {
  transition: height 500ms ease-in-out; }

/*
 * 	Owl Carousel - Lazy Load Plugin
 */
.owl-carousel .owl-item {
  /**
			This is introduced due to a bug in IE11 where lazy loading combined with autoheight plugin causes a wrong
			calculation of the height of the owl-item that breaks page layouts
		 */ }
  .owl-carousel .owl-item .owl-lazy {
    opacity: 0;
    transition: opacity 400ms ease; }
  .owl-carousel .owl-item .owl-lazy[src^=""], .owl-carousel .owl-item .owl-lazy:not([src]) {
    max-height: 0; }
  .owl-carousel .owl-item img.owl-lazy {
    transform-style: preserve-3d; }

/*
 * 	Owl Carousel - Video Plugin
 */
.owl-carousel .owl-video-wrapper {
  position: relative;
  height: 100%;
  background: #000; }

.owl-carousel .owl-video-play-icon {
  position: absolute;
  height: 80px;
  width: 80px;
  left: 50%;
  top: 50%;
  margin-left: -40px;
  margin-top: -40px;
  background: url("../../image/plugins/owl.video.play.png") no-repeat;
  cursor: pointer;
  z-index: 1;
  -webkit-backface-visibility: hidden;
  transition: transform 100ms ease; }

.owl-carousel .owl-video-play-icon:hover {
  -ms-transform: scale(1.3, 1.3);
      transform: scale(1.3, 1.3); }

.owl-carousel .owl-video-playing .owl-video-tn,
.owl-carousel .owl-video-playing .owl-video-play-icon {
  display: none; }

.owl-carousel .owl-video-tn {
  opacity: 0;
  height: 100%;
  background-position: center center;
  background-repeat: no-repeat;
  background-size: contain;
  transition: opacity 400ms ease; }

.owl-carousel .owl-video-frame {
  position: relative;
  z-index: 1;
  height: 100%;
  width: 100%; }

.video-js .vjs-big-play-button:before, .video-js .vjs-control:before, .video-js .vjs-modal-dialog, .vjs-modal-dialog .vjs-modal-dialog-content {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%; }

.video-js .vjs-big-play-button:before, .video-js .vjs-control:before {
  text-align: center; }

@font-face {
  font-family: VideoJS;
  src: url("font/VideoJS.eot?#iefix") format("eot"); }

@font-face {
  font-family: VideoJS;
  src: url(data:application/font-woff;charset=utf-8;base64,d09GRgABAAAAAA54AAoAAAAAFmgAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAABPUy8yAAAA9AAAAD4AAABWUZFeBWNtYXAAAAE0AAAAOgAAAUriMBC2Z2x5ZgAAAXAAAAouAAAPUFvx6AdoZWFkAAALoAAAACsAAAA2DIPpX2hoZWEAAAvMAAAAGAAAACQOogcgaG10eAAAC+QAAAAPAAAAfNkAAABsb2NhAAAL9AAAAEAAAABAMMg06m1heHAAAAw0AAAAHwAAACABMAB5bmFtZQAADFQAAAElAAACCtXH9aBwb3N0AAANfAAAAPwAAAGBZkSN43icY2BkZ2CcwMDKwMFSyPKMgYHhF4RmjmEIZzzHwMDEwMrMgBUEpLmmMDh8ZPwoxw7iLmSHCDOCCADvEAo+AAB4nGNgYGBmgGAZBkYGEHAB8hjBfBYGDSDNBqQZGZgYGD7K/f8PUvCREUTzM0DVAwEjG8OIBwCPdwbVAAB4nI1Xe1CU1xX/zv1eLItLln0JwrIfC7sJGET2hRJ2N1GUoBJE8AESQEEhmBHjaB7UuBMTO4GMaSu7aY3RNlOdRPNqO2pqRmuTaSZtR6JJILUZk00a/4imjpmiecB303O/XUgMJOPufvd+99xzzz33nN855y4HHH7EfrGfIxwHRiANvF/sH71I9BzHszmpW+rGOQOXxXE6YhI4PoMT8zkT4cDFuf1cwMrZJI5cglM0HKVv0MaUFDgIFfg9mJJCG+kbKn1JkqBOVaFOkuhLpARq8fu0Nnc9/zdvfY9PxXW4PdH0C6N+PCejhorxFjAqRjgFRXSINEARbBGsoxcFK7IJmr4OycFJnInL59zIXwxui80fkGRbEHyosMWaATJKUfCskmwJQsAWANkmnIGOhlf514h7U8HNIv3owoHB0WMt0Eb3sx0guLi5pq/8Ny1q6969fKR9X9GBV6dPv6dp04K99SOwtmyPl47ApRa6n4ZpP1yjr5fn7MmYP/vXLUJs715UguklHBaHOZHZmG1N9FAIW2mf0MqWCIdo/8RZ1yGfxKUldDcGIbFA7ICO+vqOMSPTh/ZrSqgHi/bB/O8E8Mnzp+M+acxfpsTShBwej26TiGxBn7m4eEIO+Rueu6Hj+IFBnh88cAEUEQ//nVLx5C7kf+yIR47QEe+eMlhz9SqsGbe3hh2R03NGzoY6O42Kz8l7fB6fAk6LYnTyFo/FYyT6GGyNx2Jx2sdH4rA1Fo/HyCXaFyOp8dhYBCfJb2NIn1ImE6CYNGmgSTb52DawJR6jfXEmDU4xyTEmpgHHOIStoxfjSGdkbsK2w2jbdMQG4sgAstEONgURYCwGHhEhhscioQaAhhCf7McifEQc0l6+mxj9nI+gmSdiQ0Zbm7gZnIO7GSMEXG6UDAVocxAV8GcEXCKg1a02RcTtwANWRGIAyElor6n/+ZU2yOB3+T77Hb1MLqhn4KHVnQBjJnqe9QZSon6Kc5DxAD2vMdPL/BXSmQGwspa67z9wLUjdi9TN7QC7lyyBr9rpt7uXVC1CMpyjKRoXnGPHTuiaPLsNdc2dbAFQLAooPkXEh33FodHl4XpC6sPCIa0ftUIhHSYXVSu5iME+DIXsbZJ51BeidCgajcai43jU9nVzoSn2dPqcFvSoxSzJzgRKAx47WMRxOrIj3Wf0+hndxhJTiOkSEqxar3b3RKM9hY64oxBA64ieURLvCfpkDb8siBdUJ1bgT+urJ5PGfewQrmm5R5+0HmfyIPySD7OYkT0WxRePah8oEiyjlxIP74thVoRTURpmL6QhGuWS+QDjdANXjIM8SQa/1w128ODx0Qp4aLMNg9+JL3joUn8AMxW+aLNiuKjarn4uyyTdXjOzZTsh21uwldUvJoYza+zELALfu3p1L8/3krtyZ0Ag058J3hxHghvbGZn0dHZy6Mim/7Blre4lpHd1c28yVqRViO153F2oIWoXCIKbL4Z0cM1iaQn9mI5KuV2SzEvWXJDMNtkANpMdQoDDhIdD4A/YrP6Aye9ysxyE+uOEAcTDorgvVZJjcua043PnZ/PmdDqcbibZlXOOT8uSo7Kof0YUn9GL+Jo17ficymxiTofC6znUso0DhAxs1Fo+kF+d36vLmgZ8mk5cdGv2mwYj5k3Dm9m3LhJ1aVRNm6HrTbLgYAoWXDhDd/u4PGy5CT+xGMdiaBovewUCF/1BiWNljI9MLn7jeScpg+WyH6mfU62eVDql7hsrmvx1ezp/YldE2LhjbkiDnAn8tGy/MW3IXRMYJduvq9HpmIcKuFt+JCtgdGEGKAcF6UacVwIYbVPGfw/+YuNBS4cx/CUHcnyfc+wRDMtTr72mMSBjT/yn/GKSdeDWQUCH6Xoqq5R10RE60gV6erUL0iCti16d0hZjxut4QI/rEpgSh6WjnJXdBXRg1GKCucGJPtFqM27aD1tOqqKonsQ2KsFSSmEpmvRlsR+TcD9OFwrqXxIclL4sJTnGMSuG8KpkZvKdeVIOKDyWSyPLV16/p1QMPbP8NihwUzr47bdnXtwtjdCvqqpO0H+pOvIl3Pzv46e5CT/tQjklXCXXym1AaWY7bzHLkuDMc7ldKCvgxzLn8wYkJLBhEDyK7MT8bTbwbkxbfp+3mKAGsmTBpabSIEECzMIcQlzOPAMKsxMs7uhsnxPLuofPDTc1hkuq6MX9j16YU7CqegcYHbmWYuvAP6tCS97tgWf7dlQvnl25YPavXLVZvrzQPeHCpZmzzEUVq/xzu5sChnSTPTW7oOYmh69z4zL/gk3b+O6hoa733uviP82vnFcbqWlc9tDmZa23LVzaV1yXURi+JX+28NeBuj3+O8IrQ080Vm1eWB4OKjPmrJu7c1udWynvKF6/vs479lSW9+5gZkn+dKfellNGDPllzeULustz+A0bPvhgw7lkvEUwn/N4Ty7U7nhGsEpFkOfy+kutbOh1JQxhVDJumoW11hnkPThznh6FFlhfT+ra1x9sF56kx5YuDzVY9PQYAYA7iblw4frQ4TPCk2MK/xGU3rlmze62trHz6lsko+v+So/do74PT8KVkpJfOErKcv8znrMGsHTNxoEkWy1mYgDB6XBbPaWsuiS6CryGaL6zCjaXBgvtkuyXBua1wOKnh+k7L9AvPnYWffxK18FcJbuosGf3/Jo7amY+CE1vppzY+UTrva0FXc1i55pKQ/YjVL187N5fCn1kW5uot/1hi+DiZ+5atnJR9E+prvydJ9ZZ5mwOpU5gM4KYysMBQ71UzPuMTl9QQOyUo5nwioeYCPjFklrbK6s6X+ypUZ6rum9+CZYzWRiBJfSP0xzzSmrg7f86g0DKVj/wwFzieD9rRfPGFbeKMl05pn5j9/rsQJJ2iEgRrpohlyBo3f4QK7Kl+EcAYZgAoNVmZWXK704YAa3FwBxgSGUOs5htvGRz4Sgj3yFkSJFBuv/sxu5yk998T8WDJzvv/2RX19HtTUW1S+wpKRKRjJ6zzz/1/OPdFdWGlAKbvzS4PHOtURikg9AGz0LbIB85S/cPOpoXvuue8/iV2H1vPTy3ddvOeZ37HGmO3OmSzVzR+NS53+84dHlFhXPLqtzSO+5ruHM2vXtBdxP87LOzKAD359j/INYIbyPabIi3Cq6Wa+SaGe78diIzu7qcblcAa6/fJRvNopXFJnO+U9KKM5bqH5LM0iQSVmpPCPDu7ZT4Aoubz3709EBTyrTDjyx8MQXgUH1nqm7TWng4TzE4i4AsKskBITXfSyC4Fkl5MxnJDiKSIDSJAsGvd1y+/eNDp2e+A+5d8HeiiunrTkT6TqWLIs+/QRoWr98s0qj8uuzLuS22Ytufg3rdTaHn1m46sfgGKHXt0MGnLaRHdnwN37tvHcWKo2V6lnPxL4UvUQcRdOzmZSQs8X5CH5OxXMXpkATuDz8Et0SH4uyCRR+TjmBDP1GvsVrWEGVzEj33YVQ9jAtIKpqsl/s/0xrocwAAeJxjYGRgYADig3cEzsTz23xl4GZnAIHLRucNkWl2BrA4BwMTiAIAF4IITwB4nGNgZGBgZwCChWASxGZkQAXyABOUANh4nGNnYGBgHyAMADa8ANoAAAAAAAAOAFAAZgCyAMYA5gEeAUgBdAGcAfICLgKOAroDCgOOA7AD6gQ4BHwEuAToBQwFogXoBjYGbAbaB3IHqHicY2BkYGCQZ8hlYGcAASYg5gJCBob/YD4DABbVAaoAeJxdkE1qg0AYhl8Tk9AIoVDaVSmzahcF87PMARLIMoFAl0ZHY1BHdBJIT9AT9AQ9RQ9Qeqy+yteNMzDzfM+88w0K4BY/cNAMB6N2bUaPPBLukybCLvleeAAPj8JD+hfhMV7hC3u4wxs7OO4NzQSZcI/8Ltwnfwi75E/hAR7wJTyk/xYeY49fYQ/PztM+jbTZ7LY6OWdBJdX/pqs6NYWa+zMxa13oKrA6Uoerqi/JwtpYxZXJ1coUVmeZUWVlTjq0/tHacjmdxuL90OR8O0UEDYMNdtiSEpz5XQGqzlm30kzUdAYFFOb8R7NOZk0q2lwAyz1i7oAr1xoXvrOgtYhZx8wY5KRV269JZ5yGpmzPTjQhvY9je6vEElPOuJP3mWKnP5M3V+YAAAB4nG2P2XLCMAxFfYFspGUp3Te+IB9lHJF4cOzUS2n/voaEGR6qB+lKo+WITdhga/a/bRnDBFPMkCBFhhwF5ihxg1sssMQKa9xhg3s84BFPeMYLXvGGd3zgE9tZr/hveXKVkFYoSnoeHJXfRoWOqi54mo9ameNFdrK+dLSyaVf7oJQTlkhXpD3Z5XXhR/rUfQVuKXO91Jps4cLOS6/I5YL3XhodRRsVWZe4NnZOhWnSAWgxhMoEr6SmzZieF43Mk7ZOBdeCVGrp9Eu+54J2xhySplfB5XHwQLXUmT9KH6+kPnQ7ZYuIEzNyfs1DLU1VU4SWZ6LkXGHsD1ZKbMw=) format("woff"), url(data:application/x-font-ttf;charset=utf-8;base64,AAEAAAAKAIAAAwAgT1MvMlGRXgUAAAEoAAAAVmNtYXDiMBC2AAAB/AAAAUpnbHlmW/HoBwAAA4gAAA9QaGVhZAyD6V8AAADQAAAANmhoZWEOogcgAAAArAAAACRobXR42QAAAAAAAYAAAAB8bG9jYTDINOoAAANIAAAAQG1heHABMAB5AAABCAAAACBuYW1l1cf1oAAAEtgAAAIKcG9zdGZEjeMAABTkAAABgQABAAAHAAAAAKEHAAAAAAAHAAABAAAAAAAAAAAAAAAAAAAAHwABAAAAAQAAwdxheF8PPPUACwcAAAAAANMyzzEAAAAA0zLPMQAAAAAHAAcAAAAACAACAAAAAAAAAAEAAAAfAG0ABwAAAAAAAgAAAAoACgAAAP8AAAAAAAAAAQcAAZAABQAIBHEE5gAAAPoEcQTmAAADXABXAc4AAAIABQMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAUGZFZABA8QHxHgcAAAAAoQcAAAAAAAABAAAAAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAcAAAAHAAAABwAAAAAAAAMAAAADAAAAHAABAAAAAABEAAMAAQAAABwABAAoAAAABgAEAAEAAgAA8R7//wAAAADxAf//AAAPAAABAAAAAAAAAAABBgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAOAFAAZgCyAMYA5gEeAUgBdAGcAfICLgKOAroDCgOOA7AD6gQ4BHwEuAToBQwFogXoBjYGbAbaB3IHqAABAAAAAAWLBYsAAgAAAREBAlUDNgWL++oCCwAAAwAAAAAGawZrAAIADgAaAAAJAhMEAAMSAAUkABMCAAEmACc2ADcWABcGAALrAcD+QJX+w/5aCAgBpgE9AT0BpggI/lr+w/3+rgYGAVL9/QFSBgb+rgIwAVABUAGbCP5a/sP+w/5aCAgBpgE9AT0BpvrIBgFS/f0BUgYG/q79/f6uAAAAAgAAAAAFQAWLAAMABwAAASERKQERIREBwAEr/tUCVQErAXUEFvvqBBYAAAAEAAAAAAYgBiAABgATACQAJwAAAS4BJxUXNjcGBxc+ATUmACcVFhIBBwEhESEBEQEGBxU+ATcXNwEHFwTQAWVVuAO7AidxJSgF/t/lpc77t18BYf6fASsBdQE+TF1OijuZX/1gnJwDgGSeK6W4GBhqW3FGnFT0AWM4mjT+9AHrX/6f/kD+iwH2/sI7HZoSRDGYXwSWnJwAAAEAAAAABKsF1gAFAAABESEBEQECCwEqAXb+igRg/kD+iwSq/osAAAACAAAAAAVmBdYABgAMAAABLgEnET4BAREhAREBBWUBZVRUZfwRASsBdf6LA4Bkniv9piueAUT+QP6LBKr+iwAAAwAAAAAGIAYPAAUADAAaAAATESEBEQEFLgEnET4BAxUWEhcGAgcVNgA3JgDgASsBdf6LAsUBZVVVZbqlzgMDzqXlASEFBf7fBGD+QP6LBKr+i+Bkniv9piueAvOaNP70tbX+9DSaOAFi9fUBYgAAAAQAAAAABYsFiwAFAAsAEQAXAAABIxEhNSMDMzUzNSEBIxUhESMDFTMVMxECC5YBduCWluD+igOA4AF2luDglgLr/oqWAgrglvyAlgF2AqCW4AF2AAQAAAAABYsFiwAFAAsAEQAXAAABMxUzESETIxUhESMBMzUzNSETNSMRITUBdeCW/org4AF2lgHAluD+ipaWAXYCVeABdgHAlgF2++rglgHA4P6KlgAAAAACAAAAAAXWBdYADwATAAABIQ4BBxEeARchPgE3ES4BAyERIQVA/IA/VQEBVT8DgD9VAQFVP/yAA4AF1QFVP/yAP1UBAVU/A4A/VfvsA4AAAAYAAAAABmsGawAHAAwAEwAbACAAKAAACQEmJw4BBwElLgEnAQUhATYSNyYFAQYCBxYXIQUeARcBMwEWFz4BNwECvgFkTlSH8GEBEgOONemh/u4C5f3QAXpcaAEB/BP+3VxoAQEOAjD95DXpoQESeP7dTlSH8GH+7gPwAmgSAQFYUP4nd6X2Pv4nS/1zZAEBk01NAfhk/v+TTUhLpfY+Adn+CBIBAVhQAdkAAAAFAAAAAAZrBdYADwATABcAGwAfAAABIQ4BBxEeARchPgE3ES4BASEVIQEhNSEFITUhNSE1IQXV+1ZAVAICVEAEqkBUAgJU+xYBKv7WAur9FgLqAcD+1gEq/RYC6gXVAVU//IA/VQEBVT8DgD9V/ayV/tWVlZWWlQADAAAAAAYgBdYADwAnAD8AAAEhDgEHER4BFyE+ATcRLgEBIzUjFTM1MxUUBgcjLgEnET4BNzMeARUFIzUjFTM1MxUOAQcjLgE1ETQ2NzMeARcFi/vqP1QCAlQ/BBY/VAICVP1rcJWVcCog4CAqAQEqIOAgKgILcJWVcAEqIOAgKiog4CAqAQXVAVU//IA/VQEBVT8DgD9V/fcl4CVKICoBASogASogKgEBKiBKJeAlSiAqAQEqIAEqICoBASogAAAGAAAAAAYgBPYAAwAHAAsADwATABcAABMzNSMRMzUjETM1IwEhNSERITUhERUhNeCVlZWVlZUBKwQV++sEFfvrBBUDNZb+QJUBwJX+QJb+QJUCVZWVAAAAAQAAAAAGIAZsAC4AAAEiBgcBNjQnAR4BMz4BNy4BJw4BBxQXAS4BIw4BBx4BFzI2NwEGBx4BFz4BNy4BBUArSh797AcHAg8eTixffwICf19ffwIH/fEeTixffwICf18sTh4CFAUBA3tcXHsDA3sCTx8bATcZNhkBNB0gAn9fX38CAn9fGxn+zRwgAn9fX38CIBz+yhcaXHsCAntcXXsAAAIAAAAABlkGawBDAE8AAAE2NCc3PgEnAy4BDwEmLwEuASchDgEPAQYHJyYGBwMGFh8BBhQXBw4BFxMeAT8BFh8BHgEXIT4BPwE2NxcWNjcTNiYnBS4BJz4BNx4BFw4BBasFBZ4KBgeWBxkNujpEHAMUD/7WDxQCHEU5ug0aB5UHBQudBQWdCwUHlQcaDbo5RRwCFA8BKg8UAhxFOboNGgeVBwUL/ThvlAIClG9vlAIClAM3JEokewkaDQEDDAkFSy0cxg4RAQERDsYcLUsFCQz+/QwbCXskSiR7CRoN/v0MCQVLLRzGDhEBAREOxhwtSwUJDAEDDBsJQQKUb2+UAgKUb2+UAAAAAAEAAAAABmsGawALAAATEgAFJAATAgAlBACVCAGmAT0BPQGmCAj+Wv7D/sP+WgOA/sP+WggIAaYBPQE9AaYICP5aAAAAAgAAAAAGawZrAAsAFwAAAQQAAxIABSQAEwIAASYAJzYANxYAFwYAA4D+w/5aCAgBpgE9AT0BpggI/lr+w/3+rgYGAVL9/QFSBgb+rgZrCP5a/sP+w/5aCAgBpgE9AT0BpvrIBgFS/f0BUgYG/q79/f6uAAADAAAAAAZrBmsACwAXACMAAAEEAAMSAAUkABMCAAEmACc2ADcWABcGAAMOAQcuASc+ATceAQOA/sP+WggIAaYBPQE9AaYICP5a/sP9/q4GBgFS/f0BUgYG/q4dAn9fX38CAn9fX38Gawj+Wv7D/sP+WggIAaYBPQE9Aab6yAYBUv39AVIGBv6u/f3+rgJPX38CAn9fX38CAn8AAAAEAAAAAAYgBiAADwAbACUAKQAAASEOAQcRHgEXIT4BNxEuAQEjNSMVIxEzFTM1OwEhHgEXEQ4BByE3MzUjBYv76j9UAgJUPwQWP1QCAlT9a3CVcHCVcJYBKiAqAQEqIP7WcJWVBiACVD/76j9UAgJUPwQWP1T8gpWVAcC7uwEqIP7WICoBcOAAAgAAAAAGawZrAAsAFwAAAQQAAxIABSQAEwIAEwcJAScJATcJARcBA4D+w/5aCAgBpgE9AT0BpggI/lo4af70/vRpAQv+9WkBDAEMaf71BmsI/lr+w/7D/loICAGmAT0BPQGm/BFpAQv+9WkBDAEMaf71AQtp/vQAAQAAAAAF1ga2ABYAAAERCQERHgEXDgEHLgEnIxYAFzYANyYAA4D+iwF1vv0FBf2+vv0FlQYBUf7+AVEGBv6vBYsBKv6L/osBKgT9v779BQX9vv7+rwYGAVH+/gFRAAAAAQAAAAAFPwcAABQAAAERIyIGHQEhAyMRIREjETM1NDYzMgU/nVY8ASUn/v7O///QrZMG9P74SEi9/tj9CQL3ASjaus0AAAAABAAAAAAGjgcAADAARQBgAGwAAAEUHgMVFAcGBCMiJicmNTQ2NzYlLgE1NDcGIyImNTQ2Nz4BMyEHIx4BFRQOAycyNjc2NTQuAiMiBgcGFRQeAxMyPgI1NC4BLwEmLwImIyIOAxUUHgIBMxUjFSM1IzUzNTMDH0BbWkAwSP7qn4TlOSVZSoMBESAfFS4WlMtIP03TcAGiioNKTDFFRjGSJlAaNSI/akAqURkvFCs9WTY6a1s3Dg8THgocJU4QIDVob1M2RnF9A2vV1WnU1GkD5CRFQ1CATlpTenNTYDxHUYouUhIqQCkkMQTBlFKaNkJAWD+MWkhzRztAPiEbOWY6hn1SJyE7ZS5nZ1I0/JcaNF4+GTAkGCMLFx04Ag4kOF07Rms7HQNsbNvbbNkAAwAAAAAGgAZsAAMADgAqAAABESERARYGKwEiJjQ2MhYBESERNCYjIgYHBhURIRIQLwEhFSM+AzMyFgHd/rYBXwFnVAJSZGemZASP/rdRVj9VFQv+twIBAQFJAhQqR2c/q9AEj/whA98BMkliYpNhYfzd/cgCEml3RTMeM/3XAY8B8DAwkCAwOB/jAAABAAAAAAaUBgAAMQAAAQYHFhUUAg4BBCMgJxYzMjcuAScWMzI3LgE9ARYXLgE1NDcWBBcmNTQ2MzIXNjcGBzYGlENfAUyb1v7SrP7x4SMr4bBpph8hHCsqcJNETkJOLHkBW8YIvYaMYG1gJWldBWhiRQ4cgv797rdtkQSKAn1hBQsXsXUEJgMsjlNYS5WzCiYkhr1mFTlzPwoAAAABAAAAAAWABwAAIgAAARcOAQcGLgM1ESM1PgQ3PgE7AREhFSERFB4CNzYFMFAXsFlorXBOIahIckQwFAUBBwT0AU3+sg0gQzBOAc/tIz4BAjhceHg6AiDXGlddb1ctBQf+WPz9+h40NR4BAgABAAAAAAaABoAASgAAARQCBCMiJzY/AR4BMzI+ATU0LgEjIg4DFRQWFxY/ATY3NicmNTQ2MzIWFRQGIyImNz4CNTQmIyIGFRQXAwYXJgI1NBIkIAQSBoDO/p/Rb2s7EzYUaj15vmh34o5ptn9bK1BNHggIBgIGETPRqZepiWs9Sg4IJRc2Mj5WGWMRBM7+zgFhAaIBYc4DgNH+n84gXUfTJzmJ8JZyyH46YH2GQ2ieIAwgHxgGFxQ9WpfZpIOq7lc9I3VZHzJCclVJMf5eRmtbAXzp0QFhzs7+nwAABwAAAAAHAATPAA4AFwAqAD0AUABaAF0AAAERNh4CBw4BBwYmIycmNxY2NzYmBxEUBRY2Nz4BNy4BJyMGHwEeARcOARcWNjc+ATcuAScjBh8BHgEXFAYXFjY3PgE3LgEnIwYfAR4BFw4BBTM/ARUzESMGAyUVJwMchM2UWwgNq4JHrQgBAapUaAoJcWMBfiIhDiMrAQJLMB0BBAokNAIBPmMiIQ4iLAECSzAeAQUKJDQBP2MiIQ4iLAECSzAeAQUKJDQBAT75g+5B4arNLNIBJ44ByQL9BQ9mvYCKwA8FBQMDwwJVTGdzBf6VB8IHNR08lld9uT4LCRA/qGNxvUwHNR08lld9uT4LCRA/qGNxvUwHNR08lld9uT4LCRA/qGNxvVJkAWUDDEf+tYP5AQAAAAEAAAAABiAGtgAbAAABBAADER4BFzMRITU2ADcWABcVIREzPgE3EQIAA4D+4v6FBwJ/X+D+1QYBJ97eAScG/tXgX38CB/6FBrUH/oX+4v32X38CAlWV3gEnBgb+2d6V/asCf18CCgEeAXsAAAAAEADGAAEAAAAAAAEABwAAAAEAAAAAAAIABwAHAAEAAAAAAAMABwAOAAEAAAAAAAQABwAVAAEAAAAAAAUACwAcAAEAAAAAAAYABwAnAAEAAAAAAAoAKwAuAAEAAAAAAAsAEwBZAAMAAQQJAAEADgBsAAMAAQQJAAIADgB6AAMAAQQJAAMADgCIAAMAAQQJAAQADgCWAAMAAQQJAAUAFgCkAAMAAQQJAAYADgC6AAMAAQQJAAoAVgDIAAMAAQQJAAsAJgEeVmlkZW9KU1JlZ3VsYXJWaWRlb0pTVmlkZW9KU1ZlcnNpb24gMS4wVmlkZW9KU0dlbmVyYXRlZCBieSBzdmcydHRmIGZyb20gRm9udGVsbG8gcHJvamVjdC5odHRwOi8vZm9udGVsbG8uY29tAFYAaQBkAGUAbwBKAFMAUgBlAGcAdQBsAGEAcgBWAGkAZABlAG8ASgBTAFYAaQBkAGUAbwBKAFMAVgBlAHIAcwBpAG8AbgAgADEALgAwAFYAaQBkAGUAbwBKAFMARwBlAG4AZQByAGEAdABlAGQAIABiAHkAIABzAHYAZwAyAHQAdABmACAAZgByAG8AbQAgAEYAbwBuAHQAZQBsAGwAbwAgAHAAcgBvAGoAZQBjAHQALgBoAHQAdABwADoALwAvAGYAbwBuAHQAZQBsAGwAbwAuAGMAbwBtAAAAAgAAAAAAAAARAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAfAAABAgEDAQQBBQEGAQcBCAEJAQoBCwEMAQ0BDgEPARABEQESARMBFAEVARYBFwEYARkBGgEbARwBHQEeAR8EcGxheQtwbGF5LWNpcmNsZQVwYXVzZQt2b2x1bWUtbXV0ZQp2b2x1bWUtbG93CnZvbHVtZS1taWQLdm9sdW1lLWhpZ2gQZnVsbHNjcmVlbi1lbnRlcg9mdWxsc2NyZWVuLWV4aXQGc3F1YXJlB3NwaW5uZXIJc3VidGl0bGVzCGNhcHRpb25zCGNoYXB0ZXJzBXNoYXJlA2NvZwZjaXJjbGUOY2lyY2xlLW91dGxpbmUTY2lyY2xlLWlubmVyLWNpcmNsZQJoZAZjYW5jZWwGcmVwbGF5CGZhY2Vib29rBWdwbHVzCGxpbmtlZGluB3R3aXR0ZXIGdHVtYmxyCXBpbnRlcmVzdBFhdWRpby1kZXNjcmlwdGlvbgVhdWRpbwAAAAAA) format("truetype");
  font-weight: normal;
  font-style: normal; }

.vjs-icon-play, .video-js .vjs-big-play-button, .video-js .vjs-play-control {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-play:before, .video-js .vjs-big-play-button:before, .video-js .vjs-play-control:before {
    content: "\f101"; }

.vjs-icon-play-circle {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-play-circle:before {
    content: "\f102"; }

.vjs-icon-pause, .video-js .vjs-play-control.vjs-playing {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-pause:before, .video-js .vjs-play-control.vjs-playing:before {
    content: "\f103"; }

.vjs-icon-volume-mute, .video-js .vjs-mute-control.vjs-vol-0,
.video-js .vjs-volume-menu-button.vjs-vol-0 {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-volume-mute:before, .video-js .vjs-mute-control.vjs-vol-0:before,
  .video-js .vjs-volume-menu-button.vjs-vol-0:before {
    content: "\f104"; }

.vjs-icon-volume-low, .video-js .vjs-mute-control.vjs-vol-1,
.video-js .vjs-volume-menu-button.vjs-vol-1 {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-volume-low:before, .video-js .vjs-mute-control.vjs-vol-1:before,
  .video-js .vjs-volume-menu-button.vjs-vol-1:before {
    content: "\f105"; }

.vjs-icon-volume-mid, .video-js .vjs-mute-control.vjs-vol-2,
.video-js .vjs-volume-menu-button.vjs-vol-2 {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-volume-mid:before, .video-js .vjs-mute-control.vjs-vol-2:before,
  .video-js .vjs-volume-menu-button.vjs-vol-2:before {
    content: "\f106"; }

.vjs-icon-volume-high, .video-js .vjs-mute-control,
.video-js .vjs-volume-menu-button {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-volume-high:before, .video-js .vjs-mute-control:before,
  .video-js .vjs-volume-menu-button:before {
    content: "\f107"; }

.vjs-icon-fullscreen-enter, .video-js .vjs-fullscreen-control {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-fullscreen-enter:before, .video-js .vjs-fullscreen-control:before {
    content: "\f108"; }

.vjs-icon-fullscreen-exit, .video-js.vjs-fullscreen .vjs-fullscreen-control {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-fullscreen-exit:before, .video-js.vjs-fullscreen .vjs-fullscreen-control:before {
    content: "\f109"; }

.vjs-icon-square {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-square:before {
    content: "\f10a"; }

.vjs-icon-spinner {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-spinner:before {
    content: "\f10b"; }

.vjs-icon-subtitles, .video-js .vjs-subtitles-button {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-subtitles:before, .video-js .vjs-subtitles-button:before {
    content: "\f10c"; }

.vjs-icon-captions, .video-js .vjs-captions-button {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-captions:before, .video-js .vjs-captions-button:before {
    content: "\f10d"; }

.vjs-icon-chapters, .video-js .vjs-chapters-button {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-chapters:before, .video-js .vjs-chapters-button:before {
    content: "\f10e"; }

.vjs-icon-share {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-share:before {
    content: "\f10f"; }

.vjs-icon-cog {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-cog:before {
    content: "\f110"; }

.vjs-icon-circle, .video-js .vjs-mouse-display, .video-js .vjs-play-progress, .video-js .vjs-volume-level {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-circle:before, .video-js .vjs-mouse-display:before, .video-js .vjs-play-progress:before, .video-js .vjs-volume-level:before {
    content: "\f111"; }

.vjs-icon-circle-outline {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-circle-outline:before {
    content: "\f112"; }

.vjs-icon-circle-inner-circle {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-circle-inner-circle:before {
    content: "\f113"; }

.vjs-icon-hd {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-hd:before {
    content: "\f114"; }

.vjs-icon-cancel, .video-js .vjs-control.vjs-close-button {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-cancel:before, .video-js .vjs-control.vjs-close-button:before {
    content: "\f115"; }

.vjs-icon-replay {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-replay:before {
    content: "\f116"; }

.vjs-icon-facebook {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-facebook:before {
    content: "\f117"; }

.vjs-icon-gplus {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-gplus:before {
    content: "\f118"; }

.vjs-icon-linkedin {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-linkedin:before {
    content: "\f119"; }

.vjs-icon-twitter {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-twitter:before {
    content: "\f11a"; }

.vjs-icon-tumblr {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-tumblr:before {
    content: "\f11b"; }

.vjs-icon-pinterest {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-pinterest:before {
    content: "\f11c"; }

.vjs-icon-audio-description, .video-js .vjs-descriptions-button {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-audio-description:before, .video-js .vjs-descriptions-button:before {
    content: "\f11d"; }

.vjs-icon-audio, .video-js .vjs-audio-button {
  font-family: VideoJS;
  font-weight: normal;
  font-style: normal; }
  .vjs-icon-audio:before, .video-js .vjs-audio-button:before {
    content: "\f11e"; }

.video-js {
  display: block;
  vertical-align: top;
  box-sizing: border-box;
  color: #fff;
  background-color: #000;
  position: relative;
  padding: 0;
  font-size: 10px;
  line-height: 1;
  font-weight: normal;
  font-style: normal;
  font-family: Arial, Helvetica, sans-serif; }
  .video-js:-moz-full-screen {
    position: absolute; }
  .video-js:-webkit-full-screen {
    width: 100% !important;
    height: 100% !important; }

.video-js *,
.video-js *:before,
.video-js *:after {
  box-sizing: inherit; }

.video-js ul {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
  list-style-position: outside;
  margin-left: 0;
  margin-right: 0;
  margin-top: 0;
  margin-bottom: 0; }

.video-js.vjs-fluid,
.video-js.vjs-16-9,
.video-js.vjs-4-3 {
  width: 100%;
  max-width: 100%;
  height: 0; }

.video-js.vjs-16-9 {
  padding-top: 56.25%; }

.video-js.vjs-4-3 {
  padding-top: 75%; }

.video-js.vjs-fill {
  width: 100%;
  height: 100%; }

.video-js .vjs-tech {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%; }

body.vjs-full-window {
  padding: 0;
  margin: 0;
  height: 100%;
  overflow-y: auto; }

.vjs-full-window .video-js.vjs-fullscreen {
  position: fixed;
  overflow: hidden;
  z-index: 1000;
  left: 0;
  top: 0;
  bottom: 0;
  right: 0; }

.video-js.vjs-fullscreen {
  width: 100% !important;
  height: 100% !important;
  padding-top: 0 !important; }

.video-js.vjs-fullscreen.vjs-user-inactive {
  cursor: none; }

.vjs-hidden {
  display: none !important; }

.vjs-disabled {
  opacity: 0.5;
  cursor: default; }

.video-js .vjs-offscreen {
  height: 1px;
  left: -9999px;
  position: absolute;
  top: 0;
  width: 1px; }

.vjs-lock-showing {
  display: block !important;
  opacity: 1;
  visibility: visible; }

.vjs-no-js {
  padding: 20px;
  color: #fff;
  background-color: #000;
  font-size: 18px;
  font-family: Arial, Helvetica, sans-serif;
  text-align: center;
  width: 300px;
  height: 150px;
  margin: 0px auto; }

.vjs-no-js a,
.vjs-no-js a:visited {
  color: #66A8CC; }

.video-js .vjs-big-play-button {
  font-size: 3em;
  line-height: 1.5em;
  height: 1.5em;
  width: 3em;
  display: block;
  position: absolute;
  top: 10px;
  left: 10px;
  padding: 0;
  cursor: pointer;
  opacity: 1;
  border: 0.06666em solid #fff;
  background-color: #2B333F;
  background-color: rgba(43, 51, 63, 0.7);
  -webkit-border-radius: 0.3em;
  -moz-border-radius: 0.3em;
  border-radius: 0.3em;
  -webkit-transition: all 0.4s;
  -moz-transition: all 0.4s;
  -o-transition: all 0.4s;
  transition: all 0.4s; }

.vjs-big-play-centered .vjs-big-play-button {
  top: 50%;
  left: 50%;
  margin-top: -0.75em;
  margin-left: -1.5em; }

.video-js:hover .vjs-big-play-button,
.video-js .vjs-big-play-button:focus {
  outline: 0;
  border-color: #fff;
  background-color: #73859f;
  background-color: rgba(115, 133, 159, 0.5);
  -webkit-transition: all 0s;
  -moz-transition: all 0s;
  -o-transition: all 0s;
  transition: all 0s; }

.vjs-controls-disabled .vjs-big-play-button,
.vjs-has-started .vjs-big-play-button,
.vjs-using-native-controls .vjs-big-play-button,
.vjs-error .vjs-big-play-button {
  display: none; }

.vjs-has-started.vjs-paused.vjs-show-big-play-button-on-pause .vjs-big-play-button {
  display: block; }

.video-js button {
  background: none;
  border: none;
  color: inherit;
  display: inline-block;
  overflow: visible;
  font-size: inherit;
  line-height: inherit;
  text-transform: none;
  text-decoration: none;
  transition: none;
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none; }

.video-js .vjs-control.vjs-close-button {
  cursor: pointer;
  height: 3em;
  position: absolute;
  right: 0;
  top: 0.5em;
  z-index: 2; }

.vjs-menu-button {
  cursor: pointer; }

.vjs-menu-button.vjs-disabled {
  cursor: default; }

.vjs-workinghover .vjs-menu-button.vjs-disabled:hover .vjs-menu {
  display: none; }

.vjs-menu .vjs-menu-content {
  display: block;
  padding: 0;
  margin: 0;
  overflow: auto;
  font-family: Arial, Helvetica, sans-serif; }

.vjs-scrubbing .vjs-menu-button:hover .vjs-menu {
  display: none; }

.vjs-menu li {
  list-style: none;
  margin: 0;
  padding: 0.2em 0;
  line-height: 1.4em;
  font-size: 1.2em;
  text-align: center;
  text-transform: lowercase; }

.vjs-menu li.vjs-menu-item:focus,
.vjs-menu li.vjs-menu-item:hover {
  outline: 0;
  background-color: #73859f;
  background-color: rgba(115, 133, 159, 0.5); }

.vjs-menu li.vjs-selected,
.vjs-menu li.vjs-selected:focus,
.vjs-menu li.vjs-selected:hover {
  background-color: #fff;
  color: #2B333F; }

.vjs-menu li.vjs-menu-title {
  text-align: center;
  text-transform: uppercase;
  font-size: 1em;
  line-height: 2em;
  padding: 0;
  margin: 0 0 0.3em 0;
  font-weight: bold;
  cursor: default; }

.vjs-menu-button-popup .vjs-menu {
  display: none;
  position: absolute;
  bottom: 0;
  width: 10em;
  left: -3em;
  height: 0em;
  margin-bottom: 1.5em;
  border-top-color: rgba(43, 51, 63, 0.7); }

.vjs-menu-button-popup .vjs-menu .vjs-menu-content {
  background-color: #2B333F;
  background-color: rgba(43, 51, 63, 0.7);
  position: absolute;
  width: 100%;
  bottom: 1.5em;
  max-height: 15em; }

.vjs-workinghover .vjs-menu-button-popup:hover .vjs-menu,
.vjs-menu-button-popup .vjs-menu.vjs-lock-showing {
  display: block; }

.video-js .vjs-menu-button-inline {
  -webkit-transition: all 0.4s;
  -moz-transition: all 0.4s;
  -o-transition: all 0.4s;
  transition: all 0.4s;
  overflow: hidden; }

.video-js .vjs-menu-button-inline:before {
  width: 2.222222222em; }

.video-js .vjs-menu-button-inline:hover,
.video-js .vjs-menu-button-inline:focus,
.video-js .vjs-menu-button-inline.vjs-slider-active,
.video-js.vjs-no-flex .vjs-menu-button-inline {
  width: 12em; }

.video-js .vjs-menu-button-inline.vjs-slider-active {
  -webkit-transition: none;
  -moz-transition: none;
  -o-transition: none;
  transition: none; }

.vjs-menu-button-inline .vjs-menu {
  opacity: 0;
  height: 100%;
  width: auto;
  position: absolute;
  left: 4em;
  top: 0;
  padding: 0;
  margin: 0;
  -webkit-transition: all 0.4s;
  -moz-transition: all 0.4s;
  -o-transition: all 0.4s;
  transition: all 0.4s; }

.vjs-menu-button-inline:hover .vjs-menu,
.vjs-menu-button-inline:focus .vjs-menu,
.vjs-menu-button-inline.vjs-slider-active .vjs-menu {
  display: block;
  opacity: 1; }

.vjs-no-flex .vjs-menu-button-inline .vjs-menu {
  display: block;
  opacity: 1;
  position: relative;
  width: auto; }

.vjs-no-flex .vjs-menu-button-inline:hover .vjs-menu,
.vjs-no-flex .vjs-menu-button-inline:focus .vjs-menu,
.vjs-no-flex .vjs-menu-button-inline.vjs-slider-active .vjs-menu {
  width: auto; }

.vjs-menu-button-inline .vjs-menu-content {
  width: auto;
  height: 100%;
  margin: 0;
  overflow: hidden; }

.video-js .vjs-control-bar {
  display: none;
  width: 100%;
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  height: 3.0em;
  background-color: #2B333F;
  background-color: rgba(43, 51, 63, 0.7); }

.vjs-has-started .vjs-control-bar {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  visibility: visible;
  opacity: 1;
  -webkit-transition: visibility 0.1s, opacity 0.1s;
  -moz-transition: visibility 0.1s, opacity 0.1s;
  -o-transition: visibility 0.1s, opacity 0.1s;
  transition: visibility 0.1s, opacity 0.1s; }

.vjs-has-started.vjs-user-inactive.vjs-playing .vjs-control-bar {
  visibility: visible;
  opacity: 0;
  -webkit-transition: visibility 1s, opacity 1s;
  -moz-transition: visibility 1s, opacity 1s;
  -o-transition: visibility 1s, opacity 1s;
  transition: visibility 1s, opacity 1s; }

.vjs-controls-disabled .vjs-control-bar,
.vjs-using-native-controls .vjs-control-bar,
.vjs-error .vjs-control-bar {
  display: none !important; }

.vjs-audio.vjs-has-started.vjs-user-inactive.vjs-playing .vjs-control-bar {
  opacity: 1;
  visibility: visible; }

.vjs-has-started.vjs-no-flex .vjs-control-bar {
  display: table; }

.video-js .vjs-control {
  outline: none;
  position: relative;
  text-align: center;
  margin: 0;
  padding: 0;
  height: 100%;
  width: 4em;
  -webkit-box-flex: none;
  -moz-box-flex: none;
  -webkit-flex: none;
  -ms-flex: none;
  flex: none; }
  .video-js .vjs-control:before {
    font-size: 1.8em;
    line-height: 1.67; }

.video-js .vjs-control:focus:before,
.video-js .vjs-control:hover:before,
.video-js .vjs-control:focus {
  text-shadow: 0em 0em 1em white; }

.video-js .vjs-control-text {
  border: 0;
  clip: rect(0 0 0 0);
  height: 1px;
  margin: -1px;
  overflow: hidden;
  padding: 0;
  position: absolute;
  width: 1px; }

.vjs-no-flex .vjs-control {
  display: table-cell;
  vertical-align: middle; }

.video-js .vjs-custom-control-spacer {
  display: none; }

.video-js .vjs-progress-control {
  -webkit-box-flex: auto;
  -moz-box-flex: auto;
  -webkit-flex: auto;
  -ms-flex: auto;
  flex: auto;
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: center;
  -webkit-align-items: center;
  -ms-flex-align: center;
  align-items: center;
  min-width: 4em; }

.vjs-live .vjs-progress-control {
  display: none; }

.video-js .vjs-progress-holder {
  -webkit-box-flex: auto;
  -moz-box-flex: auto;
  -webkit-flex: auto;
  -ms-flex: auto;
  flex: auto;
  -webkit-transition: all 0.2s;
  -moz-transition: all 0.2s;
  -o-transition: all 0.2s;
  transition: all 0.2s;
  height: 0.3em; }

.video-js .vjs-progress-control:hover .vjs-progress-holder {
  font-size: 1.666666666666666666em; }

/* If we let the font size grow as much as everything else, the current time tooltip ends up
 ginormous. If you'd like to enable the current time tooltip all the time, this should be disabled
 to avoid a weird hitch when you roll off the hover. */
.video-js .vjs-progress-control:hover .vjs-time-tooltip,
.video-js .vjs-progress-control:hover .vjs-mouse-display:after,
.video-js .vjs-progress-control:hover .vjs-play-progress:after {
  font-family: Arial, Helvetica, sans-serif;
  visibility: visible;
  font-size: 0.6em; }

.video-js .vjs-progress-holder .vjs-play-progress,
.video-js .vjs-progress-holder .vjs-load-progress,
.video-js .vjs-progress-holder .vjs-tooltip-progress-bar,
.video-js .vjs-progress-holder .vjs-load-progress div {
  position: absolute;
  display: block;
  height: 100%;
  margin: 0;
  padding: 0;
  width: 0;
  left: 0;
  top: 0; }

.video-js .vjs-mouse-display:before {
  display: none; }

.video-js .vjs-play-progress {
  background-color: #fff; }
  .video-js .vjs-play-progress:before {
    position: absolute;
    top: -0.333333333333333em;
    right: -0.5em;
    font-size: 0.9em; }

.video-js .vjs-time-tooltip,
.video-js .vjs-mouse-display:after,
.video-js .vjs-play-progress:after {
  visibility: hidden;
  pointer-events: none;
  position: absolute;
  top: -3.4em;
  right: -1.9em;
  font-size: 0.9em;
  color: #000;
  content: attr(data-current-time);
  padding: 6px 8px 8px 8px;
  background-color: #fff;
  background-color: rgba(255, 255, 255, 0.8);
  -webkit-border-radius: 0.3em;
  -moz-border-radius: 0.3em;
  border-radius: 0.3em; }

.video-js .vjs-time-tooltip,
.video-js .vjs-play-progress:before,
.video-js .vjs-play-progress:after {
  z-index: 1; }

.video-js .vjs-progress-control .vjs-keep-tooltips-inside:after {
  display: none; }

.video-js .vjs-load-progress {
  background: #bfc7d3;
  background: rgba(115, 133, 159, 0.5); }

.video-js .vjs-load-progress div {
  background: white;
  background: rgba(115, 133, 159, 0.75); }

.video-js.vjs-no-flex .vjs-progress-control {
  width: auto; }

.video-js .vjs-time-tooltip {
  display: inline-block;
  height: 2.4em;
  position: relative;
  float: right;
  right: -1.9em; }

.vjs-tooltip-progress-bar {
  visibility: hidden; }

.video-js .vjs-progress-control .vjs-mouse-display {
  display: none;
  position: absolute;
  width: 1px;
  height: 100%;
  background-color: #000;
  z-index: 1; }

.vjs-no-flex .vjs-progress-control .vjs-mouse-display {
  z-index: 0; }

.video-js .vjs-progress-control:hover .vjs-mouse-display {
  display: block; }

.video-js.vjs-user-inactive .vjs-progress-control .vjs-mouse-display,
.video-js.vjs-user-inactive .vjs-progress-control .vjs-mouse-display:after {
  visibility: hidden;
  opacity: 0;
  -webkit-transition: visibility 1s, opacity 1s;
  -moz-transition: visibility 1s, opacity 1s;
  -o-transition: visibility 1s, opacity 1s;
  transition: visibility 1s, opacity 1s; }

.video-js.vjs-user-inactive.vjs-no-flex .vjs-progress-control .vjs-mouse-display,
.video-js.vjs-user-inactive.vjs-no-flex .vjs-progress-control .vjs-mouse-display:after {
  display: none; }

.vjs-mouse-display .vjs-time-tooltip,
.video-js .vjs-progress-control .vjs-mouse-display:after {
  color: #fff;
  background-color: #000;
  background-color: rgba(0, 0, 0, 0.8); }

.video-js .vjs-slider {
  outline: 0;
  position: relative;
  cursor: pointer;
  padding: 0;
  margin: 0 0.45em 0 0.45em;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  background-color: #73859f;
  background-color: rgba(115, 133, 159, 0.5); }

.video-js .vjs-slider:focus {
  text-shadow: 0em 0em 1em white;
  -webkit-box-shadow: 0 0 1em #fff;
  -moz-box-shadow: 0 0 1em #fff;
  box-shadow: 0 0 1em #fff; }

.video-js .vjs-mute-control,
.video-js .vjs-volume-menu-button {
  cursor: pointer;
  -webkit-box-flex: none;
  -moz-box-flex: none;
  -webkit-flex: none;
  -ms-flex: none;
  flex: none; }

.video-js .vjs-volume-control {
  width: 5em;
  -webkit-box-flex: none;
  -moz-box-flex: none;
  -webkit-flex: none;
  -ms-flex: none;
  flex: none;
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: center;
  -webkit-align-items: center;
  -ms-flex-align: center;
  align-items: center; }

.video-js .vjs-volume-bar {
  margin: 1.35em 0.45em; }

.vjs-volume-bar.vjs-slider-horizontal {
  width: 5em;
  height: 0.3em; }

.vjs-volume-bar.vjs-slider-vertical {
  width: 0.3em;
  height: 5em;
  margin: 1.35em auto; }

.video-js .vjs-volume-level {
  position: absolute;
  bottom: 0;
  left: 0;
  background-color: #fff; }
  .video-js .vjs-volume-level:before {
    position: absolute;
    font-size: 0.9em; }

.vjs-slider-vertical .vjs-volume-level {
  width: 0.3em; }
  .vjs-slider-vertical .vjs-volume-level:before {
    top: -0.5em;
    left: -0.3em; }

.vjs-slider-horizontal .vjs-volume-level {
  height: 0.3em; }
  .vjs-slider-horizontal .vjs-volume-level:before {
    top: -0.3em;
    right: -0.5em; }

.vjs-volume-bar.vjs-slider-vertical .vjs-volume-level {
  height: 100%; }

.vjs-volume-bar.vjs-slider-horizontal .vjs-volume-level {
  width: 100%; }

.vjs-menu-button-popup.vjs-volume-menu-button .vjs-menu {
  display: block;
  width: 0;
  height: 0;
  border-top-color: transparent; }

.vjs-menu-button-popup.vjs-volume-menu-button-vertical .vjs-menu {
  left: 0.5em;
  height: 8em; }

.vjs-menu-button-popup.vjs-volume-menu-button-horizontal .vjs-menu {
  left: -2em; }

.vjs-menu-button-popup.vjs-volume-menu-button .vjs-menu-content {
  height: 0;
  width: 0;
  overflow-x: hidden;
  overflow-y: hidden; }

.vjs-volume-menu-button-vertical:hover .vjs-menu-content,
.vjs-volume-menu-button-vertical:focus .vjs-menu-content,
.vjs-volume-menu-button-vertical.vjs-slider-active .vjs-menu-content,
.vjs-volume-menu-button-vertical .vjs-lock-showing .vjs-menu-content {
  height: 8em;
  width: 2.9em; }

.vjs-volume-menu-button-horizontal:hover .vjs-menu-content,
.vjs-volume-menu-button-horizontal:focus .vjs-menu-content,
.vjs-volume-menu-button-horizontal .vjs-slider-active .vjs-menu-content,
.vjs-volume-menu-button-horizontal .vjs-lock-showing .vjs-menu-content {
  height: 2.9em;
  width: 8em; }

.vjs-volume-menu-button.vjs-menu-button-inline .vjs-menu-content {
  background-color: transparent !important; }

.vjs-poster {
  display: inline-block;
  vertical-align: middle;
  background-repeat: no-repeat;
  background-position: 50% 50%;
  background-size: contain;
  background-color: #000000;
  cursor: pointer;
  margin: 0;
  padding: 0;
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  height: 100%; }

.vjs-poster img {
  display: block;
  vertical-align: middle;
  margin: 0 auto;
  max-height: 100%;
  padding: 0;
  width: 100%; }

.vjs-has-started .vjs-poster {
  display: none; }

.vjs-audio.vjs-has-started .vjs-poster {
  display: block; }

.vjs-using-native-controls .vjs-poster {
  display: none; }

.video-js .vjs-live-control {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-align: flex-start;
  -webkit-align-items: flex-start;
  -ms-flex-align: flex-start;
  align-items: flex-start;
  -webkit-box-flex: auto;
  -moz-box-flex: auto;
  -webkit-flex: auto;
  -ms-flex: auto;
  flex: auto;
  font-size: 1em;
  line-height: 3em; }

.vjs-no-flex .vjs-live-control {
  display: table-cell;
  width: auto;
  text-align: left; }

.video-js .vjs-time-control {
  -webkit-box-flex: none;
  -moz-box-flex: none;
  -webkit-flex: none;
  -ms-flex: none;
  flex: none;
  font-size: 1em;
  line-height: 3em;
  min-width: 2em;
  width: auto;
  padding-left: 1em;
  padding-right: 1em; }

.vjs-live .vjs-time-control {
  display: none; }

.video-js .vjs-current-time,
.vjs-no-flex .vjs-current-time {
  display: none; }

.video-js .vjs-duration,
.vjs-no-flex .vjs-duration {
  display: none; }

.vjs-time-divider {
  display: none;
  line-height: 3em; }

.vjs-live .vjs-time-divider {
  display: none; }

.video-js .vjs-play-control {
  cursor: pointer;
  -webkit-box-flex: none;
  -moz-box-flex: none;
  -webkit-flex: none;
  -ms-flex: none;
  flex: none; }

.vjs-text-track-display {
  position: absolute;
  bottom: 3em;
  left: 0;
  right: 0;
  top: 0;
  pointer-events: none; }

.video-js.vjs-user-inactive.vjs-playing .vjs-text-track-display {
  bottom: 1em; }

.video-js .vjs-text-track {
  font-size: 1.4em;
  text-align: center;
  margin-bottom: 0.1em;
  background-color: #000;
  background-color: rgba(0, 0, 0, 0.5); }

.vjs-subtitles {
  color: #fff; }

.vjs-captions {
  color: #fc6; }

.vjs-tt-cue {
  display: block; }

video::-webkit-media-text-track-display {
  -moz-transform: translateY(-3em);
  -ms-transform: translateY(-3em);
  -o-transform: translateY(-3em);
  -webkit-transform: translateY(-3em);
  transform: translateY(-3em); }

.video-js.vjs-user-inactive.vjs-playing video::-webkit-media-text-track-display {
  -moz-transform: translateY(-1.5em);
  -ms-transform: translateY(-1.5em);
  -o-transform: translateY(-1.5em);
  -webkit-transform: translateY(-1.5em);
  transform: translateY(-1.5em); }

.video-js .vjs-fullscreen-control {
  cursor: pointer;
  -webkit-box-flex: none;
  -moz-box-flex: none;
  -webkit-flex: none;
  -ms-flex: none;
  flex: none; }

.vjs-playback-rate .vjs-playback-rate-value {
  font-size: 1.5em;
  line-height: 2;
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  text-align: center; }

.vjs-playback-rate .vjs-menu {
  width: 4em;
  left: 0em; }

.vjs-error .vjs-error-display .vjs-modal-dialog-content {
  font-size: 1.4em;
  text-align: center; }

.vjs-error .vjs-error-display:before {
  color: #fff;
  content: 'X';
  font-family: Arial, Helvetica, sans-serif;
  font-size: 4em;
  left: 0;
  line-height: 1;
  margin-top: -0.5em;
  position: absolute;
  text-shadow: 0.05em 0.05em 0.1em #000;
  text-align: center;
  top: 50%;
  vertical-align: middle;
  width: 100%; }

.vjs-loading-spinner {
  display: none;
  position: absolute;
  top: 50%;
  left: 50%;
  margin: -25px 0 0 -25px;
  opacity: 0.85;
  text-align: left;
  border: 6px solid rgba(43, 51, 63, 0.7);
  box-sizing: border-box;
  background-clip: padding-box;
  width: 50px;
  height: 50px;
  border-radius: 25px; }

.vjs-seeking .vjs-loading-spinner,
.vjs-waiting .vjs-loading-spinner {
  display: block; }

.vjs-loading-spinner:before,
.vjs-loading-spinner:after {
  content: "";
  position: absolute;
  margin: -6px;
  box-sizing: inherit;
  width: inherit;
  height: inherit;
  border-radius: inherit;
  opacity: 1;
  border: inherit;
  border-color: transparent;
  border-top-color: white; }

.vjs-seeking .vjs-loading-spinner:before,
.vjs-seeking .vjs-loading-spinner:after,
.vjs-waiting .vjs-loading-spinner:before,
.vjs-waiting .vjs-loading-spinner:after {
  -webkit-animation: vjs-spinner-spin 1.1s cubic-bezier(0.6, 0.2, 0, 0.8) infinite, vjs-spinner-fade 1.1s linear infinite;
  animation: vjs-spinner-spin 1.1s cubic-bezier(0.6, 0.2, 0, 0.8) infinite, vjs-spinner-fade 1.1s linear infinite; }

.vjs-seeking .vjs-loading-spinner:before,
.vjs-waiting .vjs-loading-spinner:before {
  border-top-color: white; }

.vjs-seeking .vjs-loading-spinner:after,
.vjs-waiting .vjs-loading-spinner:after {
  border-top-color: white;
  -webkit-animation-delay: 0.44s;
  animation-delay: 0.44s; }

@keyframes vjs-spinner-spin {
  100% {
    transform: rotate(360deg); } }

@-webkit-keyframes vjs-spinner-spin {
  100% {
    -webkit-transform: rotate(360deg); } }

@keyframes vjs-spinner-fade {
  0% {
    border-top-color: #73859f; }
  20% {
    border-top-color: #73859f; }
  35% {
    border-top-color: white; }
  60% {
    border-top-color: #73859f; }
  100% {
    border-top-color: #73859f; } }

@-webkit-keyframes vjs-spinner-fade {
  0% {
    border-top-color: #73859f; }
  20% {
    border-top-color: #73859f; }
  35% {
    border-top-color: white; }
  60% {
    border-top-color: #73859f; }
  100% {
    border-top-color: #73859f; } }

.vjs-chapters-button .vjs-menu ul {
  width: 24em; }

.video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-custom-control-spacer {
  -webkit-box-flex: auto;
  -moz-box-flex: auto;
  -webkit-flex: auto;
  -ms-flex: auto;
  flex: auto; }

.video-js.vjs-layout-tiny:not(.vjs-fullscreen).vjs-no-flex .vjs-custom-control-spacer {
  width: auto; }

.video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-current-time, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-time-divider, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-duration, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-remaining-time,
.video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-playback-rate, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-progress-control,
.video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-mute-control, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-volume-control, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-volume-menu-button,
.video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-chapters-button, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-descriptions-button, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-captions-button,
.video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-subtitles-button, .video-js.vjs-layout-tiny:not(.vjs-fullscreen) .vjs-audio-button {
  display: none; }

.video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-current-time, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-time-divider, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-duration, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-remaining-time,
.video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-playback-rate,
.video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-mute-control, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-volume-control, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-volume-menu-button,
.video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-chapters-button, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-descriptions-button, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-captions-button,
.video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-subtitles-button, .video-js.vjs-layout-x-small:not(.vjs-fullscreen) .vjs-audio-button {
  display: none; }

.video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-current-time, .video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-time-divider, .video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-duration, .video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-remaining-time,
.video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-playback-rate,
.video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-mute-control, .video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-volume-control,
.video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-chapters-button, .video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-descriptions-button, .video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-captions-button,
.video-js.vjs-layout-small:not(.vjs-fullscreen) .vjs-subtitles-button .vjs-audio-button {
  display: none; }

.vjs-caption-settings {
  position: relative;
  top: 1em;
  background-color: #2B333F;
  background-color: rgba(43, 51, 63, 0.75);
  color: #fff;
  margin: 0 auto;
  padding: 0.5em;
  height: 16em;
  font-size: 12px;
  width: 40em; }

.vjs-caption-settings .vjs-tracksettings {
  top: 0;
  bottom: 1em;
  left: 0;
  right: 0;
  position: absolute;
  overflow: auto; }

.vjs-caption-settings .vjs-tracksettings-colors,
.vjs-caption-settings .vjs-tracksettings-font {
  float: left; }

.vjs-caption-settings .vjs-tracksettings-colors:after,
.vjs-caption-settings .vjs-tracksettings-font:after,
.vjs-caption-settings .vjs-tracksettings-controls:after {
  clear: both; }

.vjs-caption-settings .vjs-tracksettings-controls {
  position: absolute;
  bottom: 1em;
  right: 1em; }

.vjs-caption-settings .vjs-tracksetting {
  margin: 5px;
  padding: 3px;
  min-height: 40px;
  border: none; }

.vjs-caption-settings .vjs-tracksetting label,
.vjs-caption-settings .vjs-tracksetting legend {
  display: block;
  width: 100px;
  margin-bottom: 5px; }

.vjs-caption-settings .vjs-tracksetting span {
  display: inline;
  margin-left: 5px;
  vertical-align: top;
  float: right; }

.vjs-caption-settings .vjs-tracksetting > div {
  margin-bottom: 5px;
  min-height: 20px; }

.vjs-caption-settings .vjs-tracksetting > div:last-child {
  margin-bottom: 0;
  padding-bottom: 0;
  min-height: 0; }

.vjs-caption-settings label > input {
  margin-right: 10px; }

.vjs-caption-settings fieldset {
  margin-top: 1em;
  margin-left: .5em; }

.vjs-caption-settings fieldset .vjs-label {
  position: absolute;
  clip: rect(1px 1px 1px 1px);
  /* for Internet Explorer */
  clip: rect(1px, 1px, 1px, 1px);
  padding: 0;
  border: 0;
  height: 1px;
  width: 1px;
  overflow: hidden; }

.vjs-caption-settings input[type="button"] {
  width: 40px;
  height: 40px; }

.video-js .vjs-modal-dialog {
  background: rgba(0, 0, 0, 0.8);
  background: -webkit-linear-gradient(-90deg, rgba(0, 0, 0, 0.8), rgba(255, 255, 255, 0));
  background: linear-gradient(180deg, rgba(0, 0, 0, 0.8), rgba(255, 255, 255, 0)); }

.vjs-modal-dialog .vjs-modal-dialog-content {
  font-size: 1.2em;
  line-height: 1.5;
  padding: 20px 24px;
  z-index: 1; }

@media print {
  .video-js > *:not(.vjs-tech):not(.vjs-poster) {
    visibility: hidden; } }

@media \0screen {
  .vjs-user-inactive.vjs-playing .vjs-control-bar :before {
    content: "";
  }
}

@media \0screen {
  .vjs-has-started.vjs-user-inactive.vjs-playing .vjs-control-bar {
    visibility: hidden;
  }
}

.mCustomScrollbar{-ms-touch-action:pinch-zoom;touch-action:pinch-zoom}.mCustomScrollbar.mCS_no_scrollbar,.mCustomScrollbar.mCS_touch_action{-ms-touch-action:auto;touch-action:auto}.mCustomScrollBox{position:relative;overflow:hidden;height:100%;max-width:100%;outline:0;direction:ltr}.mCSB_container{overflow:hidden;width:auto;height:auto}.mCSB_inside>.mCSB_container{margin-right:30px}.mCSB_container.mCS_no_scrollbar_y.mCS_y_hidden{margin-right:0}.mCS-dir-rtl>.mCSB_inside>.mCSB_container{margin-right:0;margin-left:30px}.mCS-dir-rtl>.mCSB_inside>.mCSB_container.mCS_no_scrollbar_y.mCS_y_hidden{margin-left:0}.mCSB_scrollTools{position:absolute;width:16px;height:auto;left:auto;top:0;right:0;bottom:0;opacity:.75;filter:"alpha(opacity=75)";-ms-filter:"alpha(opacity=75)"}.mCSB_outside+.mCSB_scrollTools{right:-26px}.mCS-dir-rtl>.mCSB_inside>.mCSB_scrollTools,.mCS-dir-rtl>.mCSB_outside+.mCSB_scrollTools{right:auto;left:0}.mCS-dir-rtl>.mCSB_outside+.mCSB_scrollTools{left:-26px}.mCSB_scrollTools .mCSB_draggerContainer{position:absolute;top:0;left:0;bottom:0;right:0;height:auto}.mCSB_scrollTools a+.mCSB_draggerContainer{margin:20px 0}.mCSB_scrollTools .mCSB_draggerRail{width:2px;height:100%;margin:0 auto;-webkit-border-radius:16px;-moz-border-radius:16px;border-radius:16px}.mCSB_scrollTools .mCSB_dragger{cursor:pointer;width:100%;height:30px;z-index:1}.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{position:relative;width:4px;height:100%;margin:0 auto;-webkit-border-radius:16px;-moz-border-radius:16px;border-radius:16px;text-align:center}.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{width:12px}.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{width:8px}.mCSB_scrollTools .mCSB_buttonDown,.mCSB_scrollTools .mCSB_buttonUp{display:block;position:absolute;height:20px;width:100%;overflow:hidden;margin:0 auto;cursor:pointer}.mCSB_scrollTools .mCSB_buttonDown{bottom:0}.mCSB_horizontal.mCSB_inside>.mCSB_container{margin-right:0;margin-bottom:30px}.mCSB_horizontal.mCSB_outside>.mCSB_container{min-height:100%}.mCSB_horizontal>.mCSB_container.mCS_no_scrollbar_x.mCS_x_hidden{margin-bottom:0}.mCSB_scrollTools.mCSB_scrollTools_horizontal{width:auto;height:16px;top:auto;right:0;bottom:0;left:0}.mCustomScrollBox+.mCSB_scrollTools+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox+.mCSB_scrollTools.mCSB_scrollTools_horizontal{bottom:-26px}.mCSB_scrollTools.mCSB_scrollTools_horizontal a+.mCSB_draggerContainer{margin:0 20px}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:2px;margin:7px 0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_dragger{width:30px;height:100%;left:0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:4px;margin:6px auto}.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{height:12px;margin:2px auto}.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{height:8px;margin:4px 0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonLeft,.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonRight{display:block;position:absolute;width:20px;height:100%;overflow:hidden;margin:0 auto;cursor:pointer}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonLeft{left:0}.mCSB_scrollTools.mCSB_scrollTools_horizontal .mCSB_buttonRight{right:0}.mCSB_container_wrapper{position:absolute;height:auto;width:auto;overflow:hidden;top:0;left:0;right:0;bottom:0;margin-right:30px;margin-bottom:30px}.mCSB_container_wrapper>.mCSB_container{padding-right:30px;padding-bottom:30px;-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}.mCSB_vertical_horizontal>.mCSB_scrollTools.mCSB_scrollTools_vertical{bottom:20px}.mCSB_vertical_horizontal>.mCSB_scrollTools.mCSB_scrollTools_horizontal{right:20px}.mCSB_container_wrapper.mCS_no_scrollbar_x.mCS_x_hidden+.mCSB_scrollTools.mCSB_scrollTools_vertical{bottom:0}.mCS-dir-rtl>.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden+.mCSB_scrollTools~.mCSB_scrollTools.mCSB_scrollTools_horizontal{right:0}.mCS-dir-rtl>.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_scrollTools.mCSB_scrollTools_horizontal{left:20px}.mCS-dir-rtl>.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden+.mCSB_scrollTools~.mCSB_scrollTools.mCSB_scrollTools_horizontal{left:0}.mCS-dir-rtl>.mCSB_inside>.mCSB_container_wrapper{margin-right:0;margin-left:30px}.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden>.mCSB_container{padding-right:0}.mCSB_container_wrapper.mCS_no_scrollbar_x.mCS_x_hidden>.mCSB_container{padding-bottom:0}.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_container_wrapper.mCS_no_scrollbar_y.mCS_y_hidden{margin-right:0;margin-left:0}.mCustomScrollBox.mCSB_vertical_horizontal.mCSB_inside>.mCSB_container_wrapper.mCS_no_scrollbar_x.mCS_x_hidden{margin-bottom:0}.mCSB_scrollTools,.mCSB_scrollTools .mCSB_buttonDown,.mCSB_scrollTools .mCSB_buttonLeft,.mCSB_scrollTools .mCSB_buttonRight,.mCSB_scrollTools .mCSB_buttonUp,.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{-webkit-transition:opacity .2s ease-in-out,background-color .2s ease-in-out;-moz-transition:opacity .2s ease-in-out,background-color .2s ease-in-out;-o-transition:opacity .2s ease-in-out,background-color .2s ease-in-out;transition:opacity .2s ease-in-out,background-color .2s ease-in-out}.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerRail,.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger_bar,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerRail,.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger_bar{-webkit-transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out;-moz-transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out;-o-transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out;transition:width .2s ease-out .2s,height .2s ease-out .2s,margin-left .2s ease-out .2s,margin-right .2s ease-out .2s,margin-top .2s ease-out .2s,margin-bottom .2s ease-out .2s,opacity .2s ease-in-out,background-color .2s ease-in-out}.mCS-autoHide>.mCustomScrollBox>.mCSB_scrollTools,.mCS-autoHide>.mCustomScrollBox~.mCSB_scrollTools{opacity:0;filter:"alpha(opacity=0)";-ms-filter:"alpha(opacity=0)"}.mCS-autoHide:hover>.mCustomScrollBox>.mCSB_scrollTools,.mCS-autoHide:hover>.mCustomScrollBox~.mCSB_scrollTools,.mCustomScrollBox:hover>.mCSB_scrollTools,.mCustomScrollBox:hover~.mCSB_scrollTools,.mCustomScrollbar>.mCustomScrollBox>.mCSB_scrollTools.mCSB_scrollTools_onDrag,.mCustomScrollbar>.mCustomScrollBox~.mCSB_scrollTools.mCSB_scrollTools_onDrag{opacity:1;filter:"alpha(opacity=100)";-ms-filter:"alpha(opacity=100)"}.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.4);filter:"alpha(opacity=40)";-ms-filter:"alpha(opacity=40)"}.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.75);filter:"alpha(opacity=75)";-ms-filter:"alpha(opacity=75)"}.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85);filter:"alpha(opacity=85)";-ms-filter:"alpha(opacity=85)"}.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9);filter:"alpha(opacity=90)";-ms-filter:"alpha(opacity=90)"}.mCSB_scrollTools .mCSB_buttonDown,.mCSB_scrollTools .mCSB_buttonLeft,.mCSB_scrollTools .mCSB_buttonRight,.mCSB_scrollTools .mCSB_buttonUp{background-image:url(mCSB_buttons.png);background-repeat:no-repeat;opacity:.4;filter:"alpha(opacity=40)";-ms-filter:"alpha(opacity=40)"}.mCSB_scrollTools .mCSB_buttonUp{background-position:0 0}.mCSB_scrollTools .mCSB_buttonDown{background-position:0 -20px}.mCSB_scrollTools .mCSB_buttonLeft{background-position:0 -40px}.mCSB_scrollTools .mCSB_buttonRight{background-position:0 -56px}.mCSB_scrollTools .mCSB_buttonDown:hover,.mCSB_scrollTools .mCSB_buttonLeft:hover,.mCSB_scrollTools .mCSB_buttonRight:hover,.mCSB_scrollTools .mCSB_buttonUp:hover{opacity:.75;filter:"alpha(opacity=75)";-ms-filter:"alpha(opacity=75)"}.mCSB_scrollTools .mCSB_buttonDown:active,.mCSB_scrollTools .mCSB_buttonLeft:active,.mCSB_scrollTools .mCSB_buttonRight:active,.mCSB_scrollTools .mCSB_buttonUp:active{opacity:.9;filter:"alpha(opacity=90)";-ms-filter:"alpha(opacity=90)"}.mCS-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.15)}.mCS-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:rgba(0,0,0,.85)}.mCS-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:rgba(0,0,0,.9)}.mCS-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-80px 0}.mCS-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-80px -20px}.mCS-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-80px -40px}.mCS-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-80px -56px}.mCS-dark-2.mCSB_scrollTools .mCSB_draggerRail,.mCS-light-2.mCSB_scrollTools .mCSB_draggerRail{width:4px;background-color:#fff;background-color:rgba(255,255,255,.1);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:4px;background-color:#fff;background-color:rgba(255,255,255,.75);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-dark-2.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-2.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-2.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:4px;margin:6px auto}.mCS-light-2.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85)}.mCS-light-2.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-light-2.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9)}.mCS-light-2.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px 0}.mCS-light-2.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -20px}.mCS-light-2.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -40px}.mCS-light-2.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -56px}.mCS-dark-2.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75);-webkit-border-radius:1px;-moz-border-radius:1px;border-radius:1px}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-2.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-2.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px 0}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -20px}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -40px}.mCS-dark-2.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -56px}.mCS-dark-thick.mCSB_scrollTools .mCSB_draggerRail,.mCS-light-thick.mCSB_scrollTools .mCSB_draggerRail{width:4px;background-color:#fff;background-color:rgba(255,255,255,.1);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:6px;background-color:#fff;background-color:rgba(255,255,255,.75);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-thick.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:4px;margin:6px 0}.mCS-dark-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:6px;margin:5px auto}.mCS-light-thick.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85)}.mCS-light-thick.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-light-thick.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9)}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonUp{background-position:-16px 0}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonDown{background-position:-16px -20px}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonLeft{background-position:-20px -40px}.mCS-light-thick.mCSB_scrollTools .mCSB_buttonRight{background-position:-20px -56px}.mCS-dark-thick.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75);-webkit-border-radius:2px;-moz-border-radius:2px;border-radius:2px}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-thick.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonUp{background-position:-96px 0}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonDown{background-position:-96px -20px}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonLeft{background-position:-100px -40px}.mCS-dark-thick.mCSB_scrollTools .mCSB_buttonRight{background-position:-100px -56px}.mCS-light-thin.mCSB_scrollTools .mCSB_draggerRail{background-color:#fff;background-color:rgba(255,255,255,.1)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thin.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:2px}.mCS-dark-thin.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-thin.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%}.mCS-dark-thin.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-thin.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:2px;margin:7px auto}.mCS-dark-thin.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.15)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-thin.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonUp{background-position:-80px 0}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonDown{background-position:-80px -20px}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonLeft{background-position:-80px -40px}.mCS-dark-thin.mCSB_scrollTools .mCSB_buttonRight{background-position:-80px -56px}.mCS-rounded.mCSB_scrollTools .mCSB_draggerRail{background-color:#fff;background-color:rgba(255,255,255,.15)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger,.mCS-rounded-dots.mCSB_scrollTools .mCSB_dragger,.mCS-rounded.mCSB_scrollTools .mCSB_dragger{height:14px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:14px;margin:0 1px}.mCS-rounded-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-rounded.mCSB_scrollTools_horizontal .mCSB_dragger{width:14px}.mCS-rounded-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{height:14px;margin:1px 0}.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{width:16px;height:16px;margin:-1px 0}.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded-dark.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{width:4px}.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded .mCSB_dragger_bar,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_dragger .mCSB_dragger_bar{height:16px;width:16px;margin:0 -1px}.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded-dark.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-rounded.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{height:4px;margin:6px 0}.mCS-rounded.mCSB_scrollTools .mCSB_buttonUp{background-position:0 -72px}.mCS-rounded.mCSB_scrollTools .mCSB_buttonDown{background-position:0 -92px}.mCS-rounded.mCSB_scrollTools .mCSB_buttonLeft{background-position:0 -112px}.mCS-rounded.mCSB_scrollTools .mCSB_buttonRight{background-position:0 -128px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.15)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-rounded-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-80px -72px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-80px -92px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-80px -112px}.mCS-rounded-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-80px -128px}.mCS-rounded-dots-dark.mCSB_scrollTools_vertical .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools_vertical .mCSB_draggerRail{width:4px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_draggerRail{background-color:transparent;background-position:center}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools .mCSB_draggerRail{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAANElEQVQYV2NkIAAYiVbw//9/Y6DiM1ANJoyMjGdBbLgJQAX/kU0DKgDLkaQAvxW4HEvQFwCRcxIJK1XznAAAAABJRU5ErkJggg==);background-repeat:repeat-y;opacity:.3;filter:"alpha(opacity=30)";-ms-filter:"alpha(opacity=30)"}.mCS-rounded-dots-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-rounded-dots.mCSB_scrollTools_horizontal .mCSB_draggerRail{height:4px;margin:6px 0;background-repeat:repeat-x}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonUp{background-position:-16px -72px}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonDown{background-position:-16px -92px}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonLeft{background-position:-20px -112px}.mCS-rounded-dots.mCSB_scrollTools .mCSB_buttonRight{background-position:-20px -128px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_draggerRail{background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAALElEQVQYV2NkIAAYSVFgDFR8BqrBBEifBbGRTfiPZhpYjiQFBK3A6l6CvgAAE9kGCd1mvgEAAAAASUVORK5CYII=)}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-96px -72px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-96px -92px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-100px -112px}.mCS-rounded-dots-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-100px -128px}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-repeat:repeat-y;background-image:-moz-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-webkit-gradient(linear,left top,right top,color-stop(0,rgba(255,255,255,.5)),color-stop(100%,rgba(255,255,255,0)));background-image:-webkit-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-o-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-ms-linear-gradient(left,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:linear-gradient(to right,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%)}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{background-repeat:repeat-x;background-image:-moz-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-webkit-gradient(linear,left top,left bottom,color-stop(0,rgba(255,255,255,.5)),color-stop(100%,rgba(255,255,255,0)));background-image:-webkit-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-o-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:-ms-linear-gradient(top,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%);background-image:linear-gradient(to bottom,rgba(255,255,255,.5) 0,rgba(255,255,255,0) 100%)}.mCS-3d-dark.mCSB_scrollTools_vertical .mCSB_dragger,.mCS-3d.mCSB_scrollTools_vertical .mCSB_dragger{height:70px}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_dragger{width:70px}.mCS-3d-dark.mCSB_scrollTools,.mCS-3d.mCSB_scrollTools{opacity:1;filter:"alpha(opacity=30)";-ms-filter:"alpha(opacity=30)"}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_draggerRail{-webkit-border-radius:16px;-moz-border-radius:16px;border-radius:16px}.mCS-3d-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-3d.mCSB_scrollTools .mCSB_draggerRail{width:8px;background-color:#000;background-color:rgba(0,0,0,.2);box-shadow:inset 1px 0 1px rgba(0,0,0,.5),inset -1px 0 1px rgba(255,255,255,.2)}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#555}.mCS-3d-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:8px}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:8px;margin:4px 0;box-shadow:inset 0 1px 1px rgba(0,0,0,.5),inset 0 -1px 1px rgba(255,255,255,.2)}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{width:100%;height:8px;margin:4px auto}.mCS-3d.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-3d.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-3d.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-3d.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-3d-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1);box-shadow:inset 1px 0 1px rgba(0,0,0,.1)}.mCS-3d-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail{box-shadow:inset 0 1px 1px rgba(0,0,0,.1)}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-3d-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCS-3d-thick-dark.mCSB_scrollTools,.mCS-3d-thick.mCSB_scrollTools{opacity:1;filter:"alpha(opacity=30)";-ms-filter:"alpha(opacity=30)"}.mCS-3d-thick-dark.mCSB_scrollTools,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_draggerContainer,.mCS-3d-thick.mCSB_scrollTools,.mCS-3d-thick.mCSB_scrollTools .mCSB_draggerContainer{-webkit-border-radius:7px;-moz-border-radius:7px;border-radius:7px}.mCSB_inside+.mCS-3d-thick-dark.mCSB_scrollTools_vertical,.mCSB_inside+.mCS-3d-thick.mCSB_scrollTools_vertical{right:1px}.mCS-3d-thick-dark.mCSB_scrollTools_vertical,.mCS-3d-thick.mCSB_scrollTools_vertical{box-shadow:inset 1px 0 1px rgba(0,0,0,.1),inset 0 0 14px rgba(0,0,0,.5)}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal,.mCS-3d-thick.mCSB_scrollTools_horizontal{bottom:1px;box-shadow:inset 0 1px 1px rgba(0,0,0,.1),inset 0 0 14px rgba(0,0,0,.5)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{-webkit-border-radius:5px;-moz-border-radius:5px;border-radius:5px;box-shadow:inset 1px 0 0 rgba(255,255,255,.4);width:12px;margin:2px;position:absolute;height:auto;top:0;bottom:0;left:0;right:0}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{box-shadow:inset 0 1px 0 rgba(255,255,255,.4);height:12px;width:auto}.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d-thick.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#555}.mCS-3d-thick.mCSB_scrollTools .mCSB_draggerContainer{background-color:#000;background-color:rgba(0,0,0,.05);box-shadow:inset 1px 1px 16px rgba(0,0,0,.1)}.mCS-3d-thick.mCSB_scrollTools .mCSB_draggerRail{background-color:transparent}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-3d-thick.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-3d-thick-dark.mCSB_scrollTools{box-shadow:inset 0 0 14px rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal{box-shadow:inset 0 1px 1px rgba(0,0,0,.1),inset 0 0 14px rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{box-shadow:inset 1px 0 0 rgba(255,255,255,.4),inset -1px 0 0 rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{box-shadow:inset 0 1px 0 rgba(255,255,255,.4),inset 0 -1px 0 rgba(0,0,0,.2)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#777}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_draggerContainer{background-color:#fff;background-color:rgba(0,0,0,.05);box-shadow:inset 1px 1px 16px rgba(0,0,0,.1)}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-minimal-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-minimal.mCSB_scrollTools .mCSB_draggerRail{background-color:transparent}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-3d-thick-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCSB_outside+.mCS-minimal-dark.mCSB_scrollTools_vertical,.mCSB_outside+.mCS-minimal.mCSB_scrollTools_vertical{right:0;margin:12px 0}.mCustomScrollBox.mCS-minimal+.mCSB_scrollTools+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox.mCS-minimal+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox.mCS-minimal-dark+.mCSB_scrollTools+.mCSB_scrollTools.mCSB_scrollTools_horizontal,.mCustomScrollBox.mCS-minimal-dark+.mCSB_scrollTools.mCSB_scrollTools_horizontal{bottom:0;margin:0 12px}.mCS-dir-rtl>.mCSB_outside+.mCS-minimal-dark.mCSB_scrollTools_vertical,.mCS-dir-rtl>.mCSB_outside+.mCS-minimal.mCSB_scrollTools_vertical{left:0;right:auto}.mCS-minimal-dark.mCSB_scrollTools_vertical .mCSB_dragger,.mCS-minimal.mCSB_scrollTools_vertical .mCSB_dragger{height:50px}.mCS-minimal-dark.mCSB_scrollTools_horizontal .mCSB_dragger,.mCS-minimal.mCSB_scrollTools_horizontal .mCSB_dragger{width:50px}.mCS-minimal.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.2);filter:"alpha(opacity=20)";-ms-filter:"alpha(opacity=20)"}.mCS-minimal.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-minimal.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.5);filter:"alpha(opacity=50)";-ms-filter:"alpha(opacity=50)"}.mCS-minimal-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.2);filter:"alpha(opacity=20)";-ms-filter:"alpha(opacity=20)"}.mCS-minimal-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-minimal-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.5);filter:"alpha(opacity=50)";-ms-filter:"alpha(opacity=50)"}.mCS-dark-3.mCSB_scrollTools .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools .mCSB_draggerRail{width:6px;background-color:#000;background-color:rgba(0,0,0,.2)}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-light-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:6px}.mCS-dark-3.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-dark-3.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-light-3.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:6px;margin:5px 0}.mCS-dark-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-dark-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_vertical.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{width:12px}.mCS-dark-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-dark-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_dragger.mCSB_dragger_onDrag_expanded+.mCSB_draggerRail,.mCS-light-3.mCSB_scrollTools_horizontal.mCSB_scrollTools_onDrag_expand .mCSB_draggerContainer:hover .mCSB_draggerRail{height:12px;margin:2px 0}.mCS-light-3.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-light-3.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-light-3.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-light-3.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-dark-3.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-dark-3.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-dark-3.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1)}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-dark-3.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-2.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-3.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset.mCSB_scrollTools .mCSB_draggerRail{width:12px;background-color:#000;background-color:rgba(0,0,0,.2)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-2.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{width:6px;margin:3px 5px;position:absolute;height:auto;top:0;bottom:0;left:0;right:0}.mCS-inset-2-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-2.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar,.mCS-inset.mCSB_scrollTools_horizontal .mCSB_dragger .mCSB_dragger_bar{height:6px;margin:5px 3px;position:absolute;width:auto;top:0;bottom:0;left:0;right:0}.mCS-inset-2-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-2.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-3-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-3.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset-dark.mCSB_scrollTools_horizontal .mCSB_draggerRail,.mCS-inset.mCSB_scrollTools_horizontal .mCSB_draggerRail{width:100%;height:12px;margin:2px 0}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset.mCSB_scrollTools .mCSB_buttonUp{background-position:-32px -72px}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset.mCSB_scrollTools .mCSB_buttonDown{background-position:-32px -92px}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset.mCSB_scrollTools .mCSB_buttonLeft{background-position:-40px -112px}.mCS-inset-2.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset-3.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset.mCSB_scrollTools .mCSB_buttonRight{background-position:-40px -128px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-2-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.1)}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonUp,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonUp{background-position:-112px -72px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonDown,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonDown{background-position:-112px -92px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonLeft,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonLeft{background-position:-120px -112px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_buttonRight,.mCS-inset-dark.mCSB_scrollTools .mCSB_buttonRight{background-position:-120px -128px}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail,.mCS-inset-2.mCSB_scrollTools .mCSB_draggerRail{background-color:transparent;border-width:1px;border-style:solid;border-color:#fff;border-color:rgba(255,255,255,.2);-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}.mCS-inset-2-dark.mCSB_scrollTools .mCSB_draggerRail{border-color:#000;border-color:rgba(0,0,0,.2)}.mCS-inset-3.mCSB_scrollTools .mCSB_draggerRail{background-color:#fff;background-color:rgba(255,255,255,.6)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_draggerRail{background-color:#000;background-color:rgba(0,0,0,.6)}.mCS-inset-3.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.75)}.mCS-inset-3.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.85)}.mCS-inset-3.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-3.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#000;background-color:rgba(0,0,0,.9)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.75)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:hover .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.85)}.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger.mCSB_dragger_onDrag .mCSB_dragger_bar,.mCS-inset-3-dark.mCSB_scrollTools .mCSB_dragger:active .mCSB_dragger_bar{background-color:#fff;background-color:rgba(255,255,255,.9)}
@charset "UTF-8";

/*!
 * animate.css -http://daneden.me/animate
 * Version - 3.7.0
 * Licensed under the MIT license - http://opensource.org/licenses/MIT
 *
 * Copyright (c) 2018 Daniel Eden
 */

@-webkit-keyframes bounce {
  from,
  20%,
  53%,
  80%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  40%,
  43% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -30px, 0);
    transform: translate3d(0, -30px, 0);
  }

  70% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -15px, 0);
    transform: translate3d(0, -15px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, -4px, 0);
    transform: translate3d(0, -4px, 0);
  }
}

@keyframes bounce {
  from,
  20%,
  53%,
  80%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  40%,
  43% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -30px, 0);
    transform: translate3d(0, -30px, 0);
  }

  70% {
    -webkit-animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    -webkit-transform: translate3d(0, -15px, 0);
    transform: translate3d(0, -15px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, -4px, 0);
    transform: translate3d(0, -4px, 0);
  }
}

.bounce {
  -webkit-animation-name: bounce;
  animation-name: bounce;
  -webkit-transform-origin: center bottom;
  transform-origin: center bottom;
}

@-webkit-keyframes flash {
  from,
  50%,
  to {
    opacity: 1;
  }

  25%,
  75% {
    opacity: 0;
  }
}

@keyframes flash {
  from,
  50%,
  to {
    opacity: 1;
  }

  25%,
  75% {
    opacity: 0;
  }
}

.flash {
  -webkit-animation-name: flash;
  animation-name: flash;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */

@-webkit-keyframes pulse {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  50% {
    -webkit-transform: scale3d(1.05, 1.05, 1.05);
    transform: scale3d(1.05, 1.05, 1.05);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes pulse {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  50% {
    -webkit-transform: scale3d(1.05, 1.05, 1.05);
    transform: scale3d(1.05, 1.05, 1.05);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.pulse {
  -webkit-animation-name: pulse;
  animation-name: pulse;
}

@-webkit-keyframes rubberBand {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  30% {
    -webkit-transform: scale3d(1.25, 0.75, 1);
    transform: scale3d(1.25, 0.75, 1);
  }

  40% {
    -webkit-transform: scale3d(0.75, 1.25, 1);
    transform: scale3d(0.75, 1.25, 1);
  }

  50% {
    -webkit-transform: scale3d(1.15, 0.85, 1);
    transform: scale3d(1.15, 0.85, 1);
  }

  65% {
    -webkit-transform: scale3d(0.95, 1.05, 1);
    transform: scale3d(0.95, 1.05, 1);
  }

  75% {
    -webkit-transform: scale3d(1.05, 0.95, 1);
    transform: scale3d(1.05, 0.95, 1);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes rubberBand {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  30% {
    -webkit-transform: scale3d(1.25, 0.75, 1);
    transform: scale3d(1.25, 0.75, 1);
  }

  40% {
    -webkit-transform: scale3d(0.75, 1.25, 1);
    transform: scale3d(0.75, 1.25, 1);
  }

  50% {
    -webkit-transform: scale3d(1.15, 0.85, 1);
    transform: scale3d(1.15, 0.85, 1);
  }

  65% {
    -webkit-transform: scale3d(0.95, 1.05, 1);
    transform: scale3d(0.95, 1.05, 1);
  }

  75% {
    -webkit-transform: scale3d(1.05, 0.95, 1);
    transform: scale3d(1.05, 0.95, 1);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.rubberBand {
  -webkit-animation-name: rubberBand;
  animation-name: rubberBand;
}

@-webkit-keyframes shake {
  from,
  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  10%,
  30%,
  50%,
  70%,
  90% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  20%,
  40%,
  60%,
  80% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }
}

@keyframes shake {
  from,
  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  10%,
  30%,
  50%,
  70%,
  90% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  20%,
  40%,
  60%,
  80% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }
}

.shake {
  -webkit-animation-name: shake;
  animation-name: shake;
}

@-webkit-keyframes headShake {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }

  6.5% {
    -webkit-transform: translateX(-6px) rotateY(-9deg);
    transform: translateX(-6px) rotateY(-9deg);
  }

  18.5% {
    -webkit-transform: translateX(5px) rotateY(7deg);
    transform: translateX(5px) rotateY(7deg);
  }

  31.5% {
    -webkit-transform: translateX(-3px) rotateY(-5deg);
    transform: translateX(-3px) rotateY(-5deg);
  }

  43.5% {
    -webkit-transform: translateX(2px) rotateY(3deg);
    transform: translateX(2px) rotateY(3deg);
  }

  50% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

@keyframes headShake {
  0% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }

  6.5% {
    -webkit-transform: translateX(-6px) rotateY(-9deg);
    transform: translateX(-6px) rotateY(-9deg);
  }

  18.5% {
    -webkit-transform: translateX(5px) rotateY(7deg);
    transform: translateX(5px) rotateY(7deg);
  }

  31.5% {
    -webkit-transform: translateX(-3px) rotateY(-5deg);
    transform: translateX(-3px) rotateY(-5deg);
  }

  43.5% {
    -webkit-transform: translateX(2px) rotateY(3deg);
    transform: translateX(2px) rotateY(3deg);
  }

  50% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
}

.headShake {
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
  -webkit-animation-name: headShake;
  animation-name: headShake;
}

@-webkit-keyframes swing {
  20% {
    -webkit-transform: rotate3d(0, 0, 1, 15deg);
    transform: rotate3d(0, 0, 1, 15deg);
  }

  40% {
    -webkit-transform: rotate3d(0, 0, 1, -10deg);
    transform: rotate3d(0, 0, 1, -10deg);
  }

  60% {
    -webkit-transform: rotate3d(0, 0, 1, 5deg);
    transform: rotate3d(0, 0, 1, 5deg);
  }

  80% {
    -webkit-transform: rotate3d(0, 0, 1, -5deg);
    transform: rotate3d(0, 0, 1, -5deg);
  }

  to {
    -webkit-transform: rotate3d(0, 0, 1, 0deg);
    transform: rotate3d(0, 0, 1, 0deg);
  }
}

@keyframes swing {
  20% {
    -webkit-transform: rotate3d(0, 0, 1, 15deg);
    transform: rotate3d(0, 0, 1, 15deg);
  }

  40% {
    -webkit-transform: rotate3d(0, 0, 1, -10deg);
    transform: rotate3d(0, 0, 1, -10deg);
  }

  60% {
    -webkit-transform: rotate3d(0, 0, 1, 5deg);
    transform: rotate3d(0, 0, 1, 5deg);
  }

  80% {
    -webkit-transform: rotate3d(0, 0, 1, -5deg);
    transform: rotate3d(0, 0, 1, -5deg);
  }

  to {
    -webkit-transform: rotate3d(0, 0, 1, 0deg);
    transform: rotate3d(0, 0, 1, 0deg);
  }
}

.swing {
  -webkit-transform-origin: top center;
  transform-origin: top center;
  -webkit-animation-name: swing;
  animation-name: swing;
}

@-webkit-keyframes tada {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  10%,
  20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(0.9, 0.9, 0.9) rotate3d(0, 0, 1, -3deg);
  }

  30%,
  50%,
  70%,
  90% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
  }

  40%,
  60%,
  80% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes tada {
  from {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }

  10%,
  20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(0.9, 0.9, 0.9) rotate3d(0, 0, 1, -3deg);
  }

  30%,
  50%,
  70%,
  90% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, 3deg);
  }

  40%,
  60%,
  80% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
    transform: scale3d(1.1, 1.1, 1.1) rotate3d(0, 0, 1, -3deg);
  }

  to {
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.tada {
  -webkit-animation-name: tada;
  animation-name: tada;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */

@-webkit-keyframes wobble {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  15% {
    -webkit-transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
    transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
  }

  30% {
    -webkit-transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
    transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
  }

  45% {
    -webkit-transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
    transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
  }

  60% {
    -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
    transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
  }

  75% {
    -webkit-transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
    transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes wobble {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  15% {
    -webkit-transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
    transform: translate3d(-25%, 0, 0) rotate3d(0, 0, 1, -5deg);
  }

  30% {
    -webkit-transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
    transform: translate3d(20%, 0, 0) rotate3d(0, 0, 1, 3deg);
  }

  45% {
    -webkit-transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
    transform: translate3d(-15%, 0, 0) rotate3d(0, 0, 1, -3deg);
  }

  60% {
    -webkit-transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
    transform: translate3d(10%, 0, 0) rotate3d(0, 0, 1, 2deg);
  }

  75% {
    -webkit-transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
    transform: translate3d(-5%, 0, 0) rotate3d(0, 0, 1, -1deg);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.wobble {
  -webkit-animation-name: wobble;
  animation-name: wobble;
}

@-webkit-keyframes jello {
  from,
  11.1%,
  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  22.2% {
    -webkit-transform: skewX(-12.5deg) skewY(-12.5deg);
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }

  33.3% {
    -webkit-transform: skewX(6.25deg) skewY(6.25deg);
    transform: skewX(6.25deg) skewY(6.25deg);
  }

  44.4% {
    -webkit-transform: skewX(-3.125deg) skewY(-3.125deg);
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }

  55.5% {
    -webkit-transform: skewX(1.5625deg) skewY(1.5625deg);
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }

  66.6% {
    -webkit-transform: skewX(-0.78125deg) skewY(-0.78125deg);
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }

  77.7% {
    -webkit-transform: skewX(0.390625deg) skewY(0.390625deg);
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }

  88.8% {
    -webkit-transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
}

@keyframes jello {
  from,
  11.1%,
  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  22.2% {
    -webkit-transform: skewX(-12.5deg) skewY(-12.5deg);
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }

  33.3% {
    -webkit-transform: skewX(6.25deg) skewY(6.25deg);
    transform: skewX(6.25deg) skewY(6.25deg);
  }

  44.4% {
    -webkit-transform: skewX(-3.125deg) skewY(-3.125deg);
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }

  55.5% {
    -webkit-transform: skewX(1.5625deg) skewY(1.5625deg);
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }

  66.6% {
    -webkit-transform: skewX(-0.78125deg) skewY(-0.78125deg);
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }

  77.7% {
    -webkit-transform: skewX(0.390625deg) skewY(0.390625deg);
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }

  88.8% {
    -webkit-transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
}

.jello {
  -webkit-animation-name: jello;
  animation-name: jello;
  -webkit-transform-origin: center;
  transform-origin: center;
}

@-webkit-keyframes heartBeat {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }

  14% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }

  28% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }

  42% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }

  70% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

@keyframes heartBeat {
  0% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }

  14% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }

  28% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }

  42% {
    -webkit-transform: scale(1.3);
    transform: scale(1.3);
  }

  70% {
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

.heartBeat {
  -webkit-animation-name: heartBeat;
  animation-name: heartBeat;
  -webkit-animation-duration: 1.3s;
  animation-duration: 1.3s;
  -webkit-animation-timing-function: ease-in-out;
  animation-timing-function: ease-in-out;
}

@-webkit-keyframes bounceIn {
  from,
  20%,
  40%,
  60%,
  80%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }

  20% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  40% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(1.03, 1.03, 1.03);
    transform: scale3d(1.03, 1.03, 1.03);
  }

  80% {
    -webkit-transform: scale3d(0.97, 0.97, 0.97);
    transform: scale3d(0.97, 0.97, 0.97);
  }

  to {
    opacity: 1;
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

@keyframes bounceIn {
  from,
  20%,
  40%,
  60%,
  80%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  0% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }

  20% {
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  40% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(1.03, 1.03, 1.03);
    transform: scale3d(1.03, 1.03, 1.03);
  }

  80% {
    -webkit-transform: scale3d(0.97, 0.97, 0.97);
    transform: scale3d(0.97, 0.97, 0.97);
  }

  to {
    opacity: 1;
    -webkit-transform: scale3d(1, 1, 1);
    transform: scale3d(1, 1, 1);
  }
}

.bounceIn {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-name: bounceIn;
  animation-name: bounceIn;
}

@-webkit-keyframes bounceInDown {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -3000px, 0);
    transform: translate3d(0, -3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, 25px, 0);
    transform: translate3d(0, 25px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, 5px, 0);
    transform: translate3d(0, 5px, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes bounceInDown {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -3000px, 0);
    transform: translate3d(0, -3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, 25px, 0);
    transform: translate3d(0, 25px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, 5px, 0);
    transform: translate3d(0, 5px, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.bounceInDown {
  -webkit-animation-name: bounceInDown;
  animation-name: bounceInDown;
}

@-webkit-keyframes bounceInLeft {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(-3000px, 0, 0);
    transform: translate3d(-3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(25px, 0, 0);
    transform: translate3d(25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(5px, 0, 0);
    transform: translate3d(5px, 0, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes bounceInLeft {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  0% {
    opacity: 0;
    -webkit-transform: translate3d(-3000px, 0, 0);
    transform: translate3d(-3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(25px, 0, 0);
    transform: translate3d(25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(-10px, 0, 0);
    transform: translate3d(-10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(5px, 0, 0);
    transform: translate3d(5px, 0, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.bounceInLeft {
  -webkit-animation-name: bounceInLeft;
  animation-name: bounceInLeft;
}

@-webkit-keyframes bounceInRight {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(3000px, 0, 0);
    transform: translate3d(3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(-25px, 0, 0);
    transform: translate3d(-25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(-5px, 0, 0);
    transform: translate3d(-5px, 0, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes bounceInRight {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(3000px, 0, 0);
    transform: translate3d(3000px, 0, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(-25px, 0, 0);
    transform: translate3d(-25px, 0, 0);
  }

  75% {
    -webkit-transform: translate3d(10px, 0, 0);
    transform: translate3d(10px, 0, 0);
  }

  90% {
    -webkit-transform: translate3d(-5px, 0, 0);
    transform: translate3d(-5px, 0, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.bounceInRight {
  -webkit-animation-name: bounceInRight;
  animation-name: bounceInRight;
}

@-webkit-keyframes bounceInUp {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 3000px, 0);
    transform: translate3d(0, 3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, -5px, 0);
    transform: translate3d(0, -5px, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes bounceInUp {
  from,
  60%,
  75%,
  90%,
  to {
    -webkit-animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
    animation-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
  }

  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 3000px, 0);
    transform: translate3d(0, 3000px, 0);
  }

  60% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  75% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  90% {
    -webkit-transform: translate3d(0, -5px, 0);
    transform: translate3d(0, -5px, 0);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.bounceInUp {
  -webkit-animation-name: bounceInUp;
  animation-name: bounceInUp;
}

@-webkit-keyframes bounceOut {
  20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }

  50%,
  55% {
    opacity: 1;
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
}

@keyframes bounceOut {
  20% {
    -webkit-transform: scale3d(0.9, 0.9, 0.9);
    transform: scale3d(0.9, 0.9, 0.9);
  }

  50%,
  55% {
    opacity: 1;
    -webkit-transform: scale3d(1.1, 1.1, 1.1);
    transform: scale3d(1.1, 1.1, 1.1);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }
}

.bounceOut {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-name: bounceOut;
  animation-name: bounceOut;
}

@-webkit-keyframes bounceOutDown {
  20% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  40%,
  45% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

@keyframes bounceOutDown {
  20% {
    -webkit-transform: translate3d(0, 10px, 0);
    transform: translate3d(0, 10px, 0);
  }

  40%,
  45% {
    opacity: 1;
    -webkit-transform: translate3d(0, -20px, 0);
    transform: translate3d(0, -20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

.bounceOutDown {
  -webkit-animation-name: bounceOutDown;
  animation-name: bounceOutDown;
}

@-webkit-keyframes bounceOutLeft {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(20px, 0, 0);
    transform: translate3d(20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

@keyframes bounceOutLeft {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(20px, 0, 0);
    transform: translate3d(20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

.bounceOutLeft {
  -webkit-animation-name: bounceOutLeft;
  animation-name: bounceOutLeft;
}

@-webkit-keyframes bounceOutRight {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(-20px, 0, 0);
    transform: translate3d(-20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

@keyframes bounceOutRight {
  20% {
    opacity: 1;
    -webkit-transform: translate3d(-20px, 0, 0);
    transform: translate3d(-20px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

.bounceOutRight {
  -webkit-animation-name: bounceOutRight;
  animation-name: bounceOutRight;
}

@-webkit-keyframes bounceOutUp {
  20% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  40%,
  45% {
    opacity: 1;
    -webkit-transform: translate3d(0, 20px, 0);
    transform: translate3d(0, 20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

@keyframes bounceOutUp {
  20% {
    -webkit-transform: translate3d(0, -10px, 0);
    transform: translate3d(0, -10px, 0);
  }

  40%,
  45% {
    opacity: 1;
    -webkit-transform: translate3d(0, 20px, 0);
    transform: translate3d(0, 20px, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

.bounceOutUp {
  -webkit-animation-name: bounceOutUp;
  animation-name: bounceOutUp;
}

@-webkit-keyframes fadeIn {
  from {
    opacity: 0;
  }

  to {
    opacity: 1;
  }
}

@keyframes fadeIn {
  from {
    opacity: 0;
  }

  to {
    opacity: 1;
  }
}

.fadeIn {
  -webkit-animation-name: fadeIn;
  animation-name: fadeIn;
}

@-webkit-keyframes fadeInDown {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInDown {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInDown {
  -webkit-animation-name: fadeInDown;
  animation-name: fadeInDown;
}

@-webkit-keyframes fadeInDownBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInDownBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInDownBig {
  -webkit-animation-name: fadeInDownBig;
  animation-name: fadeInDownBig;
}

@-webkit-keyframes fadeInLeft {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInLeft {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInLeft {
  -webkit-animation-name: fadeInLeft;
  animation-name: fadeInLeft;
}

@-webkit-keyframes fadeInLeftBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInLeftBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInLeftBig {
  -webkit-animation-name: fadeInLeftBig;
  animation-name: fadeInLeftBig;
}

@-webkit-keyframes fadeInRight {
  from {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInRight {
  from {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInRight {
  -webkit-animation-name: fadeInRight;
  animation-name: fadeInRight;
}

@-webkit-keyframes fadeInRightBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInRightBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInRightBig {
  -webkit-animation-name: fadeInRightBig;
  animation-name: fadeInRightBig;
}

@-webkit-keyframes fadeInUp {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInUp {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInUp {
  -webkit-animation-name: fadeInUp;
  animation-name: fadeInUp;
}

@-webkit-keyframes fadeInUpBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes fadeInUpBig {
  from {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.fadeInUpBig {
  -webkit-animation-name: fadeInUpBig;
  animation-name: fadeInUpBig;
}

@-webkit-keyframes fadeOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
  }
}

@keyframes fadeOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
  }
}

.fadeOut {
  -webkit-animation-name: fadeOut;
  animation-name: fadeOut;
}

@-webkit-keyframes fadeOutDown {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

@keyframes fadeOutDown {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

.fadeOutDown {
  -webkit-animation-name: fadeOutDown;
  animation-name: fadeOutDown;
}

@-webkit-keyframes fadeOutDownBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

@keyframes fadeOutDownBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, 2000px, 0);
    transform: translate3d(0, 2000px, 0);
  }
}

.fadeOutDownBig {
  -webkit-animation-name: fadeOutDownBig;
  animation-name: fadeOutDownBig;
}

@-webkit-keyframes fadeOutLeft {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

@keyframes fadeOutLeft {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

.fadeOutLeft {
  -webkit-animation-name: fadeOutLeft;
  animation-name: fadeOutLeft;
}

@-webkit-keyframes fadeOutLeftBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

@keyframes fadeOutLeftBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(-2000px, 0, 0);
    transform: translate3d(-2000px, 0, 0);
  }
}

.fadeOutLeftBig {
  -webkit-animation-name: fadeOutLeftBig;
  animation-name: fadeOutLeftBig;
}

@-webkit-keyframes fadeOutRight {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

@keyframes fadeOutRight {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

.fadeOutRight {
  -webkit-animation-name: fadeOutRight;
  animation-name: fadeOutRight;
}

@-webkit-keyframes fadeOutRightBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

@keyframes fadeOutRightBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(2000px, 0, 0);
    transform: translate3d(2000px, 0, 0);
  }
}

.fadeOutRightBig {
  -webkit-animation-name: fadeOutRightBig;
  animation-name: fadeOutRightBig;
}

@-webkit-keyframes fadeOutUp {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

@keyframes fadeOutUp {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

.fadeOutUp {
  -webkit-animation-name: fadeOutUp;
  animation-name: fadeOutUp;
}

@-webkit-keyframes fadeOutUpBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

@keyframes fadeOutUpBig {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(0, -2000px, 0);
    transform: translate3d(0, -2000px, 0);
  }
}

.fadeOutUpBig {
  -webkit-animation-name: fadeOutUpBig;
  animation-name: fadeOutUpBig;
}

@-webkit-keyframes flip {
  from {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, -360deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0) rotate3d(0, 1, 0, -360deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  40% {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -190deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -190deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  50% {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -170deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -170deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  80% {
    -webkit-transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, 0deg);
    transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, 0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  to {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, 0deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0) rotate3d(0, 1, 0, 0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}

@keyframes flip {
  from {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, -360deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0) rotate3d(0, 1, 0, -360deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  40% {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -190deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -190deg);
    -webkit-animation-timing-function: ease-out;
    animation-timing-function: ease-out;
  }

  50% {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -170deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 150px)
      rotate3d(0, 1, 0, -170deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  80% {
    -webkit-transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, 0deg);
    transform: perspective(400px) scale3d(0.95, 0.95, 0.95) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, 0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  to {
    -webkit-transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0)
      rotate3d(0, 1, 0, 0deg);
    transform: perspective(400px) scale3d(1, 1, 1) translate3d(0, 0, 0) rotate3d(0, 1, 0, 0deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }
}

.animated.flip {
  -webkit-backface-visibility: visible;
  backface-visibility: visible;
  -webkit-animation-name: flip;
  animation-name: flip;
}

@-webkit-keyframes flipInX {
  from {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

@keyframes flipInX {
  from {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

.flipInX {
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInX;
  animation-name: flipInX;
}

@-webkit-keyframes flipInY {
  from {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

@keyframes flipInY {
  from {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
    opacity: 0;
  }

  40% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -20deg);
    -webkit-animation-timing-function: ease-in;
    animation-timing-function: ease-in;
  }

  60% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 10deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -5deg);
  }

  to {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }
}

.flipInY {
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipInY;
  animation-name: flipInY;
}

@-webkit-keyframes flipOutX {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    opacity: 0;
  }
}

@keyframes flipOutX {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    transform: perspective(400px) rotate3d(1, 0, 0, -20deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    transform: perspective(400px) rotate3d(1, 0, 0, 90deg);
    opacity: 0;
  }
}

.flipOutX {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-animation-name: flipOutX;
  animation-name: flipOutX;
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
}

@-webkit-keyframes flipOutY {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    opacity: 0;
  }
}

@keyframes flipOutY {
  from {
    -webkit-transform: perspective(400px);
    transform: perspective(400px);
  }

  30% {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    transform: perspective(400px) rotate3d(0, 1, 0, -15deg);
    opacity: 1;
  }

  to {
    -webkit-transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    transform: perspective(400px) rotate3d(0, 1, 0, 90deg);
    opacity: 0;
  }
}

.flipOutY {
  -webkit-animation-duration: 0.75s;
  animation-duration: 0.75s;
  -webkit-backface-visibility: visible !important;
  backface-visibility: visible !important;
  -webkit-animation-name: flipOutY;
  animation-name: flipOutY;
}

@-webkit-keyframes lightSpeedIn {
  from {
    -webkit-transform: translate3d(100%, 0, 0) skewX(-30deg);
    transform: translate3d(100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }

  60% {
    -webkit-transform: skewX(20deg);
    transform: skewX(20deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: skewX(-5deg);
    transform: skewX(-5deg);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes lightSpeedIn {
  from {
    -webkit-transform: translate3d(100%, 0, 0) skewX(-30deg);
    transform: translate3d(100%, 0, 0) skewX(-30deg);
    opacity: 0;
  }

  60% {
    -webkit-transform: skewX(20deg);
    transform: skewX(20deg);
    opacity: 1;
  }

  80% {
    -webkit-transform: skewX(-5deg);
    transform: skewX(-5deg);
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.lightSpeedIn {
  -webkit-animation-name: lightSpeedIn;
  animation-name: lightSpeedIn;
  -webkit-animation-timing-function: ease-out;
  animation-timing-function: ease-out;
}

@-webkit-keyframes lightSpeedOut {
  from {
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(100%, 0, 0) skewX(30deg);
    transform: translate3d(100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
}

@keyframes lightSpeedOut {
  from {
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(100%, 0, 0) skewX(30deg);
    transform: translate3d(100%, 0, 0) skewX(30deg);
    opacity: 0;
  }
}

.lightSpeedOut {
  -webkit-animation-name: lightSpeedOut;
  animation-name: lightSpeedOut;
  -webkit-animation-timing-function: ease-in;
  animation-timing-function: ease-in;
}

@-webkit-keyframes rotateIn {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, -200deg);
    transform: rotate3d(0, 0, 1, -200deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

@keyframes rotateIn {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, -200deg);
    transform: rotate3d(0, 0, 1, -200deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

.rotateIn {
  -webkit-animation-name: rotateIn;
  animation-name: rotateIn;
}

@-webkit-keyframes rotateInDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

@keyframes rotateInDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

.rotateInDownLeft {
  -webkit-animation-name: rotateInDownLeft;
  animation-name: rotateInDownLeft;
}

@-webkit-keyframes rotateInDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

@keyframes rotateInDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

.rotateInDownRight {
  -webkit-animation-name: rotateInDownRight;
  animation-name: rotateInDownRight;
}

@-webkit-keyframes rotateInUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

@keyframes rotateInUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

.rotateInUpLeft {
  -webkit-animation-name: rotateInUpLeft;
  animation-name: rotateInUpLeft;
}

@-webkit-keyframes rotateInUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -90deg);
    transform: rotate3d(0, 0, 1, -90deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

@keyframes rotateInUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -90deg);
    transform: rotate3d(0, 0, 1, -90deg);
    opacity: 0;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
    opacity: 1;
  }
}

.rotateInUpRight {
  -webkit-animation-name: rotateInUpRight;
  animation-name: rotateInUpRight;
}

@-webkit-keyframes rotateOut {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, 200deg);
    transform: rotate3d(0, 0, 1, 200deg);
    opacity: 0;
  }
}

@keyframes rotateOut {
  from {
    -webkit-transform-origin: center;
    transform-origin: center;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: center;
    transform-origin: center;
    -webkit-transform: rotate3d(0, 0, 1, 200deg);
    transform: rotate3d(0, 0, 1, 200deg);
    opacity: 0;
  }
}

.rotateOut {
  -webkit-animation-name: rotateOut;
  animation-name: rotateOut;
}

@-webkit-keyframes rotateOutDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }
}

@keyframes rotateOutDownLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, 45deg);
    transform: rotate3d(0, 0, 1, 45deg);
    opacity: 0;
  }
}

.rotateOutDownLeft {
  -webkit-animation-name: rotateOutDownLeft;
  animation-name: rotateOutDownLeft;
}

@-webkit-keyframes rotateOutDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

@keyframes rotateOutDownRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

.rotateOutDownRight {
  -webkit-animation-name: rotateOutDownRight;
  animation-name: rotateOutDownRight;
}

@-webkit-keyframes rotateOutUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

@keyframes rotateOutUpLeft {
  from {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: left bottom;
    transform-origin: left bottom;
    -webkit-transform: rotate3d(0, 0, 1, -45deg);
    transform: rotate3d(0, 0, 1, -45deg);
    opacity: 0;
  }
}

.rotateOutUpLeft {
  -webkit-animation-name: rotateOutUpLeft;
  animation-name: rotateOutUpLeft;
}

@-webkit-keyframes rotateOutUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 90deg);
    transform: rotate3d(0, 0, 1, 90deg);
    opacity: 0;
  }
}

@keyframes rotateOutUpRight {
  from {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    opacity: 1;
  }

  to {
    -webkit-transform-origin: right bottom;
    transform-origin: right bottom;
    -webkit-transform: rotate3d(0, 0, 1, 90deg);
    transform: rotate3d(0, 0, 1, 90deg);
    opacity: 0;
  }
}

.rotateOutUpRight {
  -webkit-animation-name: rotateOutUpRight;
  animation-name: rotateOutUpRight;
}

@-webkit-keyframes hinge {
  0% {
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  20%,
  60% {
    -webkit-transform: rotate3d(0, 0, 1, 80deg);
    transform: rotate3d(0, 0, 1, 80deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  40%,
  80% {
    -webkit-transform: rotate3d(0, 0, 1, 60deg);
    transform: rotate3d(0, 0, 1, 60deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(0, 700px, 0);
    transform: translate3d(0, 700px, 0);
    opacity: 0;
  }
}

@keyframes hinge {
  0% {
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  20%,
  60% {
    -webkit-transform: rotate3d(0, 0, 1, 80deg);
    transform: rotate3d(0, 0, 1, 80deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
  }

  40%,
  80% {
    -webkit-transform: rotate3d(0, 0, 1, 60deg);
    transform: rotate3d(0, 0, 1, 60deg);
    -webkit-transform-origin: top left;
    transform-origin: top left;
    -webkit-animation-timing-function: ease-in-out;
    animation-timing-function: ease-in-out;
    opacity: 1;
  }

  to {
    -webkit-transform: translate3d(0, 700px, 0);
    transform: translate3d(0, 700px, 0);
    opacity: 0;
  }
}

.hinge {
  -webkit-animation-duration: 2s;
  animation-duration: 2s;
  -webkit-animation-name: hinge;
  animation-name: hinge;
}

@-webkit-keyframes jackInTheBox {
  from {
    opacity: 0;
    -webkit-transform: scale(0.1) rotate(30deg);
    transform: scale(0.1) rotate(30deg);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
  }

  50% {
    -webkit-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }

  70% {
    -webkit-transform: rotate(3deg);
    transform: rotate(3deg);
  }

  to {
    opacity: 1;
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

@keyframes jackInTheBox {
  from {
    opacity: 0;
    -webkit-transform: scale(0.1) rotate(30deg);
    transform: scale(0.1) rotate(30deg);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
  }

  50% {
    -webkit-transform: rotate(-10deg);
    transform: rotate(-10deg);
  }

  70% {
    -webkit-transform: rotate(3deg);
    transform: rotate(3deg);
  }

  to {
    opacity: 1;
    -webkit-transform: scale(1);
    transform: scale(1);
  }
}

.jackInTheBox {
  -webkit-animation-name: jackInTheBox;
  animation-name: jackInTheBox;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */

@-webkit-keyframes rollIn {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
    transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes rollIn {
  from {
    opacity: 0;
    -webkit-transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
    transform: translate3d(-100%, 0, 0) rotate3d(0, 0, 1, -120deg);
  }

  to {
    opacity: 1;
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.rollIn {
  -webkit-animation-name: rollIn;
  animation-name: rollIn;
}

/* originally authored by Nick Pettit - https://github.com/nickpettit/glide */

@-webkit-keyframes rollOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
    transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
  }
}

@keyframes rollOut {
  from {
    opacity: 1;
  }

  to {
    opacity: 0;
    -webkit-transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
    transform: translate3d(100%, 0, 0) rotate3d(0, 0, 1, 120deg);
  }
}

.rollOut {
  -webkit-animation-name: rollOut;
  animation-name: rollOut;
}

@-webkit-keyframes zoomIn {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }

  50% {
    opacity: 1;
  }
}

@keyframes zoomIn {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }

  50% {
    opacity: 1;
  }
}

.zoomIn {
  -webkit-animation-name: zoomIn;
  animation-name: zoomIn;
}

@-webkit-keyframes zoomInDown {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

@keyframes zoomInDown {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

.zoomInDown {
  -webkit-animation-name: zoomInDown;
  animation-name: zoomInDown;
}

@-webkit-keyframes zoomInLeft {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

@keyframes zoomInLeft {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(-1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

.zoomInLeft {
  -webkit-animation-name: zoomInLeft;
  animation-name: zoomInLeft;
}

@-webkit-keyframes zoomInRight {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

@keyframes zoomInRight {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(1000px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-10px, 0, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

.zoomInRight {
  -webkit-animation-name: zoomInRight;
  animation-name: zoomInRight;
}

@-webkit-keyframes zoomInUp {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

@keyframes zoomInUp {
  from {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 1000px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  60% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

.zoomInUp {
  -webkit-animation-name: zoomInUp;
  animation-name: zoomInUp;
}

@-webkit-keyframes zoomOut {
  from {
    opacity: 1;
  }

  50% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }

  to {
    opacity: 0;
  }
}

@keyframes zoomOut {
  from {
    opacity: 1;
  }

  50% {
    opacity: 0;
    -webkit-transform: scale3d(0.3, 0.3, 0.3);
    transform: scale3d(0.3, 0.3, 0.3);
  }

  to {
    opacity: 0;
  }
}

.zoomOut {
  -webkit-animation-name: zoomOut;
  animation-name: zoomOut;
}

@-webkit-keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

@keyframes zoomOutDown {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, -60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, 2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

.zoomOutDown {
  -webkit-animation-name: zoomOutDown;
  animation-name: zoomOutDown;
}

@-webkit-keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(-2000px, 0, 0);
    transform: scale(0.1) translate3d(-2000px, 0, 0);
    -webkit-transform-origin: left center;
    transform-origin: left center;
  }
}

@keyframes zoomOutLeft {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(-2000px, 0, 0);
    transform: scale(0.1) translate3d(-2000px, 0, 0);
    -webkit-transform-origin: left center;
    transform-origin: left center;
  }
}

.zoomOutLeft {
  -webkit-animation-name: zoomOutLeft;
  animation-name: zoomOutLeft;
}

@-webkit-keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(2000px, 0, 0);
    transform: scale(0.1) translate3d(2000px, 0, 0);
    -webkit-transform-origin: right center;
    transform-origin: right center;
  }
}

@keyframes zoomOutRight {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(-42px, 0, 0);
  }

  to {
    opacity: 0;
    -webkit-transform: scale(0.1) translate3d(2000px, 0, 0);
    transform: scale(0.1) translate3d(2000px, 0, 0);
    -webkit-transform-origin: right center;
    transform-origin: right center;
  }
}

.zoomOutRight {
  -webkit-animation-name: zoomOutRight;
  animation-name: zoomOutRight;
}

@-webkit-keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

@keyframes zoomOutUp {
  40% {
    opacity: 1;
    -webkit-transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    transform: scale3d(0.475, 0.475, 0.475) translate3d(0, 60px, 0);
    -webkit-animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
    animation-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
  }

  to {
    opacity: 0;
    -webkit-transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    transform: scale3d(0.1, 0.1, 0.1) translate3d(0, -2000px, 0);
    -webkit-transform-origin: center bottom;
    transform-origin: center bottom;
    -webkit-animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
    animation-timing-function: cubic-bezier(0.175, 0.885, 0.32, 1);
  }
}

.zoomOutUp {
  -webkit-animation-name: zoomOutUp;
  animation-name: zoomOutUp;
}

@-webkit-keyframes slideInDown {
  from {
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInDown {
  from {
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInDown {
  -webkit-animation-name: slideInDown;
  animation-name: slideInDown;
}

@-webkit-keyframes slideInLeft {
  from {
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInLeft {
  from {
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInLeft {
  -webkit-animation-name: slideInLeft;
  animation-name: slideInLeft;
}

@-webkit-keyframes slideInRight {
  from {
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInRight {
  from {
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInRight {
  -webkit-animation-name: slideInRight;
  animation-name: slideInRight;
}

@-webkit-keyframes slideInUp {
  from {
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

@keyframes slideInUp {
  from {
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
    visibility: visible;
  }

  to {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }
}

.slideInUp {
  -webkit-animation-name: slideInUp;
  animation-name: slideInUp;
}

@-webkit-keyframes slideOutDown {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

@keyframes slideOutDown {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, 100%, 0);
    transform: translate3d(0, 100%, 0);
  }
}

.slideOutDown {
  -webkit-animation-name: slideOutDown;
  animation-name: slideOutDown;
}

@-webkit-keyframes slideOutLeft {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

@keyframes slideOutLeft {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(-100%, 0, 0);
    transform: translate3d(-100%, 0, 0);
  }
}

.slideOutLeft {
  -webkit-animation-name: slideOutLeft;
  animation-name: slideOutLeft;
}

@-webkit-keyframes slideOutRight {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

@keyframes slideOutRight {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(100%, 0, 0);
    transform: translate3d(100%, 0, 0);
  }
}

.slideOutRight {
  -webkit-animation-name: slideOutRight;
  animation-name: slideOutRight;
}

@-webkit-keyframes slideOutUp {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

@keyframes slideOutUp {
  from {
    -webkit-transform: translate3d(0, 0, 0);
    transform: translate3d(0, 0, 0);
  }

  to {
    visibility: hidden;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
}

.slideOutUp {
  -webkit-animation-name: slideOutUp;
  animation-name: slideOutUp;
}

.animated {
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-fill-mode: both;
  animation-fill-mode: both;
}

.animated.infinite {
  -webkit-animation-iteration-count: infinite;
  animation-iteration-count: infinite;
}

.animated.delay-1s {
  -webkit-animation-delay: 1s;
  animation-delay: 1s;
}

.animated.delay-2s {
  -webkit-animation-delay: 2s;
  animation-delay: 2s;
}

.animated.delay-3s {
  -webkit-animation-delay: 3s;
  animation-delay: 3s;
}

.animated.delay-4s {
  -webkit-animation-delay: 4s;
  animation-delay: 4s;
}

.animated.delay-5s {
  -webkit-animation-delay: 5s;
  animation-delay: 5s;
}

.animated.fast {
  -webkit-animation-duration: 800ms;
  animation-duration: 800ms;
}

.animated.faster {
  -webkit-animation-duration: 500ms;
  animation-duration: 500ms;
}

.animated.slow {
  -webkit-animation-duration: 2s;
  animation-duration: 2s;
}

.animated.slower {
  -webkit-animation-duration: 3s;
  animation-duration: 3s;
}

@media (prefers-reduced-motion) {
  .animated {
    -webkit-animation: unset !important;
    animation: unset !important;
    -webkit-transition: none !important;
    transition: none !important;
  }
}

body.compensate-for-scrollbar {
  overflow: hidden; }

.fancybox-active {
  height: auto; }

.fancybox-is-hidden {
  left: -9999px;
  margin: 0;
  position: absolute !important;
  top: -9999px;
  visibility: hidden; }

.fancybox-container {
  -webkit-backface-visibility: hidden;
  height: 100%;
  left: 0;
  outline: none;
  position: fixed;
  -webkit-tap-highlight-color: transparent;
  top: 0;
  -ms-touch-action: manipulation;
  touch-action: manipulation;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  width: 100%;
  z-index: 99992; }

.fancybox-container * {
  box-sizing: border-box; }

.fancybox-outer,
.fancybox-inner,
.fancybox-bg,
.fancybox-stage {
  bottom: 0;
  left: 0;
  position: absolute;
  right: 0;
  top: 0; }

.fancybox-outer {
  -webkit-overflow-scrolling: touch;
  overflow-y: auto; }

.fancybox-bg {
  background: #1e1e1e;
  opacity: 0;
  transition-duration: inherit;
  transition-property: opacity;
  transition-timing-function: cubic-bezier(0.47, 0, 0.74, 0.71); }

.fancybox-is-open .fancybox-bg {
  opacity: .9;
  transition-timing-function: cubic-bezier(0.22, 0.61, 0.36, 1); }

.fancybox-infobar,
.fancybox-toolbar,
.fancybox-caption,
.fancybox-navigation .fancybox-button {
  direction: ltr;
  opacity: 0;
  position: absolute;
  transition: opacity .25s ease, visibility 0s ease .25s;
  visibility: hidden;
  z-index: 99997; }

.fancybox-show-infobar .fancybox-infobar,
.fancybox-show-toolbar .fancybox-toolbar,
.fancybox-show-caption .fancybox-caption,
.fancybox-show-nav .fancybox-navigation .fancybox-button {
  opacity: 1;
  transition: opacity .25s ease 0s, visibility 0s ease 0s;
  visibility: visible; }

.fancybox-infobar {
  color: #ccc;
  font-size: 13px;
  -webkit-font-smoothing: subpixel-antialiased;
  height: 44px;
  left: 0;
  line-height: 44px;
  min-width: 44px;
  mix-blend-mode: difference;
  padding: 0 10px;
  pointer-events: none;
  top: 0;
  -webkit-touch-callout: none;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none; }

.fancybox-toolbar {
  right: 0;
  top: 0; }

.fancybox-stage {
  direction: ltr;
  overflow: visible;
  -webkit-transform: translateZ(0);
  transform: translateZ(0);
  z-index: 99994; }

.fancybox-is-open .fancybox-stage {
  overflow: hidden; }

.fancybox-slide {
  -webkit-backface-visibility: hidden;
  /* Using without prefix would break IE11 */
  display: none;
  height: 100%;
  left: 0;
  outline: none;
  overflow: auto;
  -webkit-overflow-scrolling: touch;
  padding: 44px;
  position: absolute;
  text-align: center;
  top: 0;
  transition-property: opacity, -webkit-transform;
  transition-property: transform, opacity;
  transition-property: transform, opacity, -webkit-transform;
  white-space: normal;
  width: 100%;
  z-index: 99994; }

.fancybox-slide::before {
  content: '';
  display: inline-block;
  font-size: 0;
  height: 100%;
  vertical-align: middle;
  width: 0; }

.fancybox-is-sliding .fancybox-slide,
.fancybox-slide--previous,
.fancybox-slide--current,
.fancybox-slide--next {
  display: block; }

.fancybox-slide--image {
  overflow: hidden;
  padding: 44px 0; }

.fancybox-slide--image::before {
  display: none; }

.fancybox-slide--html {
  padding: 6px; }

.fancybox-content {
  background: #fff;
  display: inline-block;
  margin: 0;
  max-width: 100%;
  overflow: auto;
  -webkit-overflow-scrolling: touch;
  padding: 44px;
  position: relative;
  text-align: left;
  vertical-align: middle; }

.fancybox-slide--image .fancybox-content {
  -webkit-animation-timing-function: cubic-bezier(0.5, 0, 0.14, 1);
  animation-timing-function: cubic-bezier(0.5, 0, 0.14, 1);
  -webkit-backface-visibility: hidden;
  background: transparent;
  background-repeat: no-repeat;
  background-size: 100% 100%;
  left: 0;
  max-width: none;
  overflow: visible;
  padding: 0;
  position: absolute;
  top: 0;
  -webkit-transform-origin: top left;
  -ms-transform-origin: top left;
  transform-origin: top left;
  transition-property: opacity, -webkit-transform;
  transition-property: transform, opacity;
  transition-property: transform, opacity, -webkit-transform;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  z-index: 99995; }

.fancybox-can-zoomOut .fancybox-content {
  cursor: -webkit-zoom-out;
  cursor: zoom-out; }

.fancybox-can-zoomIn .fancybox-content {
  cursor: -webkit-zoom-in;
  cursor: zoom-in; }

.fancybox-can-swipe .fancybox-content,
.fancybox-can-pan .fancybox-content {
  cursor: -webkit-grab;
  cursor: grab; }

.fancybox-is-grabbing .fancybox-content {
  cursor: -webkit-grabbing;
  cursor: grabbing; }

.fancybox-container [data-selectable='true'] {
  cursor: text; }

.fancybox-image,
.fancybox-spaceball {
  background: transparent;
  border: 0;
  height: 100%;
  left: 0;
  margin: 0;
  max-height: none;
  max-width: none;
  padding: 0;
  position: absolute;
  top: 0;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  width: 100%; }

.fancybox-spaceball {
  z-index: 1; }

.fancybox-slide--video .fancybox-content,
.fancybox-slide--map .fancybox-content,
.fancybox-slide--pdf .fancybox-content,
.fancybox-slide--iframe .fancybox-content {
  height: 100%;
  overflow: visible;
  padding: 0;
  width: 100%; }

.fancybox-slide--video .fancybox-content {
  background: #000; }

.fancybox-slide--map .fancybox-content {
  background: #e5e3df; }

.fancybox-slide--iframe .fancybox-content {
  background: #fff; }

.fancybox-video,
.fancybox-iframe {
  background: transparent;
  border: 0;
  display: block;
  height: 100%;
  margin: 0;
  overflow: hidden;
  padding: 0;
  width: 100%; }

/* Fix iOS */
.fancybox-iframe {
  left: 0;
  position: absolute;
  top: 0; }

.fancybox-error {
  background: #fff;
  cursor: default;
  max-width: 400px;
  padding: 40px;
  width: 100%; }

.fancybox-error p {
  color: #444;
  font-size: 16px;
  line-height: 20px;
  margin: 0;
  padding: 0; }

/* Buttons */
.fancybox-button {
  background: rgba(30, 30, 30, 0.6);
  border: 0;
  border-radius: 0;
  box-shadow: none;
  cursor: pointer;
  display: inline-block;
  height: 44px;
  margin: 0;
  padding: 10px;
  position: relative;
  transition: color .2s;
  vertical-align: top;
  visibility: inherit;
  width: 44px; }

.fancybox-button,
.fancybox-button:visited,
.fancybox-button:link {
  color: #ccc; }

.fancybox-button:hover {
  color: #fff; }

.fancybox-button:focus {
  outline: none; }

.fancybox-button.fancybox-focus {
  outline: 1px dotted; }

.fancybox-button[disabled],
.fancybox-button[disabled]:hover {
  color: #888;
  cursor: default;
  outline: none; }

/* Fix IE11 */
.fancybox-button div {
  height: 100%; }

.fancybox-button svg {
  display: block;
  height: 100%;
  overflow: visible;
  position: relative;
  width: 100%; }

.fancybox-button svg path {
  fill: currentColor;
  stroke-width: 0; }

.fancybox-button--play svg:nth-child(2),
.fancybox-button--fsenter svg:nth-child(2) {
  display: none; }

.fancybox-button--pause svg:nth-child(1),
.fancybox-button--fsexit svg:nth-child(1) {
  display: none; }

.fancybox-progress {
  background: #ff5268;
  height: 2px;
  left: 0;
  position: absolute;
  right: 0;
  top: 0;
  -webkit-transform: scaleX(0);
  -ms-transform: scaleX(0);
  transform: scaleX(0);
  -webkit-transform-origin: 0;
  -ms-transform-origin: 0;
  transform-origin: 0;
  transition-property: -webkit-transform;
  transition-property: transform;
  transition-property: transform, -webkit-transform;
  transition-timing-function: linear;
  z-index: 99998; }

/* Close button on the top right corner of html content */
.fancybox-close-small {
  background: transparent;
  border: 0;
  border-radius: 0;
  color: #ccc;
  cursor: pointer;
  opacity: .8;
  padding: 8px;
  position: absolute;
  right: -12px;
  top: -44px;
  z-index: 401; }

.fancybox-close-small:hover {
  color: #fff;
  opacity: 1; }

.fancybox-slide--html .fancybox-close-small {
  color: currentColor;
  padding: 10px;
  right: 0;
  top: 0; }

.fancybox-slide--image.fancybox-is-scaling .fancybox-content {
  overflow: hidden; }

.fancybox-is-scaling .fancybox-close-small,
.fancybox-is-zoomable.fancybox-can-pan .fancybox-close-small {
  display: none; }

/* Navigation arrows */
.fancybox-navigation .fancybox-button {
  background-clip: content-box;
  height: 100px;
  opacity: 0;
  position: absolute;
  top: calc(50% - 50px);
  width: 70px; }

.fancybox-navigation .fancybox-button div {
  padding: 7px; }

.fancybox-navigation .fancybox-button--arrow_left {
  left: 0;
  left: env(safe-area-inset-left);
  padding: 31px 26px 31px 6px; }

.fancybox-navigation .fancybox-button--arrow_right {
  padding: 31px 6px 31px 26px;
  right: 0;
  right: env(safe-area-inset-right); }

/* Caption */
.fancybox-caption {
  background: linear-gradient(to top, rgba(0, 0, 0, 0.85) 0%, rgba(0, 0, 0, 0.3) 50%, rgba(0, 0, 0, 0.15) 65%, rgba(0, 0, 0, 0.075) 75.5%, rgba(0, 0, 0, 0.037) 82.85%, rgba(0, 0, 0, 0.019) 88%, transparent 100%);
  bottom: 0;
  color: #eee;
  font-size: 14px;
  font-weight: 400;
  left: 0;
  line-height: 1.5;
  overflow: auto;
  padding: 50px 44px 25px 44px;
  right: 0;
  text-align: center;
  z-index: 99996; }

.fancybox-caption--separate {
  margin-top: -25px;
  max-height: 50vh; }

.fancybox-caption a,
.fancybox-caption a:link,
.fancybox-caption a:visited {
  color: #ccc;
  text-decoration: none; }

.fancybox-caption a:hover {
  color: #fff;
  text-decoration: underline; }

/* Loading indicator */
.fancybox-loading {
  -webkit-animation: fancybox-rotate 1s linear infinite;
  animation: fancybox-rotate 1s linear infinite;
  background: transparent;
  border: 4px solid #888;
  border-bottom-color: #fff;
  border-radius: 50%;
  height: 50px;
  left: 50%;
  margin: -25px 0 0 -25px;
  opacity: .7;
  padding: 0;
  position: absolute;
  top: 50%;
  width: 50px;
  z-index: 99999; }

@-webkit-keyframes fancybox-rotate {
  100% {
    -webkit-transform: rotate(360deg);
    transform: rotate(360deg); } }

@keyframes fancybox-rotate {
  100% {
    -webkit-transform: rotate(360deg);
    transform: rotate(360deg); } }

/* Transition effects */
.fancybox-animated {
  transition-timing-function: cubic-bezier(0, 0, 0.25, 1); }

/* transitionEffect: slide */
.fancybox-fx-slide.fancybox-slide--previous {
  opacity: 0;
  -webkit-transform: translate3d(-100%, 0, 0);
  transform: translate3d(-100%, 0, 0); }

.fancybox-fx-slide.fancybox-slide--next {
  opacity: 0;
  -webkit-transform: translate3d(100%, 0, 0);
  transform: translate3d(100%, 0, 0); }

.fancybox-fx-slide.fancybox-slide--current {
  opacity: 1;
  -webkit-transform: translate3d(0, 0, 0);
  transform: translate3d(0, 0, 0); }

/* transitionEffect: fade */
.fancybox-fx-fade.fancybox-slide--previous,
.fancybox-fx-fade.fancybox-slide--next {
  opacity: 0;
  transition-timing-function: cubic-bezier(0.19, 1, 0.22, 1); }

.fancybox-fx-fade.fancybox-slide--current {
  opacity: 1; }

/* transitionEffect: zoom-in-out */
.fancybox-fx-zoom-in-out.fancybox-slide--previous {
  opacity: 0;
  -webkit-transform: scale3d(1.5, 1.5, 1.5);
  transform: scale3d(1.5, 1.5, 1.5); }

.fancybox-fx-zoom-in-out.fancybox-slide--next {
  opacity: 0;
  -webkit-transform: scale3d(0.5, 0.5, 0.5);
  transform: scale3d(0.5, 0.5, 0.5); }

.fancybox-fx-zoom-in-out.fancybox-slide--current {
  opacity: 1;
  -webkit-transform: scale3d(1, 1, 1);
  transform: scale3d(1, 1, 1); }

/* transitionEffect: rotate */
.fancybox-fx-rotate.fancybox-slide--previous {
  opacity: 0;
  -webkit-transform: rotate(-360deg);
  -ms-transform: rotate(-360deg);
  transform: rotate(-360deg); }

.fancybox-fx-rotate.fancybox-slide--next {
  opacity: 0;
  -webkit-transform: rotate(360deg);
  -ms-transform: rotate(360deg);
  transform: rotate(360deg); }

.fancybox-fx-rotate.fancybox-slide--current {
  opacity: 1;
  -webkit-transform: rotate(0deg);
  -ms-transform: rotate(0deg);
  transform: rotate(0deg); }

/* transitionEffect: circular */
.fancybox-fx-circular.fancybox-slide--previous {
  opacity: 0;
  -webkit-transform: scale3d(0, 0, 0) translate3d(-100%, 0, 0);
  transform: scale3d(0, 0, 0) translate3d(-100%, 0, 0); }

.fancybox-fx-circular.fancybox-slide--next {
  opacity: 0;
  -webkit-transform: scale3d(0, 0, 0) translate3d(100%, 0, 0);
  transform: scale3d(0, 0, 0) translate3d(100%, 0, 0); }

.fancybox-fx-circular.fancybox-slide--current {
  opacity: 1;
  -webkit-transform: scale3d(1, 1, 1) translate3d(0, 0, 0);
  transform: scale3d(1, 1, 1) translate3d(0, 0, 0); }

/* transitionEffect: tube */
.fancybox-fx-tube.fancybox-slide--previous {
  -webkit-transform: translate3d(-100%, 0, 0) scale(0.1) skew(-10deg);
  transform: translate3d(-100%, 0, 0) scale(0.1) skew(-10deg); }

.fancybox-fx-tube.fancybox-slide--next {
  -webkit-transform: translate3d(100%, 0, 0) scale(0.1) skew(10deg);
  transform: translate3d(100%, 0, 0) scale(0.1) skew(10deg); }

.fancybox-fx-tube.fancybox-slide--current {
  -webkit-transform: translate3d(0, 0, 0) scale(1);
  transform: translate3d(0, 0, 0) scale(1); }

/* Styling for Small-Screen Devices */
@media all and (max-height: 576px) {
  .fancybox-caption {
    padding-left: 12px;
    padding-right: 12px; }
  .fancybox-slide {
    padding-left: 6px;
    padding-right: 6px; }
  .fancybox-slide--image {
    padding: 6px 0; }
  .fancybox-close-small {
    right: -6px; }
  .fancybox-slide--image .fancybox-close-small {
    background: #4e4e4e;
    color: #f2f4f6;
    height: 36px;
    opacity: 1;
    padding: 6px;
    right: 0;
    top: 0;
    width: 36px; } }

/* Using calc to trick sass */
@supports (padding: 0px) {
  .fancybox-caption {
    padding: 50px calc(max(12px, env(safe-area-inset-right))) calc(max(12px, env(safe-area-inset-bottom))) calc(max(25px, env(safe-area-inset-left))); } }

/* Share */
.fancybox-share {
  background: #f4f4f4;
  border-radius: 3px;
  max-width: 90%;
  padding: 30px;
  text-align: center; }

.fancybox-share h1 {
  color: #222;
  font-size: 35px;
  font-weight: 700;
  margin: 0 0 20px 0; }

.fancybox-share p {
  margin: 0;
  padding: 0; }

.fancybox-share__button {
  border: 0;
  border-radius: 3px;
  display: inline-block;
  font-size: 14px;
  font-weight: 700;
  line-height: 40px;
  margin: 0 5px 10px 5px;
  min-width: 130px;
  padding: 0 15px;
  text-decoration: none;
  transition: all .2s;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  white-space: nowrap; }

.fancybox-share__button:visited,
.fancybox-share__button:link {
  color: #fff; }

.fancybox-share__button:hover {
  text-decoration: none; }

.fancybox-share__button--fb {
  background: #3b5998; }

.fancybox-share__button--fb:hover {
  background: #344e86; }

.fancybox-share__button--pt {
  background: #bd081d; }

.fancybox-share__button--pt:hover {
  background: #aa0719; }

.fancybox-share__button--tw {
  background: #1da1f2; }

.fancybox-share__button--tw:hover {
  background: #0d95e8; }

.fancybox-share__button svg {
  height: 25px;
  margin-right: 7px;
  position: relative;
  top: -1px;
  vertical-align: middle;
  width: 25px; }

.fancybox-share__button svg path {
  fill: #fff; }

.fancybox-share__input {
  background: transparent;
  border: 0;
  border-bottom: 1px solid #d7d7d7;
  border-radius: 0;
  color: #5d5b5b;
  font-size: 14px;
  margin: 10px 0 0 0;
  outline: none;
  padding: 10px 15px;
  width: 100%; }

/* Thumbs */
.fancybox-thumbs {
  background: #ddd;
  bottom: 0;
  display: none;
  margin: 0;
  -webkit-overflow-scrolling: touch;
  -ms-overflow-style: -ms-autohiding-scrollbar;
  padding: 2px 2px 4px 2px;
  position: absolute;
  right: 0;
  -webkit-tap-highlight-color: transparent;
  top: 0;
  width: 212px;
  z-index: 99995; }

.fancybox-thumbs-x {
  overflow-x: auto;
  overflow-y: hidden; }

.fancybox-show-thumbs .fancybox-thumbs {
  display: block; }

.fancybox-show-thumbs .fancybox-inner {
  right: 212px; }

.fancybox-thumbs__list {
  font-size: 0;
  height: 100%;
  list-style: none;
  margin: 0;
  overflow-x: hidden;
  overflow-y: auto;
  padding: 0;
  position: absolute;
  position: relative;
  white-space: nowrap;
  width: 100%; }

.fancybox-thumbs-x .fancybox-thumbs__list {
  overflow: hidden; }

.fancybox-thumbs-y .fancybox-thumbs__list::-webkit-scrollbar {
  width: 7px; }

.fancybox-thumbs-y .fancybox-thumbs__list::-webkit-scrollbar-track {
  background: #fff;
  border-radius: 10px;
  box-shadow: inset 0 0 6px rgba(0, 0, 0, 0.3); }

.fancybox-thumbs-y .fancybox-thumbs__list::-webkit-scrollbar-thumb {
  background: #2a2a2a;
  border-radius: 10px; }

.fancybox-thumbs__list a {
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  background-color: rgba(0, 0, 0, 0.1);
  background-position: center center;
  background-repeat: no-repeat;
  background-size: cover;
  cursor: pointer;
  float: left;
  height: 75px;
  margin: 2px;
  max-height: calc(100% - 8px);
  max-width: calc(50% - 4px);
  outline: none;
  overflow: hidden;
  padding: 0;
  position: relative;
  -webkit-tap-highlight-color: transparent;
  width: 100px; }

.fancybox-thumbs__list a::before {
  border: 6px solid #ff5268;
  bottom: 0;
  content: '';
  left: 0;
  opacity: 0;
  position: absolute;
  right: 0;
  top: 0;
  transition: all 0.2s cubic-bezier(0.25, 0.46, 0.45, 0.94);
  z-index: 99991; }

.fancybox-thumbs__list a:focus::before {
  opacity: .5; }

.fancybox-thumbs__list a.fancybox-thumbs-active::before {
  opacity: 1; }

/* Styling for Small-Screen Devices */
@media all and (max-width: 576px) {
  .fancybox-thumbs {
    width: 110px; }
  .fancybox-show-thumbs .fancybox-inner {
    right: 110px; }
  .fancybox-thumbs__list a {
    max-width: calc(100% - 10px); } }

.loader {
    position: relative;
    float:left;
    user-select: none;
    box-sizing: border-box;
    width: 150px;
    height: 150px;
}
.loader-bg {
    width: 100%;
    height: 100%;
    border-radius: 50%;
    box-sizing: border-box;
    border: 5px solid #eeeeee;
    display: flex;
    align-items: center;
    justify-content: center;
}
.spinner-holder-one {
    position: absolute;
    top:0;
    left:0;
    overflow: hidden;
    width: 50%;
    height: 50%;
    background: transparent;
    box-sizing: border-box;
}
.spinner-holder-two {
    position: absolute;
    top:0;
    left:0;
    overflow: hidden;
    width: 100%;
    height: 100%;
    background: transparent;
    box-sizing: border-box;
}
.loader-spinner {
    width: 200%;
    height: 200%;
    border-radius: 50%;
    border: 5px solid rgb(135, 206, 235);
    box-sizing: border-box;
}  
  .animate-0-25-a {
    transform: rotate(90deg);
    transform-origin: 100% 100%;
}
.animate-0-25-b {
    transform: rotate(-90deg);
    transform-origin: 100% 100%;
}
.animate-25-50-a {
    transform: rotate(180deg);
    transform-origin: 100% 100%;
}
.animate-25-50-b {
    transform: rotate(-90deg);
    transform-origin: 100% 100%;
}
.animate-50-75-a {
    transform: rotate(270deg);
    transform-origin: 100% 100%;
}
.animate-50-75-b {
    transform: rotate(-90deg);
    transform-origin:100% 100%;
}
.animate-75-100-a {
    transform: rotate(0deg);
    transform-origin: 100% 100%;
}
.animate-75-100-b {
    transform: rotate(-90deg);
    transform-origin: 100% 100%;
}
.text {
    text-align: center;
    font-size: 20px;
    color: rgb(135, 206, 235);
    font-weight: bold;  
}
/* --------------- VARIABLES --------------- */

.foxplay--ui-button,
header.foxplay--header .foxplay--header-action .foxplay--button,
.foxplay--page-404 .foxplay--button,
.foxplay--login-container .foxplay--user-action-result .foxplay--user-action-result-button,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-action-button,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .foxplay--user-area-content-row-action-button {
  -webkit-box-shadow: 0px 4px 20px 0px rgba(237, 44, 36, 0.45);
  box-shadow: 0px 4px 20px 0px rgba(237, 44, 36, 0.45);
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--ui-button:hover,
header.foxplay--header .foxplay--header-action .foxplay--button:hover,
.foxplay--page-404 .foxplay--button:hover,
.foxplay--login-container .foxplay--user-action-result .foxplay--user-action-result-button:hover,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-action-button:hover,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .foxplay--user-area-content-row-action-button:hover {
  -webkit-box-shadow: 0px 0px 0px 0px rgba(237, 44, 36, 0.45);
  box-shadow: 0px 0px 0px 0px rgba(237, 44, 36, 0.45);
}

.foxplay--ui-button,
header.foxplay--header .foxplay--header-action .foxplay--button,
.foxplay--page-404 .foxplay--button,
.foxplay--login-container .foxplay--user-action-result .foxplay--user-action-result-button,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-action-button,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .foxplay--user-area-content-row-action-button {
  min-width: 6em;
  background: #ed2c24;
  font-size: 0.8em;
  color: #FFFFFF;
  text-align: center;
  display: inline-block;
  vertical-align: middle;
  padding: 0.9em 1em;
  text-decoration: none;
  border-top-left-radius: 50px;
  border-top-right-radius: 50px;
  border-bottom-left-radius: 50px;
  border-bottom-right-radius: 50px;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.transparent.foxplay--ui-button,
header.foxplay--header .foxplay--header-action .transparent.foxplay--button,
.foxplay--page-404 .transparent.foxplay--button,
.foxplay--login-container .foxplay--user-action-result .transparent.foxplay--user-action-result-button,
.foxplay--user-area-container .foxplay--user-area-content .transparent.foxplay--user-area-action-button,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .transparent.foxplay--user-area-content-row-action-button {
  color: #FFFFFF;
  font-size: 0.9em;
  font-family: 'Saira';
  font-weight: 400;
  min-width: 200px;
  background: transparent;
  border: 0;
  outline: 0;
  cursor: pointer;
  margin-top: 3em;
  padding: 12px 1em;
  -webkit-box-shadow: 0px 0px 0px 1px 255, 255, 255, 0.2;
  box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.2);
}

.transparent.foxplay--ui-button:hover,
header.foxplay--header .foxplay--header-action .transparent.foxplay--button:hover,
.foxplay--page-404 .transparent.foxplay--button:hover,
.foxplay--login-container .foxplay--user-action-result .transparent.foxplay--user-action-result-button:hover,
.foxplay--user-area-container .foxplay--user-area-content .transparent.foxplay--user-area-action-button:hover,
.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .transparent.foxplay--user-area-content-row-action-button:hover {
  opacity: 0.7;
  -webkit-box-shadow: 0px 0px 0px 1px #ed2c24;
  box-shadow: 0px 0px 0px 1px #ed2c24;
}

.red-play,
.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a .foxplay--ui-button-play {
  width: 2em;
  height: 2em;
  background: transparent;
  border: 0;
  outline: 0;
  color: #FFFFFF;
  font-size: 1em;
  position: relative;
  cursor: pointer;
  padding: 0;
  margin: 0;
  overflow: visible;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.red-play i,
.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a .foxplay--ui-button-play i {
  width: 100%;
  height: 100%;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 3;
  margin: 0;
  font-size: 0.7em;
  line-height: 4.2em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.red-play i::before,
.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a .foxplay--ui-button-play i::before {
  width: 100%;
  height: 100%;
  position: absolute;
  left: 0;
  top: 0;
  font-size: 0.7em;
  line-height: 4.2em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -webkit-transition: all 0.18s ease-out;
  transition: all 0.18s ease-out;
}

.red-play .foxplay--ui-button-play-circle,
.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a .foxplay--ui-button-play .foxplay--ui-button-play-circle {
  width: 2em;
  height: 2em;
  position: relative;
  z-index: -1;
  -webkit-transform: scale(1);
          transform: scale(1);
  -webkit-box-shadow: 0px 0px 0px 1px white;
  box-shadow: 0px 0px 0px 1px white;
  -webkit-transition: all 0.12s ease-out;
  transition: all 0.12s ease-out;
  border-top-left-radius: 20em;
  border-top-right-radius: 20em;
  border-bottom-left-radius: 20em;
  border-bottom-right-radius: 20em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a .foxplay--ui-button-play:hover .foxplay--ui-button-play-circle {
  background: #ed2c24;
  opacity: 1;
  -webkit-box-shadow: 0px 0px 0px 1px transparent;
  box-shadow: 0px 0px 0px 1px transparent;
}

.red-play {
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

.red-play:hover .foxplay--ui-button-play-circle {
  -webkit-transform: scale(1.1);
          transform: scale(1.1);
  background: #ed2c24;
  opacity: 1;
  -webkit-box-shadow: 0px 0px 0px 1px #ed2c24;
  box-shadow: 0px 0px 0px 1px #ed2c24;
}

header.foxplay--header .foxplay--search-content,
header.foxplay--header .foxplay--search-content .foxplay--search-content-result,
.foxplay--header-sub-nav,
.foxplay--header-sub-nav .foxplay--header-sub-nav-promo footer,
.foxplay--main-slider,
.foxplay--main-slider .foxplay--main-slider-text,
.foxplay--owl-type-one .owl-stage-outer .owl-stage .owl-item,
.foxplay--owl-type-one .foxplay--owl-type-one-information footer,
.foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item,
.foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item.owl-active img,
.foxplay--owl-type-two .foxplay--owl-type-two-information footer,
.foxplay--data-container .foxplay--tweetarea,
.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content,
.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content .foxplay--grid-view-item-content-fly,
.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer,
.foxplay--data-container aside,
.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information,
.foxplay--mobile-navigation,
.foxplay--user-action,
.foxplay--user-action label input[type="text"],
.foxplay--user-action label input[type="password"],
.foxplay--user-action label input[type="email"],
.foxplay--user-action label textarea,
.foxplay--user-action label input[type="submit"],
.foxplay--user-action footer .foxplay--user-action-button,
.foxplay--login-container .foxplay--login-container-col,
.foxplay--tab .foxplay--tab-container .foxplay--user-area-action-button,
.foxplay--ui-text-scheme ul,
.foxplay--ui-text-scheme table tr th,
.foxplay--ui-text-scheme table tr td {
  -webkit-box-sizing: border-box;
  box-sizing: border-box;
}

/* Feedback Conent */

#feedback-form.fancybox-content {
  width: auto;
}

.feed-close-modal {
  width: 26px;
  height: 26px;
  position: absolute;
  right: 10px;
  top: 10px;
  background-image: url(/images/feedback-content-close-icon.svg?5f33bf58e837589466658989672d999c);
  background-repeat: no-repeat;
  background-position: right;
  background-size: 100%;
  cursor: pointer;
}

.feed-content-form {
  display: none;
}

.feedback-content {
  width: 70px;
  height: 185px;
  background-image: url(/images/feedback-img.svg?152fe01f126b601ad0d5cc344d7be18b);
  background-repeat: no-repeat;
  background-position: left;
  background-size: 100%;
  position: fixed;
  right: -20px;
  bottom: 50px;
  cursor: pointer;
  z-index: 9;
  display: none;
}

.feedback-content-form {
  display: none;
}

.feedback-content.active {
  display: block;
}

.feedback-content-click {
  width: 286px;
  height: 166px;
  background-repeat: no-repeat;
  background-position: right;
  position: fixed;
  right: -100%;
  bottom: 50px;
  -webkit-transition: .2s;
  transition: .2s;
  padding: 26px;
  border-top-left-radius: 40px;
  border-bottom-left-radius: 40px;
  -webkit-box-sizing: border-box;
          box-sizing: border-box;
  background-color: #fc2110;
  z-index: 999999;
}

.feedback-content-click.active {
  right: 0;
  -webkit-transition: .2s;
  transition: .2s;
}

.feedback-content-click-close {
  width: 26px;
  height: 26px;
  position: absolute;
  right: 15px;
  top: 15px;
  background-image: url(/images/feedback-content-close-icon.svg?5f33bf58e837589466658989672d999c);
  background-repeat: no-repeat;
  background-position: right;
  cursor: pointer;
}

.feedback-content-click p {
  font-size: .8em;
  font-weight: 300;
  line-height: 1.4em;
}

.feedback-content-click p:first-child {
  font-weight: 700;
  margin-bottom: 12px;
  font-size: 18px;
}

.feedback-content-click-modal-open {
  padding: 12px 50px;
  color: #FC2112;
  border-radius: 30px;
  text-decoration: none;
  background-color: black;
  margin-top: 16px;
  display: block;
  width: -webkit-max-content;
  width: -moz-max-content;
  width: max-content;
  background-color: #fff;
  font-weight: 500;
}

.check-line-fix {
  line-height: 1;
}

.feedback-thanks {
  display: none;
  width: 100%;
  height: 100%;
  position: fixed;
  background-color: #111111;
  /* display: none; */
  z-index: 9999;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-box-align: center;
      -ms-flex-align: center;
          align-items: center;
  color: black;
  top: 0;
}

.feedback-thanks-close {
  width: 26px;
  height: 26px;
  position: absolute;
  right: 10px;
  top: 10px;
  background-image: url(/images/feedback-content-close-icon.svg?5f33bf58e837589466658989672d999c);
  background-repeat: no-repeat;
  background-position: right;
  background-size: 100%;
  cursor: pointer;
}

.feedback-thanks.active {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
}

.feedback-thanks .thanks-tick img {
  max-width: 65px;
}

.feedback-thanks-background {
  width: -webkit-max-content;
  width: -moz-max-content;
  width: max-content;
  padding: 30px;
  text-align: center;
  font-size: 14px;
  position: relative;
}

.feedback-thanks-background p {
  font-size: 15px;
  line-height: 30px;
  color: #fff;
}

/* Feedback Conent  */

.foxplay--ui-button i {
  font-size: 0.7em;
  display: inline-block;
  vertical-align: middle;
  margin: -0.3em 0 0 0.5em;
}

.foxplay--dropdown {
  border: 1px solid rgba(255, 255, 255, 0.1);
  overflow: hidden;
  position: relative;
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
}

.foxplay--dropdown button {
  min-width: 10rem;
  background: transparent;
  border: 0;
  outline: 0;
  padding: 1em 3.5em 1em 1.7em;
  display: inline-block;
  position: relative;
  z-index: 1;
  cursor: pointer;
  color: #FFFFFF;
  font-size: 0.65em;
  font-weight: 200;
  text-align: left;
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
}

.foxplay--dropdown button::after {
  content: 'I';
  color: #ed2c24;
  font-size: 0.7em;
  font-family: 'FOXPLAY';
  position: absolute;
  right: 2em;
  top: 50%;
  -webkit-transform: translateY(-50%);
          transform: translateY(-50%);
  z-index: 1;
}

.foxplay--dropdown select {
  width: 100%;
  height: 100%;
  background: transparent;
  border: 0;
  outline: 0;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 2;
  opacity: 0;
  cursor: pointer;
}

.foxplay--dropdown.dark-theme {
  border: 0;
  border-top-left-radius: 0.6em;
  border-top-right-radius: 0.6em;
  border-bottom-left-radius: 0.6em;
  border-bottom-right-radius: 0.6em;
  background: #000000;
  display: none;
}

.foxplay--dropdown.dark-theme button {
  width: 100%;
  font-size: 1em;
}

@-webkit-keyframes spinner {
  from {
    -webkit-transform: rotateY(0deg);
  }

  to {
    -webkit-transform: rotateY(-360deg);
  }
}

@keyframes spinner {
  from {
    -webkit-transform: rotateY(0deg);
            transform: rotateY(0deg);
  }

  to {
    -webkit-transform: rotateY(-360deg);
            transform: rotateY(-360deg);
  }
}

/* --------------- VARIABLES --------------- */

html {
  width: 100%;
  height: 100%;
}

body {
  width: 100%;
  height: 100%;
  min-width: 320px;
  min-height: 480px;
  margin: 0 !important;
  padding: 0 !important;
  background: #161616;
  color: #FFFFFF;
  font-size: 18px;
  font-family: 'Saira', sans-serif;
  font-weight: 400;
}

h1 {
  font-size: 2em;
}

h2 {
  font-size: 1.5em;
}

h3 {
  font-size: 1.17em;
}

h4 {
  font-size: 1em;
}

h5 {
  font-size: .83em;
}

h6 {
  font-size: .67em;
}

.space-1 {
  margin: 1em 0;
}

.space-2 {
  margin: 2em 0;
}

.space-3 {
  margin: 3em 0;
}

.space-4 {
  margin: 4em 0;
}

.space-5 {
  margin: 5em 0;
}

.space-6 {
  margin: 6em 0;
}

* {
  -webkit-font-smoothing: antialiased;
  text-rendering: optimizeLegibility;
  line-height: 1;
}

#foxplay--app {
  width: 100%;
  height: 100%;
}

#foxplay--app.no-scroll {
  overflow: hidden;
  position: fixed;
  left: 0;
  top: 0;
}

.auth header.foxplay--header .foxplay--brand {
  margin: 1.2em auto;
  width: 120px;
  float: none;
}

.auth header.foxplay--header .foxplay--header-action {
  margin-top: -2.4em;
}

.foxplay--preloader {
  width: 100%;
  height: 100%;
  background: #161616 url(/images/foxplay--logo.svg?8152a8f2ed77e605117b4064de3b57f0) no-repeat center center;
  background-size: 200px;
  position: fixed;
  left: 0;
  top: 0;
  z-index: 99999;
  display: none;
}

.img-responsive {
  width: auto;
  max-width: 100%;
  display: block;
}

.red-play {
  position: absolute;
  z-index: 10;
  left: 0;
  top: 0;
  right: 0;
  bottom: 0;
  margin: auto;
  font-size: 2.4em;
  overflow: visible;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.red-play .foxplay--ui-button-play-circle {
  background: #ed2c24;
  opacity: 1;
  display: inline-block;
  overflow: visible;
  -webkit-box-shadow: 0px 0px 0px 0px #ed2c24;
  box-shadow: 0px 0px 0px 0px #ed2c24;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.red-play .foxplay--ui-button-play-circle .foxplay--ui-button-play-circle-line {
  width: 2em;
  height: 2em;
  position: absolute;
  left: 0;
  top: 0;
  opacity: 0.6;
  z-index: 0;
  -webkit-transform: scale(1.4);
          transform: scale(1.4);
  -webkit-box-shadow: 0px 0px 0px 1px #ed2c24;
  box-shadow: 0px 0px 0px 1px #ed2c24;
  -webkit-transition: all 0.4s ease-out;
  transition: all 0.4s ease-out;
  border-top-left-radius: 20em;
  border-top-right-radius: 20em;
  border-bottom-left-radius: 20em;
  border-bottom-right-radius: 20em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.red-play:hover .foxplay--ui-button-play-circle .foxplay--ui-button-play-circle-line {
  -webkit-transform: scale(0.5);
          transform: scale(0.5);
}

.red-play.cola-theme {
  width: 100%;
  height: 100%;
  max-width: 50px;
  max-height: 50px;
  background-size: cover !important;
  background: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPHN2ZyB3aWR0aD0iNDBweCIgaGVpZ2h0PSI0MHB4IiB2aWV3Qm94PSIwIDAgNDAgNDAiIHZlcnNpb249IjEuMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayI+CiAgICA8IS0tIEdlbmVyYXRvcjogU2tldGNoIDUzLjIgKDcyNjQzKSAtIGh0dHBzOi8vc2tldGNoYXBwLmNvbSAtLT4KICAgIDx0aXRsZT5Hcm91cCAzMTwvdGl0bGU+CiAgICA8ZGVzYz5DcmVhdGVkIHdpdGggU2tldGNoLjwvZGVzYz4KICAgIDxnIGlkPSJQYWdlLTEiIHN0cm9rZT0ibm9uZSIgc3Ryb2tlLXdpZHRoPSIxIiBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPgogICAgICAgIDxnIGlkPSJHcm91cC0zMSI+CiAgICAgICAgICAgIDxwYXRoIGQ9Ik0zOC44NTE4NTkyLDIyLjk3MzAyODIgTDM4Ljg1MTg1OTIsMjIuOTcyODg3MyBDMzguODUxODU5MiwyMi45NzI3NDY1IDM4Ljg1MTkyOTYsMjIuOTcyNjc2MSAzOC44NTE5Mjk2LDIyLjk3MjYwNTYgQzM5LjA0ODA1NjMsMjEuMTU2OTcxOCAzOS45Njg5NzE4LDIwLjk4OTkyOTYgMzkuOTY4OTcxOCwxOS45ODQ1MDcgQzM5Ljk2ODk3MTgsMTguOTc5MDg0NSAzOS4wNzE0MzY2LDE4LjgyNjgzMSAzOC44NTE5Mjk2LDE2Ljk5NjQwODUgQzM4Ljg1MTkyOTYsMTYuOTk2MzM4IDM4Ljg1MTg1OTIsMTYuOTk2MjY3NiAzOC44NTE4NTkyLDE2Ljk5NjI2NzYgTDM4Ljg1MTg1OTIsMTYuOTk1OTg1OSBDMzguNDc3MzUyMSwxNS4yMDg2NjIgMzkuMzAxNjQ3OSwxNC43NjUyMTEzIDM4Ljk5MDk0MzcsMTMuODA4OTQzNyBDMzguNjgwMTY5LDEyLjg1MjY3NjEgMzcuNzc5NTM1MiwxMi45ODUyODE3IDM3LjAwNTA5ODYsMTEuMzEyMzIzOSBDMzcuMDA1MDk4NiwxMS4zMTIyNTM1IDM3LjAwNTAyODIsMTEuMzEyMjUzNSAzNy4wMDUwMjgyLDExLjMxMjI1MzUgQzM3LjAwNDk1NzcsMTEuMzEyMTgzMSAzNy4wMDQ5NTc3LDExLjMxMjA0MjMgMzcuMDA0ODg3MywxMS4zMTE5NzE4IEMzNi4wOTY0MzY2LDkuNzI3NzQ2NDggMzYuNzQzMzM4LDkuMDUxMzM4MDMgMzYuMTUyMjgxNyw4LjIzNzg4NzMyIEMzNS41NjEyOTU4LDcuNDI0NTA3MDQgMzQuNzQ1NzMyNCw3LjgyODk0MzY2IDMzLjQ5MjIxMTMsNi40NzcxMTI2OCBDMzMuNDkyMjExMyw2LjQ3NzA0MjI1IDMzLjQ5MjE0MDgsNi40NzcwNDIyNSAzMy40OTIwNzA0LDYuNDc2OTcxODMgQzMzLjQ5Miw2LjQ3NjkwMTQxIDMzLjQ5Miw2LjQ3NjgzMDk5IDMzLjQ5MTkyOTYsNi40NzY3NjA1NiBDMzIuMTM4MzM4LDUuMjUwOTE1NDkgMzIuNTQ0NTM1Miw0LjQwNzY3NjA2IDMxLjczMTA4NDUsMy44MTY2OTAxNCBDMzAuOTE3NzA0MiwzLjIyNTcwNDIzIDMwLjI2NywzLjg2MjMyMzk0IDI4LjY1NzA3MDQsMi45NjQwODQ1MSBMMjguNjU2ODU5MiwyLjk2NDAxNDA4IEwyOC42NTY3MTgzLDIuOTYzODczMjQgQzI2Ljk5MDUyMTEsMi4yMTYyNjc2MSAyNy4xMTYyMjU0LDEuMjg4ODAyODIgMjYuMTYwMDI4MiwwLjk3ODA5ODU5MiBDMjUuMjAzODMxLDAuNjY3Mzk0MzY2IDI0Ljc4MTcxODMsMS40NzM5NDM2NiAyMi45NzMwNTYzLDEuMTE3MTEyNjggQzIyLjk3Mjk4NTksMS4xMTcxMTI2OCAyMi45NzI5MTU1LDEuMTE3MTEyNjggMjIuOTcyOTE1NSwxLjExNzExMjY4IEMyMi45NzI3NzQ2LDEuMTE3MTEyNjggMjIuOTcyNzA0MiwxLjExNzExMjY4IDIyLjk3MjYzMzgsMS4xMTcxMTI2OCBDMjEuMTU2OTI5NiwwLjkyMDkxNTQ5MyAyMC45ODk4ODczLDAgMTkuOTg0NTM1MiwwIEMxOC45NzkxMTI3LDAgMTguODI2ODU5MiwwLjg5NzUzNTIxMSAxNi45OTY0MzY2LDEuMTE3MTEyNjggQzE2Ljk5NjM2NjIsMS4xMTcxMTI2OCAxNi45OTYyOTU4LDEuMTE3MTEyNjggMTYuOTk2MjI1NCwxLjExNzExMjY4IEMxNi45OTYxNTQ5LDEuMTE3MTEyNjggMTYuOTk2MDg0NSwxLjExNzExMjY4IDE2Ljk5NTk0MzcsMS4xMTcxMTI2OCBDMTUuMjA4NjE5NywxLjQ5MTY5MDE0IDE0Ljc2NTE2OSwwLjY2NzM5NDM2NiAxMy44MDg5NzE4LDAuOTc4MDk4NTkyIEMxMi44NTI3NzQ2LDEuMjg4ODAyODIgMTIuOTg1MzA5OSwyLjE4OTQzNjYyIDExLjMxMjI4MTcsMi45NjM4NzMyNCBDMTEuMzEyMjgxNywyLjk2Mzk0MzY2IDExLjMxMjI4MTcsMi45NjM5NDM2NiAxMS4zMTIyODE3LDIuOTYzOTQzNjYgQzExLjMxMjE0MDgsMi45NjQwMTQwOCAxMS4zMTIwNzA0LDIuOTY0MDE0MDggMTEuMzEyLDIuOTY0MDg0NTEgQzkuNzI3Nzc0NjUsMy44NzI2MDU2MyA5LjA1MTI5NTc3LDMuMjI1NzA0MjMgOC4yMzc5MTU0OSwzLjgxNjY5MDE0IEM3LjQyNDQ2NDc5LDQuNDA3Njc2MDYgNy44Mjg5MDE0MSw1LjIyMzMwOTg2IDYuNDc3MDcwNDIsNi40NzY3NjA1NiBDNi40NzcwNzA0Miw2LjQ3NjgzMDk5IDYuNDc3LDYuNDc2OTAxNDEgNi40NzcsNi40NzY5MDE0MSBDNi40NzY5Mjk1OCw2LjQ3Njk3MTgzIDYuNDc2ODU5MTUsNi40NzY5NzE4MyA2LjQ3Njc4ODczLDYuNDc3MDQyMjUgQzUuMjUwODczMjQsNy44MzA3MDQyMyA0LjQwNzcwNDIzLDcuNDI0NTA3MDQgMy44MTY3MTgzMSw4LjIzNzg4NzMyIEMzLjIyNTY2MTk3LDkuMDUxMzM4MDMgMy44NjIzNTIxMSw5LjcwMjA0MjI1IDIuOTY0MTEyNjgsMTEuMzExOTAxNCBDMi45NjQxMTI2OCwxMS4zMTE5NzE4IDIuOTY0MDQyMjUsMTEuMzEyMDQyMyAyLjk2NDA0MjI1LDExLjMxMjE4MzEgQzIuOTYzOTcxODMsMTEuMzEyMTgzMSAyLjk2Mzk3MTgzLDExLjMxMjE4MzEgMi45NjM5MDE0MSwxMS4zMTIyNTM1IEMyLjIxNjI5NTc3LDEyLjk3ODQ1MDcgMS4yODg3NjA1NiwxMi44NTI2NzYxIDAuOTc4MDU2MzM4LDEzLjgwODk0MzcgQzAuNjY3MzUyMTEzLDE0Ljc2NTIxMTMgMS40NzM5NzE4MywxNS4xODcyNTM1IDEuMTE3MTQwODUsMTYuOTk1OTE1NSBMMS4xMTcxNDA4NSwxNi45OTYxMjY4IEMxLjExNzE0MDg1LDE2Ljk5NjE5NzIgMS4xMTcwNzA0MiwxNi45OTYyNjc2IDEuMTE3MDcwNDIsMTYuOTk2MzM4IEMwLjkyMDk0MzY2MiwxOC44MTIwNDIzIDIuODE2OTAxNDFlLTA1LDE4Ljk3OTA4NDUgMi44MTY5MDE0MWUtMDUsMTkuOTg0NTA3IEMyLjgxNjkwMTQxZS0wNSwyMC45ODk5Mjk2IDAuODk3NTYzMzgsMjEuMTQyMTEyNyAxLjExNzA3MDQyLDIyLjk3MjYwNTYgQzEuMTE3MDcwNDIsMjIuOTcyNjA1NiAxLjExNzE0MDg1LDIyLjk3MjY3NjEgMS4xMTcxNDA4NSwyMi45NzI3NDY1IEwxLjExNzE0MDg1LDIyLjk3MzAyODIgQzEuNDkxNjQ3ODksMjQuNzYwMzUyMSAwLjY2NzQyMjUzNSwyNS4yMDM4NzMyIDAuOTc4MDU2MzM4LDI2LjE2MDA3MDQgQzEuMjg4NzYwNTYsMjcuMTE2MjY3NiAyLjE4OTQ2NDc5LDI2Ljk4MzY2MiAyLjk2MzkwMTQxLDI4LjY1NjY5MDEgQzIuOTYzOTAxNDEsMjguNjU2NjkwMSAyLjk2Mzk3MTgzLDI4LjY1NjY5MDEgMi45NjM5NzE4MywyOC42NTY2OTAxIEMyLjk2NDA0MjI1LDI4LjY1NjgzMSAyLjk2NDA0MjI1LDI4LjY1NjkwMTQgMi45NjQxMTI2OCwyOC42NTcwNDIzIEMzLjg3MjYzMzgsMzAuMjQxMTk3MiAzLjIyNTczMjM5LDMwLjkxNzY3NjEgMy44MTY3MTgzMSwzMS43MzEwNTYzIEM0LjQwNzcwNDIzLDMyLjU0NDUwNyA1LjIyMzI2NzYxLDMyLjE0MDA3MDQgNi40NzY3ODg3MywzMy40OTE5MDE0IEM2LjQ3Njc4ODczLDMzLjQ5MTkwMTQgNi40NzY4NTkxNSwzMy40OTE5NzE4IDYuNDc2OTI5NTgsMzMuNDkxOTcxOCBDNi40NzcsMzMuNDkyMDQyMyA2LjQ3NywzMy40OTIxMTI3IDYuNDc3MDcwNDIsMzMuNDkyMTgzMSBDNy44MzA2NjE5NywzNC43MTgwOTg2IDcuNDI0NDY0NzksMzUuNTYxMzM4IDguMjM3OTE1NDksMzYuMTUyMjUzNSBDOS4wNTEyOTU3NywzNi43NDMzMDk5IDkuNzAyLDM2LjEwNjYxOTcgMTEuMzExOTI5NiwzNy4wMDQ4NTkyIEMxMS4zMTIwNzA0LDM3LjAwNDkyOTYgMTEuMzEyMTQwOCwzNy4wMDQ5Mjk2IDExLjMxMjIxMTMsMzcuMDA1IEMxMS4zMTIyODE3LDM3LjAwNSAxMS4zMTIyODE3LDM3LjAwNTA3MDQgMTEuMzEyMjgxNywzNy4wMDUwNzA0IEMxMi45Nzg0Nzg5LDM3Ljc1MjY3NjEgMTIuODUyNzc0NiwzOC42ODAyMTEzIDEzLjgwODk3MTgsMzguOTkwOTE1NSBDMTQuNzY1MTY5LDM5LjMwMTYxOTcgMTUuMTg3MjgxNywzOC40OTUgMTYuOTk1OTQzNywzOC44NTE4MzEgTDE2Ljk5NjAxNDEsMzguODUxODMxIEMxNi45OTYxNTQ5LDM4Ljg1MTgzMSAxNi45OTYyMjU0LDM4Ljg1MTkwMTQgMTYuOTk2MzY2MiwzOC44NTE5MDE0IEMxOC44MTIwNzA0LDM5LjA0ODAyODIgMTguOTc5MTEyNywzOS45NjkwMTQxIDE5Ljk4NDUzNTIsMzkuOTY5MDE0MSBDMjAuOTg5ODg3MywzOS45NjkwMTQxIDIxLjE0MjE0MDgsMzkuMDcxNDc4OSAyMi45NzI2MzM4LDM4Ljg1MTkwMTQgQzIyLjk3MjYzMzgsMzguODUxOTAxNCAyMi45NzI3MDQyLDM4Ljg1MTgzMSAyMi45NzI3NzQ2LDM4Ljg1MTgzMSBDMjIuOTcyODQ1MSwzOC44NTE4MzEgMjIuOTcyOTE1NSwzOC44NTE4MzEgMjIuOTczMDU2MywzOC44NTE4MzEgQzI0Ljc2MDMwOTksMzguNDc3MzIzOSAyNS4yMDM4MzEsMzkuMzAxNjE5NyAyNi4xNjAwMjgyLDM4Ljk5MDkxNTUgQzI3LjExNjIyNTQsMzguNjgwMjExMyAyNi45ODM2OTAxLDM3Ljc3OTUwNyAyOC42NTY3MTgzLDM3LjAwNTA3MDQgQzI4LjY1NjcxODMsMzcuMDA1MDcwNCAyOC42NTY3MTgzLDM3LjAwNTA3MDQgMjguNjU2NzE4MywzNy4wMDUgQzI4LjY1Njg1OTIsMzcuMDA1IDI4LjY1NjkyOTYsMzcuMDA0OTI5NiAyOC42NTcsMzcuMDA0OTI5NiBDMzAuMjQxMjI1NCwzNi4wOTY0MDg1IDMwLjkxNzcwNDIsMzYuNzQzMzA5OSAzMS43MzEwODQ1LDM2LjE1MjI1MzUgQzMyLjU0NDUzNTIsMzUuNTYxMzM4IDMyLjE0MDAyODIsMzQuNzQ1NzA0MiAzMy40OTE5Mjk2LDMzLjQ5MjE4MzEgQzMzLjQ5MTkyOTYsMzMuNDkyMTgzMSAzMy40OTIsMzMuNDkyMTEyNyAzMy40OTIsMzMuNDkyMDQyMyBDMzMuNDkyMDcwNCwzMy40OTE5NzE4IDMzLjQ5MjE0MDgsMzMuNDkxOTcxOCAzMy40OTIyMTEzLDMzLjQ5MTkwMTQgQzM0LjcxODA1NjMsMzIuMTM4MzA5OSAzNS41NjEyOTU4LDMyLjU0NDUwNyAzNi4xNTIyODE3LDMxLjczMTA1NjMgQzM2Ljc0MzI2NzYsMzAuOTE3Njc2MSAzNi4xMDY2NDc5LDMwLjI2Njk3MTggMzcuMDA0ODg3MywyOC42NTcwNDIzIEMzNy4wMDQ4ODczLDI4LjY1Njk3MTggMzcuMDA0OTU3NywyOC42NTY5MDE0IDM3LjAwNTAyODIsMjguNjU2NzYwNiBDMzcuMDA1MDI4MiwyOC42NTY3NjA2IDM3LjAwNTAyODIsMjguNjU2NjkwMSAzNy4wMDUwOTg2LDI4LjY1NjY5MDEgQzM3Ljc1MjcwNDIsMjYuOTkwNTYzNCAzOC42ODAxNjksMjcuMTE2MjY3NiAzOC45OTA5NDM3LDI2LjE2MDA3MDQgQzM5LjMwMTU3NzUsMjUuMjAzODczMiAzOC40OTUwMjgyLDI0Ljc4MTY5MDEgMzguODUxODU5MiwyMi45NzMwMjgyIiBpZD0iRmlsbC0xIiBmaWxsPSIjRUQxQzI0Ij48L3BhdGg+CiAgICAgICAgICAgIDxwYXRoIGQ9Ik0zNC44NTA2MzM4LDE5LjM4NDE2MiBMMzQuODUwNjMzOCwxOS4zODQwMjExIEMzNC44NTA2MzM4LDE5LjM4Mzk1MDcgMzQuODUwNjMzOCwxOS4zODM4ODAzIDM0Ljg1MDcwNDIsMTkuMzgzODA5OSBDMzUuMDA1MjExMywxNy45NTMyNDY1IDM1LjczMDg0NTEsMTcuODIxNjI2OCAzNS43MzA4NDUxLDE3LjAyOTM3MzIgQzM1LjczMDg0NTEsMTYuMjM3MTkwMSAzNS4wMjM2NjIsMTYuMTE3MjYwNiAzNC44NTA3MDQyLDE0LjY3NTAwNyBDMzQuODUwNjMzOCwxNC42NzQ5MzY2IDM0Ljg1MDYzMzgsMTQuNjc0OTM2NiAzNC44NTA2MzM4LDE0LjY3NDg2NjIgTDM0Ljg1MDYzMzgsMTQuNjc0NjU0OSBDMzQuNTU1NTYzNCwxMy4yNjYzNDUxIDM1LjIwNSwxMi45MTY5Nzg5IDM0Ljk2MDIxMTMsMTIuMTYzNDU3NyBDMzQuNzE1MzUyMSwxMS40MTAwNzc1IDM0LjAwNTcwNDIsMTEuNTE0NTE0MSAzMy4zOTU1NjM0LDEwLjE5NjM0NTEgQzMzLjM5NTQ5MywxMC4xOTYzNDUxIDMzLjM5NTQ5MywxMC4xOTYzNDUxIDMzLjM5NTQ5MywxMC4xOTYyNzQ2IEMzMy4zOTU0MjI1LDEwLjE5NjIwNDIgMzMuMzk1NDIyNSwxMC4xOTYxMzM4IDMzLjM5NTM1MjEsMTAuMTk2MDYzNCBDMzIuNjc5NTA3LDguOTQ3ODIzOTQgMzMuMTg5MjI1NCw4LjQxNDc5NTc3IDMyLjcyMzU5MTUsNy43NzM5NTA3IEMzMi4yNTc5NTc3LDcuMTMzMDM1MjEgMzEuNjE1MzUyMSw3LjQ1MTY5NzE4IDMwLjYyNzYwNTYsNi4zODY1NTYzNCBDMzAuNjI3NTM1Miw2LjM4NjU1NjM0IDMwLjYyNzUzNTIsNi4zODY0ODU5MiAzMC42Mjc0NjQ4LDYuMzg2NDg1OTIgQzMwLjYyNzM5NDQsNi4zODY0MTU0OSAzMC42MjczOTQ0LDYuMzg2MzQ1MDcgMzAuNjI3Mzk0NCw2LjM4NjM0NTA3IEMyOS41NjA4NDUxLDUuNDIwNDI5NTggMjkuODgwOTE1NSw0Ljc1NTk5Mjk2IDI5LjI0LDQuMjkwMjg4NzMgQzI4LjU5OTA4NDUsMy44MjQ3MjUzNSAyOC4wODYzMzgsNC4zMjYzNDUwNyAyNi44MTc4ODczLDMuNjE4NTI4MTcgQzI2LjgxNzg4NzMsMy42MTg1MjgxNyAyNi44MTc4MTY5LDMuNjE4NDU3NzUgMjYuODE3NzQ2NSwzLjYxODQ1Nzc1IEMyNi44MTc2NzYxLDMuNjE4NDU3NzUgMjYuODE3Njc2MSwzLjYxODM4NzMyIDI2LjgxNzYwNTYsMy42MTgzODczMiBDMjUuNTA0Nzg4NywzLjAyOTM3MzI0IDI1LjYwMzgwMjgsMi4yOTg1MjgxNyAyNC44NTAzNTIxLDIuMDUzNzM5NDQgQzI0LjA5Njk3MTgsMS44MDg5NTA3IDIzLjc2NDM2NjIsMi40NDQ0NDM2NiAyMi4zMzkyMjU0LDIuMTYzMjQ2NDggTDIyLjMzOTA4NDUsMi4xNjMyNDY0OCBDMjIuMzM5MDE0MSwyLjE2MzI0NjQ4IDIyLjMzOTAxNDEsMi4xNjMyNDY0OCAyMi4zMzg5NDM3LDIuMTYzMjQ2NDggQzIwLjkwODM4MDMsMi4wMDg3Mzk0NCAyMC43NzY2OTAxLDEuMjgzMDM1MjEgMTkuOTg0NTA3LDEuMjgzMDM1MjEgQzE5LjE5MjI1MzUsMS4yODMwMzUyMSAxOS4wNzIzMjM5LDEuOTkwMjE4MzEgMTcuNjMwMTQwOCwyLjE2MzI0NjQ4IEMxNy42MzAwNzA0LDIuMTYzMjQ2NDggMTcuNjMwMDcwNCwyLjE2MzI0NjQ4IDE3LjYzLDIuMTYzMjQ2NDggTDE3LjYyOTc4ODcsMi4xNjMyNDY0OCBDMTYuMjIxNDc4OSwyLjQ1ODM4NzMyIDE1Ljg3MjA0MjMsMS44MDg5NTA3IDE1LjExODY2MiwyLjA1MzczOTQ0IEMxNC4zNjUxNDA4LDIuMjk4NTI4MTcgMTQuNDY5NjQ3OSwzLjAwODE3NjA2IDEzLjE1MTQwODUsMy42MTgzODczMiBDMTMuMTUxNDA4NSwzLjYxODM4NzMyIDEzLjE1MTQwODUsMy42MTgzODczMiAxMy4xNTEzMzgsMy42MTg0NTc3NSBDMTMuMTUxMjY3NiwzLjYxODQ1Nzc1IDEzLjE1MTE5NzIsMy42MTg0NTc3NSAxMy4xNTExMjY4LDMuNjE4NTI4MTcgQzExLjkwMjk1NzcsNC4zMzQzNzMyNCAxMS4zNjk5Mjk2LDMuODI0NzI1MzUgMTAuNzI5MDE0MSw0LjI5MDI4ODczIEMxMC4wODgwOTg2LDQuNzU1OTkyOTYgMTAuNDA2NjkwMSw1LjM5ODU5ODU5IDkuMzQxNjE5NzIsNi4zODYzNDUwNyBDOS4zNDE2MTk3Miw2LjM4NjM0NTA3IDkuMzQxNTQ5Myw2LjM4NjQxNTQ5IDkuMzQxNTQ5Myw2LjM4NjQxNTQ5IEM5LjM0MTU0OTMsNi4zODY0ODU5MiA5LjM0MTQ3ODg3LDYuMzg2NDg1OTIgOS4zNDE0MDg0NSw2LjM4NjU1NjM0IEM4LjM3NTQ5Mjk2LDcuNDUzMTA1NjMgNy43MTEwNTYzNCw3LjEzMzAzNTIxIDcuMjQ1NDIyNTQsNy43NzM5NTA3IEM2Ljc3OTc4ODczLDguNDE0Nzk1NzcgNy4yODE0Nzg4Nyw4LjkyNzU0MjI1IDYuNTczNjYxOTcsMTAuMTk1OTkzIEM2LjU3MzY2MTk3LDEwLjE5NjA2MzQgNi41NzM1OTE1NSwxMC4xOTYxMzM4IDYuNTczNTkxNTUsMTAuMTk2MjA0MiBDNi41NzM1MjExMywxMC4xOTYyNzQ2IDYuNTczNTIxMTMsMTAuMTk2Mjc0NiA2LjU3MzUyMTEzLDEwLjE5NjM0NTEgQzUuOTg0NDM2NjIsMTEuNTA5MTYyIDUuMjUzNjYxOTcsMTEuNDEwMDc3NSA1LjAwODgwMjgyLDEyLjE2MzQ1NzcgQzQuNzY0MDE0MDgsMTIuOTE2OTc4OSA1LjM5OTU3NzQ2LDEzLjI0OTU4NDUgNS4xMTgzODAyOCwxNC42NzQ2NTQ5IEw1LjExODM4MDI4LDE0LjY3NDc5NTggTDUuMTE4MzgwMjgsMTQuNjc0OTM2NiBDNC45NjM3MzIzOSwxNi4xMDU1NzA0IDQuMjM4MTY5MDEsMTYuMjM3MTkwMSA0LjIzODE2OTAxLDE3LjAyOTM3MzIgQzQuMjM4MTY5MDEsMTcuODIxNjI2OCA0Ljk0NTM1MjExLDE3Ljk0MTU1NjMgNS4xMTgzODAyOCwxOS4zODM4MDk5IEw1LjExODM4MDI4LDE5LjM4Mzk1MDcgTDUuMTE4MzgwMjgsMTkuMzg0MTYyIEM1LjQxMzQ1MDcsMjAuNzkyNDcxOCA0Ljc2NDA4NDUxLDIxLjE0MTgzOCA1LjAwODgwMjgyLDIxLjg5NTI4ODcgQzUuMjUzNjYxOTcsMjIuNjQ4NzM5NCA1Ljk2MzMwOTg2LDIyLjU0NDMwMjggNi41NzM1MjExMywyMy44NjI0NzE4IEw2LjU3MzUyMTEzLDIzLjg2MjQ3MTggQzYuNTczNTkxNTUsMjMuODYyNjEyNyA2LjU3MzU5MTU1LDIzLjg2MjY4MzEgNi41NzM2NjE5NywyMy44NjI3NTM1IEM3LjI4OTUwNzA0LDI1LjExMDk5MyA2Ljc3OTc4ODczLDI1LjY0NDAyMTEgNy4yNDU0MjI1NCwyNi4yODQ4NjYyIEM3LjcxMTA1NjM0LDI2LjkyNTc4MTcgOC4zNTM2NjE5NywyNi42MDcxMTk3IDkuMzQxNDA4NDUsMjcuNjcyMjYwNiBDOS4zNDE0Nzg4NywyNy42NzIyNjA2IDkuMzQxNTQ5MywyNy42NzIzMzEgOS4zNDE1NDkzLDI3LjY3MjMzMSBDOS4zNDE1NDkzLDI3LjY3MjQwMTQgOS4zNDE1NDkzLDI3LjY3MjQ3MTggOS4zNDE2MTk3MiwyNy42NzI0NzE4IEMxMC40MDgxNjksMjguNjM4Mzg3MyAxMC4wODgwOTg2LDI5LjMwMjgyMzkgMTAuNzI5MDE0MSwyOS43Njg0NTc3IEMxMS4zNjk5Mjk2LDMwLjIzNDE2MiAxMS44ODI2MDU2LDI5LjczMjQ3MTggMTMuMTUxMTI2OCwzMC40NDAyODg3IEwxMy4xNTEzMzgsMzAuNDQwMzU5MiBMMTMuMTUxNDA4NSwzMC40NDA0Mjk2IEMxNC40NjQyOTU4LDMxLjAyOTQ0MzcgMTQuMzY1MTQwOCwzMS43NjAyODg3IDE1LjExODY2MiwzMi4wMDUwNzc1IEMxNS44NzIwNDIzLDMyLjI0OTg2NjIgMTYuMjA0NjQ3OSwzMS42MTQzNzMyIDE3LjYyOTc4ODcsMzEuODk1NSBMMTcuNjI5ODU5MiwzMS44OTU1IEMxNy42Mjk5Mjk2LDMxLjg5NTU3MDQgMTcuNjMsMzEuODk1NTcwNCAxNy42MzAxNDA4LDMxLjg5NTU3MDQgQzE5LjA2MDYzMzgsMzIuMDUwMDc3NSAxOS4xOTIyNTM1LDMyLjc3NTc4MTcgMTkuOTg0NTA3LDMyLjc3NTc4MTcgQzIwLjc3NjY5MDEsMzIuNzc1NzgxNyAyMC44OTY2OTAxLDMyLjA2ODU5ODYgMjIuMzM4ODczMiwzMS44OTU1NzA0IEMyMi4zMzg5NDM3LDMxLjg5NTU3MDQgMjIuMzM4OTQzNywzMS44OTU1NzA0IDIyLjMzOTAxNDEsMzEuODk1NTcwNCBDMjIuMzM5MDg0NSwzMS44OTU1NzA0IDIyLjMzOTE1NDksMzEuODk1NTcwNCAyMi4zMzkyMjU0LDMxLjg5NTUgQzIzLjc0NzUzNTIsMzEuNjAwNDI5NiAyNC4wOTY5NzE4LDMyLjI0OTg2NjIgMjQuODUwMzUyMSwzMi4wMDUwNzc1IEMyNS42MDM4MDI4LDMxLjc2MDI4ODcgMjUuNDk5MzY2MiwzMS4wNTA2NDA4IDI2LjgxNzYwNTYsMzAuNDQwNDI5NiBDMjYuODE3NjA1NiwzMC40NDA0Mjk2IDI2LjgxNzYwNTYsMzAuNDQwNDI5NiAyNi44MTc2NzYxLDMwLjQ0MDM1OTIgQzI2LjgxNzc0NjUsMzAuNDQwMzU5MiAyNi44MTc4MTY5LDMwLjQ0MDM1OTIgMjYuODE3ODg3MywzMC40NDAyODg3IEMyOC4wNjYwNTYzLDI5LjcyNDQ0MzcgMjguNTk5MDg0NSwzMC4yMzQxNjIgMjkuMjQsMjkuNzY4NDU3NyBDMjkuODgwOTE1NSwyOS4zMDI4MjM5IDI5LjU2MjE4MzEsMjguNjYwMjE4MyAzMC42MjczMjM5LDI3LjY3MjQ3MTggQzMwLjYyNzM5NDQsMjcuNjcyNDcxOCAzMC42MjczOTQ0LDI3LjY3MjQwMTQgMzAuNjI3Mzk0NCwyNy42NzI0MDE0IEwzMC42Mjc2MDU2LDI3LjY3MjI2MDYgQzMxLjU5MzUyMTEsMjYuNjA1NzgxNyAzMi4yNTc5NTc3LDI2LjkyNTc4MTcgMzIuNzIzNTkxNSwyNi4yODQ4NjYyIEMzMy4xODkyMjU0LDI1LjY0NDAyMTEgMzIuNjg3NTM1MiwyNS4xMzEyNzQ2IDMzLjM5NTM1MjEsMjMuODYyNzUzNSBDMzMuMzk1NDIyNSwyMy44NjI2ODMxIDMzLjM5NTQyMjUsMjMuODYyNjEyNyAzMy4zOTU0OTMsMjMuODYyNTQyMyBMMzMuMzk1NDkzLDIzLjg2MjQ3MTggQzMzLjk4NDU3NzUsMjIuNTQ5NjU0OSAzNC43MTUzNTIxLDIyLjY0ODczOTQgMzQuOTYwMjExMywyMS44OTUyODg3IEMzNS4yMDQ5Mjk2LDIxLjE0MTgzOCAzNC41Njk1MDcsMjAuODA5MjMyNCAzNC44NTA2MzM4LDE5LjM4NDE2MiIgaWQ9IkZpbGwtMyIgZmlsbD0iI0ZFRkVGRSI+PC9wYXRoPgogICAgICAgICAgICA8cGF0aCBkPSJNNC4xMzk0NjQ3OSwxNy4wNzE1MjgyIEM0LjEzOTQ2NDc5LDguMzIwNTQyMjUgMTEuMjMzNDc4OSwxLjIyNjQ1Nzc1IDE5Ljk4NDUzNTIsMS4yMjY0NTc3NSBDMjguNzM1NTIxMSwxLjIyNjQ1Nzc1IDM1LjgyOTYwNTYsOC4zMjA1NDIyNSAzNS44Mjk2MDU2LDE3LjA3MTUyODIgQzM1LjgyOTYwNTYsMjUuODIyNTE0MSAyOC43MzU1MjExLDMyLjkxNjU5ODYgMTkuOTg0NTM1MiwzMi45MTY1OTg2IEMxMS4yMzM0Nzg5LDMyLjkxNjU5ODYgNC4xMzk0NjQ3OSwyNS44MjI1MTQxIDQuMTM5NDY0NzksMTcuMDcxNTI4MiIgaWQ9IkZpbGwtNSIgZmlsbD0iI0VEMUMyNCI+PC9wYXRoPgogICAgICAgICAgICA8cGF0aCBkPSJNMzguODUxODU5MiwyMi45NzU2NzYxIEwzOC44NTE4NTkyLDIyLjk3NTUzNTIgQzM4Ljg1MTg1OTIsMjIuOTc1NDY0OCAzOC44NTE5Mjk2LDIyLjk3NTM5NDQgMzguODUxOTI5NiwyMi45NzUyNTM1IEMzOS4wNDgwNTYzLDIxLjE1OTYxOTcgMzkuOTY4OTcxOCwyMC45OTI1Nzc1IDM5Ljk2ODk3MTgsMTkuOTg3MTU0OSBDMzkuOTY4OTcxOCwyMC4zOTAzOTQ0IDM5LjA3Mzc2MDYsMTkuNzE5MDU2MyAzNy4wNDQzOTQ0LDE3LjgzOTc2MDYgQzM2LjcwMDczMjQsMTcuNTIxNTIxMSAzNS44MDg0MDg1LDE2LjgwMDM5NDQgMzUuODEyMTQwOCwxNy44Njk4MzEgQzM1LjgxMjI4MTcsMTcuOTA1MzIzOSAzNS44MDkxMTI3LDE3LjkzMzkxNTUgMzUuODA0Mzk0NCwxNy45NTkwNTYzIEMzNS4zNDM5MDE0LDI2LjI5NzE1NDkgMjguNDM3NTYzNCwzMi45MTY1OTE1IDE5Ljk4NDUzNTIsMzIuOTE2NTkxNSBDMTcuMzQ5MTEyNywzMi45MTY1OTE1IDE0LjYzNDExMjcsMzIuMzM0NTQ5MyAxMS42OTQ3NDY1LDMwLjYwMjE1NDkgQzExLjIwODMzOCwzMC4zMTU0NjQ4IDEwLjU1MzkwMTQsMzAuNjMwODg3MyAxMC4yNjY1Nzc1LDMxLjQ2NTI1MzUgQzkuNjQ4MzM4MDMsMzMuMjYwNzQ2NSA4LjcyOTYwNTYzLDM2LjM0NTYwNTYgOC4wNTc4NDUwNywzNi4wMDEyMzk0IEM4LjkwODMzODAzLDM2LjgyNTExMjcgOS42NjAxNjkwMSwzNi4wNjc0MzY2IDExLjMxMTkyOTYsMzcuMDA3NTc3NSBDMTEuMzEyMDcwNCwzNy4wMDc1Nzc1IDExLjMxMjE0MDgsMzcuMDA3NjQ3OSAxMS4zMTIyMTEzLDM3LjAwNzcxODMgQzExLjMxMjI4MTcsMzcuMDA3NzE4MyAxMS4zMTIyODE3LDM3LjAwNzcxODMgMTEuMzEyMjgxNywzNy4wMDc3MTgzIEMxMi45Nzg0Nzg5LDM3Ljc1NTM5NDQgMTIuODUyNzc0NiwzOC42ODI4NTkyIDEzLjgwODk3MTgsMzguOTkzNTYzNCBDMTQuNzY1MTY5LDM5LjMwNDI2NzYgMTUuMTg3MjgxNywzOC40OTc3MTgzIDE2Ljk5NTk0MzcsMzguODU0NDc4OSBMMTYuOTk2MDE0MSwzOC44NTQ0Nzg5IEMxNi45OTYxNTQ5LDM4Ljg1NDQ3ODkgMTYuOTk2MjI1NCwzOC44NTQ1NDkzIDE2Ljk5NjM2NjIsMzguODU0NTQ5MyBDMTguODEyMDcwNCwzOS4wNTA3NDY1IDE4Ljk3OTExMjcsMzkuOTcxNjYyIDE5Ljk4NDUzNTIsMzkuOTcxNjYyIEMyMC45ODk4ODczLDM5Ljk3MTY2MiAyMS4xNDIxNDA4LDM5LjA3NDEyNjggMjIuOTcyNjMzOCwzOC44NTQ1NDkzIEMyMi45NzI2MzM4LDM4Ljg1NDU0OTMgMjIuOTcyNzA0MiwzOC44NTQ1NDkzIDIyLjk3Mjc3NDYsMzguODU0NTQ5MyBDMjIuOTcyODQ1MSwzOC44NTQ0Nzg5IDIyLjk3MjkxNTUsMzguODU0NTQ5MyAyMi45NzMwNTYzLDM4Ljg1NDQ3ODkgQzI0Ljc2MDMwOTksMzguNDc5OTcxOCAyNS4yMDM4MzEsMzkuMzA0MjY3NiAyNi4xNjAwMjgyLDM4Ljk5MzU2MzQgQzI3LjExNjIyNTQsMzguNjgyODU5MiAyNi45ODM2OTAxLDM3Ljc4MjIyNTQgMjguNjU2NzE4MywzNy4wMDc3ODg3IEMyOC42NTY3MTgzLDM3LjAwNzcxODMgMjguNjU2NzE4MywzNy4wMDc3MTgzIDI4LjY1NjcxODMsMzcuMDA3NzE4MyBDMjguNjU2ODU5MiwzNy4wMDc2NDc5IDI4LjY1NjkyOTYsMzcuMDA3NjQ3OSAyOC42NTcsMzcuMDA3NTc3NSBDMzAuMjQxMjI1NCwzNi4wOTkwNTYzIDMwLjkxNzcwNDIsMzYuNzQ1OTU3NyAzMS43MzEwODQ1LDM2LjE1NDk3MTggQzMyLjU0NDUzNTIsMzUuNTYzOTg1OSAzMi4xNDAwMjgyLDM0Ljc0ODQyMjUgMzMuNDkxOTI5NiwzMy40OTQ5MDE0IEMzMy40OTE5Mjk2LDMzLjQ5NDgzMSAzMy40OTIsMzMuNDk0NzYwNiAzMy40OTIsMzMuNDk0NzYwNiBDMzMuNDkyMDcwNCwzMy40OTQ2OTAxIDMzLjQ5MjE0MDgsMzMuNDk0NjE5NyAzMy40OTIyMTEzLDMzLjQ5NDYxOTcgQzM0LjcxODA1NjMsMzIuMTQwOTU3NyAzNS41NjEyOTU4LDMyLjU0NzIyNTQgMzYuMTUyMjgxNywzMS43MzM3NzQ2IEMzNi43NDMyNjc2LDMwLjkyMDMyMzkgMzYuMTA2NjQ3OSwzMC4yNjk2MTk3IDM3LjAwNDg4NzMsMjguNjU5NzYwNiBDMzcuMDA0ODg3MywyOC42NTk2MTk3IDM3LjAwNDk1NzcsMjguNjU5NTQ5MyAzNy4wMDUwMjgyLDI4LjY1OTQ3ODkgQzM3LjAwNTAyODIsMjguNjU5NDA4NSAzNy4wMDUwMjgyLDI4LjY1OTQwODUgMzcuMDA1MDk4NiwyOC42NTkzMzggQzM3Ljc1MjcwNDIsMjYuOTkzMjExMyAzOC42ODAxNjksMjcuMTE4OTE1NSAzOC45OTA5NDM3LDI2LjE2MjcxODMgQzM5LjMwMTU3NzUsMjUuMjA2NTIxMSAzOC40OTUwMjgyLDI0Ljc4NDQwODUgMzguODUxODU5MiwyMi45NzU2NzYxIiBpZD0iRmlsbC03IiBmaWxsPSIjQUQxNDFBIj48L3BhdGg+CiAgICAgICAgICAgIDxwYXRoIGQ9Ik0zNy4zOTY3ODE3LDIyLjgxMTE0MDggQzM2LjU5Nzc2NzYsMjIuMjUxODQ1MSAzNS45ODM4OTQ0LDIxLjg4NDk0MzcgMzUuOTUxMDA3LDIyLjQwMzUzNTIgQzM1LjkzMjI3NDYsMjIuNjk4MzIzOSAzNi4yNTAyMzI0LDIzLjE3OTczMjQgMzcuMDkwMjMyNCwyNC4xMzc3NjA2IEMzOC4xMzkwMzUyLDI1LjMzMzk1NzcgMzguOTI0MDM1MiwyNi4zNjg0NjQ4IDM4Ljk5MDkzNjYsMjYuMTYyNjkwMSBDMzkuMjM2NzExMywyNS40MDYyMTEzIDM4Ljc4MzE5MDEsMjQuOTgzOTU3NyAzOC43NTk3Mzk0LDIzLjk0NDg3MzIgQzM4Ljc1MzYxMjcsMjMuNjcwNjQ3OSAzOC4zMDA3MjU0LDIzLjQ0MzgxNjkgMzcuMzk2NzgxNywyMi44MTExNDA4IiBpZD0iRmlsbC05IiBmaWxsPSIjRUQxQzI0Ij48L3BhdGg+CiAgICAgICAgICAgIDxwYXRoIGQ9Ik0xNC4zMzc0NTc3LDM1LjEwNDk5MyBDMTQuNTkwMTMzOCwzMy44ODc5NTA3IDE0Ljg3Mjg4MDMsMzMuMTgwMDYzNCAxNC40ODA4MzgsMzMuMDI3MzE2OSBDMTQuMDY0Mjg4NywzMi44NjUwNjM0IDEzLjcwNzM4NzMsMzMuMjIwMzQ1MSAxMy4zMjI5NTA3LDM0LjM3OTg1MjEgQzEyLjg2OTc4MTcsMzUuNzQ2NjgzMSAxMi4xMzEyNjA2LDM3LjM2MzcyNTQgMTIuNTE1OTA4NSwzNy44MTMzMDI4IEMxMi4wOTMyMzI0LDM3LjM1MTk2NDggMTEuNDE5NDI5NiwzNy4wNTgzNzMyIDExLjMxMTg5NDQsMzcuMDA3NTk4NiBDMTEuMzEyMDM1MiwzNy4wMDc1OTg2IDExLjMxMjEwNTYsMzcuMDA3NjY5IDExLjMxMjE3NjEsMzcuMDA3NzM5NCBDMTEuMzEyMjQ2NSwzNy4wMDc3Mzk0IDExLjMxMjI0NjUsMzcuMDA3NzM5NCAxMS4zMTIzMTY5LDM3LjAwNzczOTQgQzEyLjY5NTgzOCwzNy42Mjg1MTQxIDEyLjg0NDk5MywzOC4zNzIxNzYxIDEzLjQwMTY4MzEsMzguNzg2MzMxIEMxMy42MTE0NzE4LDM4Ljk0MjQ1NzcgMTMuNjg2MzMxLDM4LjI0MTE5MDEgMTQuMzM3NDU3NywzNS4xMDQ5OTMiIGlkPSJGaWxsLTExIiBmaWxsPSIjRUQxQzI0Ij48L3BhdGg+CiAgICAgICAgICAgIDxwYXRoIGQ9Ik0yLjgwNzgzMDk5LDIwLjUyMjc4ODcgQzMuNjQ4Njc2MDYsMTkuNTM4NzA0MiAzLjg3ODgxNjksMTguODAyNDM2NiAzLjg3ODgxNjksMTguMTU0NzYwNiBDMy44Nzg4MTY5LDE3LjMyMzQyMjUgMy4xMTkyMzk0NCwxNy43Njg5MTU1IDIuNzc3OTcxODMsMTguMDg3MzY2MiBDMC4yMjg2MDU2MzQsMjAuNDY2NDUwNyAxLjQwODQ1MDdlLTA1LDIwLjIyOCAxLjQwODQ1MDdlLTA1LDE5Ljk4NzE1NDkgQzEuNDA4NDUwN2UtMDUsMjAuOTkyNTc3NSAwLjg5NzU0OTI5NiwyMS4xNDQ4MzEgMS4xMTcwNTYzNCwyMi45NzUyNTM1IEMxLjExNzA1NjM0LDIyLjk3NTI1MzUgMS4xMTcwNTYzNCwyMi45NzUzMjM5IDEuMTE3MTI2NzYsMjIuOTc1MzIzOSBDMS4xMTcwNTYzNCwyMi45NzUzMjM5IDEuMTE3MDU2MzQsMjIuOTc1MjUzNSAxLjExNzA1NjM0LDIyLjk3NTI1MzUgQzEuMDUzMjUzNTIsMjIuNTcyMDg0NSAxLjU2NTc4ODczLDIxLjk3NjQ1MDcgMi44MDc4MzA5OSwyMC41MjI3ODg3IiBpZD0iRmlsbC0xMyIgZmlsbD0iI0FEMTQxQSI+PC9wYXRoPgogICAgICAgICAgICA8cGF0aCBkPSJNNy40MTgzNzMyNCwzMC40MTExNjkgQzcuNjkwOTc4ODcsMjkuMzkwODg3MyA3LjkwMzQ0MzY2LDI4LjA5MTQ1MDcgNy40MjEyNjA1NiwyNy40NzUzMjM5IEM2Ljk1ODY1NDkzLDI2Ljg4NDEyNjggNi41NjU4MzgwMywyNy40MDg5MTU1IDYuMDY4MzczMjQsMjguMzYyMjk1OCBDNS4yNDg3MjUzNSwyOS45MzMwNzA0IDQuMjQ2NTQyMjUsMzIuMTc3NTc3NSAzLjg3ODc5NTc3LDMxLjgzMjY0NzkgQzQuNzM1NTU2MzQsMzIuNjM2NDUwNyA1LjI3NDU3MDQyLDMyLjEzMTY2MiA2LjgxNTU1NjM0LDMzLjgyOTA1NjMgQzYuNTkzNzk1NzcsMzMuNTIxMTY5IDYuODcxODk0MzcsMzIuNDU2NTkxNSA3LjQxODM3MzI0LDMwLjQxMTE2OSIgaWQ9IkZpbGwtMTUiIGZpbGw9IiNBRDE0MUEiPjwvcGF0aD4KICAgICAgICAgICAgPHBhdGggZD0iTTUuMDAwNDkyOTYsMjIuOTIxNzYwNiBDNC43NzY5NzE4MywyMi4zNTYwNTYzIDQuMzkwNTYzMzgsMjIuNDgwOTg1OSAzLjg3ODgwMjgyLDIzLjA4MDU2MzQgQzEuNzk1MTQwODUsMjUuNTIxNzYwNiAxLjIyMDA3MDQyLDI2LjM5NjYxOTcgMS4wMDQ0MzY2MiwyNi4yMDk1MDcgQzEuMDAyNDY0NzksMjYuMjEyNzQ2NSAwLjk5OTkyOTU3NywyNi4yMTUxNDA4IDAuOTk3ODg3MzI0LDI2LjIxODIzOTQgQzEuMzQxMzM4MDMsMjcuMTEzODczMiAyLjE4NDcxODMxLDI3LjAyNTA3MDQgMi45NTE5MDE0MSwyOC42MzA5ODU5IEMyLjk1OTY0Nzg5LDI3Ljg5NzI1MzUgMy44ODA2MzM4LDI2Ljc4OTE1NDkgNC40NDcxODMxLDI1LjU3ODM4MDMgQzUuMDQ0Mjk1NzcsMjQuMzAyMTEyNyA1LjE4MDkxNTQ5LDIzLjM3ODIzOTQgNS4wMDA0OTI5NiwyMi45MjE3NjA2IiBpZD0iRmlsbC0xNyIgZmlsbD0iI0FEMTQxQSI+PC9wYXRoPgogICAgICAgICAgICA8cGF0aCBkPSJNMy4wODg4MzgwMywxMy4xMDUyNDY1IEMyLjUzODYyNjc2LDEzLjQ2MjE0NzkgMC45NDY4NjYxOTcsMTQuMzg0NDAxNCAwLjkyMzIwNDIyNSwxNC4wMzI4NTIxIEMwLjg5NjM3MzIzOSwxNC4xMzQ2ODMxIDAuODkyMTQ3ODg3LDE0LjMxMjU3MDQgMC45NDQ0NzE4MzEsMTQuNjA5NjgzMSBDMC45ODQ4MjM5NDQsMTQuODM4OTA4NSAxLjEzOTYxMjY4LDE1LjM1MTU4NDUgMS4yMDcwNzc0NiwxNS45NTkyNjA2IEMxLjIzOTYxMjY4LDE2LjI1MjAwNyAxLjExNzcxMTI3LDE3LjI0NDc1MzUgMC45NDc2NDA4NDUsMTcuODM5NzUzNSBDMS4zMTQ1NDIyNSwxNy4yMDM2MjY4IDEuODk2MDkxNTUsMTYuMjU1OTUwNyAyLjg4NTg4MDI4LDE1LjE3NzQyOTYgQzMuNzEyODUyMTEsMTQuMjc2MjMyNCA0LjA4MDk1MDcsMTMuOTc1MTc2MSA0LjI3OTMzMDk5LDEzLjE0MzYyNjggQzQuNDQwMDM1MjEsMTIuNDcwMDM1MiAzLjcxMjE0Nzg5LDEyLjcwMTAyMTEgMy4wODg4MzgwMywxMy4xMDUyNDY1IiBpZD0iRmlsbC0xOSIgZmlsbD0iI0FEMTQxQSI+PC9wYXRoPgogICAgICAgICAgICA8cGF0aCBkPSJNMzguOTg3NzUzNSwxMy44MTE1OTg2IEMzOS4xNjU2NDA4LDE0LjQ4MjAyMTEgMzcuNjkwMjg4NywxMy44MDU0MDE0IDM2Ljc5MjU0MjMsMTMuMjI1MTkwMSBDMzUuODk0ODY2MiwxMi42NDQ5Nzg5IDM1LjI2MDY0MDgsMTIuNDQ4NDI5NiAzNS40NzQ4NjYyLDEzLjE0NDgzOCBDMzUuNjMyODk0NCwxMy42NTg0Mjk2IDM2LjU2MDc4MTcsMTQuNjk3ODY2MiAzNy4yNDYyMDQyLDE1LjI5MTE3NjEgQzM3LjkzMTYyNjgsMTUuODg0NDE1NSAzOC42MzE4MzgsMTYuNDIxODA5OSAzOC44NDg2NjksMTYuOTk2MDM1MiBDMzguNTM4MTc2MSwxNS41MDU1NDIzIDM5LjA1OTE2MiwxNC45NDY0NTc3IDM5LjA1OTM3MzIsMTQuMjU0MDYzNCBDMzkuMDU5NDQzNywxNC4wMjU1NDIzIDM5LjAwMzk1MDcsMTMuODYxNTI4MiAzOC45ODc3NTM1LDEzLjgxMTU5ODYiIGlkPSJGaWxsLTIxIiBmaWxsPSIjQUQxNDFBIj48L3BhdGg+CiAgICAgICAgICAgIDxwYXRoIGQ9Ik0zMi40MDkwMjExLDI0LjQzODA3NzUgQzMxLjg2MDkyMjUsMjUuNzUzNSAzMC45NTkyMzI0LDI2LjkwNDkwODUgMjkuOTEzMjQ2NSwyNy44NzUxOTAxIEMyOC44NzI3NTM1LDI4Ljg1NjgwOTkgMjcuNjc1OTIyNSwyOS42NzQzNDUxIDI2LjM4NDg2NjIsMzAuMjkyNzI1NCBDMjUuMTIwNDI5NiwzMC44OTgzNTkyIDIzLjY5MTQ4NTksMzEuMjk4MzU5MiAyMi4yOTQ4NjYyLDMxLjUyODcxMTMgQzIwLjg4NDM3MzIsMzEuNzM1MTE5NyAxOS40MzQwOTE1LDMxLjcxMTczOTQgMTguMDU1OTkzLDMxLjM4NTYxMjcgQzE3Ljk3OTg2NjIsMzEuMzY3NTg0NSAxNy45MzI4MjM5LDMxLjI5MTMxNjkgMTcuOTUwODUyMSwzMS4yMTUzMzEgQzE3Ljk2NjYyNjgsMzEuMTQ4NTcwNCAxOC4wMjc4OTQ0LDMxLjEwNDIwNDIgMTguMDkzOTUwNywzMS4xMDY0NTc3IEMxOS40Nzg3Mzk0LDMxLjE1MzU3MDQgMjAuODQ1NTcwNCwzMS4wOTU0MDE0IDIyLjE4NzMzMSwzMC44NTkyMDQyIEMyMy41MTI4MjM5LDMwLjYyNTgyMzkgMjQuODA3MTE5NywzMC4xNTAxMTk3IDI2LjA0NTU3MDQsMjkuNTkyMDkxNSBDMjcuMjY0Nzk1OCwyOC45OTc3OTU4IDI4LjM5Nzc1MzUsMjguMjMwODk0NCAyOS40MTExMzM4LDI3LjMyNzc5NTggQzMwLjQxOTU4NDUsMjYuNDEzODUyMSAzMS4yOTM2NjksMjUuMzc3ODY2MiAzMi4xNjY2MjY4LDI0LjI5NDYyNjggQzMyLjIxNTY0MDgsMjQuMjMzMjE4MyAzMi4zMDUwNzc1LDI0LjIyMzIxODMgMzIuMzY2NDg1OSwyNC4yNzIyMzI0IEMzMi40MTcwNDkzLDI0LjMxMjU4NDUgMzIuNDMyNDAxNCwyNC4zODExMDU2IDMyLjQwOTAyMTEsMjQuNDM4MDc3NSIgaWQ9IkZpbGwtMjMiIGZpbGw9IiNGRkZGRkYiPjwvcGF0aD4KICAgICAgICAgICAgPHBhdGggZD0iTTI1Ljk3MjM3MzIsMy45Mjg4OTQzNyBDMjYuMTUzMDc3NSwzLjk2NTkzNjYyIDI2LjMyODI4ODcsNC4wMTg2ODMxIDI2LjUwNDM0NTEsNC4wNzEzNTkxNSBDMjguMzkyMDkxNSw0LjYzNjIxODMxIDMwLjAzOTIwNDIsNi4xNzU3OTU3NyAzMS4yMzQwNjM0LDcuNjkyMzQ1MDcgQzMxLjY4NDk3ODksOC4yNjQ3Mzk0NCAzMi4wODY1OTg2LDguODgyNjk3MTggMzIuMzI5NDg1OSw5LjU3ODE5MDE0IEMzMi4zNTU3NTM1LDkuNjUzMjYwNTYgMzIuMzE2MTA1Niw5LjczNTM3MzI0IDMyLjI0MTAzNTIsOS43NjE1NzA0MiBDMzIuMTg1ODk0NCw5Ljc4MDc5NTc3IDMyLjEyNzAyMTEsOS43NjQ1OTg1OSAzMi4wODg2NDA4LDkuNzI0MjQ2NDggQzMxLjU5MjMwMjgsOS4yMDE2NDA4NSAzMS4xNjQyMDQyLDguNjU2NSAzMC43MDM1LDguMTMzODk0MzcgQzI5LjQzNjg4MDMsNi42OTY5OTI5NiAyNy44NDMxNDc5LDUuNjI0MDM1MjEgMjYuMjg4MjE4Myw0LjUwMzQwMTQxIEMyNi4xNDI5MzY2LDQuNDAyNjI2NzYgMjUuOTk2NjY5LDQuMzAxNzgxNjkgMjUuODU1OTY0OCw0LjE4NTM3MzI0IEwyNS44NTEzMTY5LDQuMTgxNTcwNDIgQzI1Ljc4OTkwODUsNC4xMzA3MjUzNSAyNS43ODEyNDY1LDQuMDM5NzM5NDQgMjUuODMyMTYyLDMuOTc4MzMwOTkgQzI1Ljg2NzMwMjgsMy45MzU3OTU3NyAyNS45MjE4ODAzLDMuOTE4NjEyNjggMjUuOTcyMzczMiwzLjkyODg5NDM3IiBpZD0iRmlsbC0yNSIgZmlsbD0iI0ZGRkZGRiI+PC9wYXRoPgogICAgICAgICAgICA8cGF0aCBkPSJNNi4yMjI0Mjk1OCwxMi42OTU2NDA4IEM2LjkyMzYyNjc2LDguNzc1MjE4MzEgMTAuMzUzMzQ1MSw0Ljk0MDcxMTI3IDE0LjE1MDE3NjEsMy43NjY5MDg0NSBDMTQuNDEzNzY3NiwzLjY4NTQyOTU4IDE0LjY3NzE0NzksMy42MDYwNjMzOCAxNC45NDI4NTIxLDMuNTM4NTI4MTcgQzE1LjAxODYyNjgsMy41MTkyMzIzOSAxNS4wOTU2NjksMy41NjUwNzc0NiAxNS4xMTQ4OTQ0LDMuNjQwODUyMTEgQzE1LjEzMDg4MDMsMy43MDM1MjgxNyAxNS4xMDIyMTgzLDMuNzY3MTE5NzIgMTUuMDQ4OTA4NSwzLjc5ODEwNTYzIEwxNS4wNDEzNzMyLDMuODAyNDAxNDEgQzEzLjE5NjE2Miw0Ljg2NDU4NDUxIDExLjMyMjkyMjUsNS45NTgxNzYwNiA5Ljg2ODIwNDIzLDcuNTM4MjQ2NDggQzguNDUwODA5ODYsOS4wNzc2ODMxIDcuMzg2NTE0MDgsMTAuOTAwNSA2LjQ5MDUyODE3LDEyLjc4MTc2NzYgQzYuNDU2Nzk1NzcsMTIuODUyNjEyNyA2LjM3MjAwNzA0LDEyLjg4MjYxMjcgNi4zMDExNjE5NywxMi44NDg4ODAzIEM2LjI0MjE0Nzg5LDEyLjgyMDc4MTcgNi4yMTE1MTQwOCwxMi43NTcwNDkzIDYuMjIyNDI5NTgsMTIuNjk1NjQwOCIgaWQ9IkZpbGwtMjciIGZpbGw9IiNGRkZGRkYiPjwvcGF0aD4KICAgICAgICAgICAgPHBhdGggZD0iTTE0LjAwMTE2MiwxMC40NTE3NDY1IEwxNC4wMDExNjIsMjQuNjQ1MTk3MiBDMTQuMDAxMTYyLDI1LjY3NTQwODUgMTUuMTE2NDQzNywyNi4zMTkyODE3IDE2LjAwODYyNjgsMjUuODA0MjExMyBMMjguMzAwNTI4MiwxOC43MDc0NTA3IEMyOS4xOTI3MTEzLDE4LjE5MjM4MDMgMjkuMTkyNzExMywxNi45MDQ1NjM0IDI4LjMwMDUyODIsMTYuMzg5NDkzIEwxNi4wMDg2MjY4LDkuMjkyNzMyMzkgQzE1LjExNjQ0MzcsOC43Nzc2NjE5NyAxNC4wMDExNjIsOS40MjE1MzUyMSAxNC4wMDExNjIsMTAuNDUxNzQ2NSIgaWQ9IkZpbGwtMjkiIGZpbGw9IiNGRkZGRkYiPjwvcGF0aD4KICAgICAgICA8L2c+CiAgICA8L2c+Cjwvc3ZnPg==) center center no-repeat !important;
}

.red-play.cola-theme::before,
.red-play.cola-theme::after {
  display: none !important;
}

.red-play.cola-theme .foxplay--ui-button-play-circle {
  display: none !important;
}

header.foxplay--header {
  width: 100%;
  height: auto;
  position: fixed;
  left: 0;
  top: 0;
  z-index: 11;
  -webkit-animation-fill-mode: forwards;
          animation-fill-mode: forwards;
}

header.foxplay--header::after {
  content: '';
  width: 100%;
  height: 1px;
  background: url(/images/foxplay--header-colorful-line.png?7306ff9175657cfdc805c373328af018) repeat-x left top;
  background-size: 100%;
  position: absolute;
  left: 0;
  bottom: 0;
  z-index: 3;
}

header.foxplay--header .foxplay--header-inner {
  width: 100%;
  background: #000000;
  position: relative;
  z-index: 3;
  -webkit-transition: all 0.2s ease-out;
  transition: all 0.2s ease-out;
}

header.foxplay--header > .container {
  z-index: 3;
  position: relative;
}

header.foxplay--header .row {
  position: static;
}

header.foxplay--header.foxplay--header-active .foxplay--header-inner {
  background: #000000;
}

header.foxplay--header.foxplay--header-sticky {
  background: #000000;
  position: fixed;
}

header.foxplay--header.foxplay--header-sticky > .container {
  background: #000000;
  -webkit-transition: all 0.9s ease-out;
  transition: all 0.9s ease-out;
}

header.foxplay--header .foxplay-hamburger {
  display: none;
}

header.foxplay--header .foxplay--brand {
  float: left;
  margin-top: 1.2em;
  margin-right: 2em;
}

header.foxplay--header .foxplay--brand img {
  width: auto;
  max-width: 7em;
  display: block;
}

header.foxplay--header .foxplay--brand a {
  display: block;
  text-decoration: none;
}

header.foxplay--header .foxplay--brand .icon-logo-fox {
  color: #ed2c24;
  font-size: 3.3em;
  display: inline-block;
  vertical-align: middle;
  margin: 0.1em -0.2em 0 0;
}

header.foxplay--header .foxplay--brand .icon-logo-play {
  color: #FFFFFF;
  font-size: 3.3em;
  display: inline-block;
  vertical-align: middle;
  position: relative;
  margin: 0.1em 0.6em 0 0;
  padding-right: 1.3rem;
}

header.foxplay--header .foxplay--brand .icon-logo-play::after {
  content: '';
  width: 1px;
  height: 0.5em;
  background: rgba(255, 255, 255, 0.1);
  position: absolute;
  right: 0;
  top: 0.25em;
}

header.foxplay--header .foxplay--nav {
  float: left;
}

header.foxplay--header .foxplay--nav ul {
  width: 100%;
}

header.foxplay--header .foxplay--nav ul li {
  display: block;
  float: left;
  margin-right: 2.2em;
  opacity: 0.8;
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

header.foxplay--header .foxplay--nav ul li.active,
header.foxplay--header .foxplay--nav ul li:hover {
  opacity: 1;
}

header.foxplay--header .foxplay--nav ul li > a {
  line-height: 5.3em;
  position: relative;
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 800;
  text-decoration: none;
  display: block;
}

header.foxplay--header .foxplay--nav ul li > a .icon {
  color: #FFFFFF;
  font-size: 0.8em;
  margin-left: 0.8em;
}

header.foxplay--header .foxplay--nav ul li.active > a::after {
  width: 100%;
  height: 1px;
  background: #FFFFFF;
  content: '';
  position: absolute;
  left: 0;
  bottom: 0;
  z-index: 1;
}

header.foxplay--header .foxplay--header-action {
  float: right;
  margin-top: 1.7em;
  -webkit-transition: all 0.5s ease-in-out;
  transition: all 0.5s ease-in-out;
}

header.foxplay--header .foxplay--header-action .outgoing-url {
  color: #FFFFFF;
  font-size: 0.8em;
  text-decoration: none;
  margin-right: 10px;
  display: inline-block;
  vertical-align: top;
}

header.foxplay--header .foxplay--header-action .outgoing-url strong {
  color: #ed2c24;
}

header.foxplay--header .foxplay--header-action .search {
  width: 2.8em;
  height: 1.8em;
  border: 0;
  outline: 0;
  background: transparent;
  display: inline-block;
  vertical-align: top;
  cursor: pointer;
  margin-top: -0.25em;
}

header.foxplay--header .foxplay--header-action .search .icon {
  color: #FFFFFF;
  font-size: 1.5em;
}

header.foxplay--header .foxplay--header-action .foxplay--button {
  margin-top: -1em;
  margin-left: 1em;
}

header.foxplay--header .foxplay--header-action .foxplay--header-action-user {
  display: inline-block;
  vertical-align: middle;
  margin: -0.6em 0 0 0.5em;
}

header.foxplay--header .foxplay--header-action .foxplay--header-action-user a {
  display: block;
  text-decoration: none;
}

header.foxplay--header .foxplay--header-action .foxplay--header-action-user a i {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 900;
  display: inline-block;
  vertical-align: middle;
  text-decoration: none;
}

header.foxplay--header .foxplay--header-action .foxplay--header-action-user a span {
  width: 2em;
  height: 2em;
  line-height: 2em;
  background: #ed2c24;
  display: inline-block;
  vertical-align: middle;
  margin-left: 0.5em;
  text-align: center;
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 900;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

header.foxplay--header .foxplay--search-content {
  width: 100%;
  height: auto;
  background: black;
  position: absolute;
  left: 0;
  top: -30em;
  z-index: 5;
  -webkit-transition: all 0.2s cubic-bezier(0.17, 0.04, 0.03, 0.94);
  transition: all 0.2s cubic-bezier(0.17, 0.04, 0.03, 0.94);
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header {
  width: 100%;
  display: inline-block;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1) !important;
  -webkit-transition: all 0.2s cubic-bezier(0.17, 0.04, 0.03, 0.94);
  transition: all 0.2s cubic-bezier(0.17, 0.04, 0.03, 0.94);
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header .f-left {
  width: 75%;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header .icon-search {
  display: inline-block;
  vertical-align: middle;
  margin-right: 1em;
  padding-right: 1em;
  position: relative;
  opacity: 0.4;
  color: #FFFFFF;
  font-size: 1.4em;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header .icon-search::after {
  content: '';
  width: 1px;
  height: 100%;
  background: #FFFFFF;
  position: absolute;
  right: 0;
  top: 0;
  z-index: 1;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header input {
  width: 70%;
  height: 100%;
  background: transparent;
  border: 0;
  outline: 0;
  display: inline-block;
  padding: 1.5em 0;
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 200;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header form {
  display: block;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close {
  border: 0;
  outline: 0;
  background: #ed2c24;
  padding: 1em 1em 0.8em 1em;
  margin-top: 1.9em;
  cursor: pointer;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close i {
  color: #FFFFFF;
  font-size: 1.2em;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result {
  width: 100%;
  padding: 2em 0;
  display: none;
  -webkit-transition: all 0.4s cubic-bezier(0.17, 0.04, 0.03, 0.94);
  transition: all 0.4s cubic-bezier(0.17, 0.04, 0.03, 0.94);
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result.active {
  display: block;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result .mCustomScrollBox {
  height: auto;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-information {
  margin-bottom: 2.4em;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-information span {
  color: #FFFFFF;
  font-size: 0.7em;
  font-weight: 400;
  display: block;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-information span a {
  color: #ed2c24;
  font-weight: 700;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view {
  background: transparent;
  margin: 0;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item {
  width: 15.32%;
  min-height: auto;
  margin-right: 1.6% !important;
}

header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(6n) {
  margin-right: 0 !important;
}

.foxplay--header-sub-nav {
  width: 100%;
  background: rgba(0, 0, 0, 0.9);
  padding: 2.5em 0;
  position: absolute;
  left: 0;
  top: -30em;
  opacity: 0;
  z-index: 2;
  -webkit-transition: all 0.5s cubic-bezier(0.17, 0.04, 0.03, 0.94);
  transition: all 0.5s cubic-bezier(0.17, 0.04, 0.03, 0.94);
}

.foxplay--header-sub-nav a {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 500;
  display: block;
  margin-bottom: 1em;
  text-decoration: none;
}

.foxplay--header-sub-nav .nav-spacer {
  margin-right: 2em;
}

.foxplay--header-sub-nav .col-2 {
  margin-left: 0;
}

.foxplay--header-sub-nav nav {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -ms-flex-wrap: wrap;
      flex-wrap: wrap;
}

.foxplay--header-sub-nav nav a {
  width: 100%;
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 500;
  display: block;
  margin-bottom: 1em;
  text-decoration: none;
  opacity: 0.7;
  position: relative;
}

.foxplay--header-sub-nav nav a:hover,
.foxplay--header-sub-nav nav a.active {
  opacity: 1;
}

.foxplay--header-sub-nav nav a:hover:before,
.foxplay--header-sub-nav nav a.active:before {
  content: 'G';
  color: #ed2c24;
  font-size: 0.5em;
  font-family: 'FOXPLAY';
  position: absolute;
  left: -3em;
  top: 0.5em;
  z-index: 1;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo {
  position: relative;
  display: inline-block;
  overflow: hidden;
  border-top-left-radius: 0.1em;
  border-top-right-radius: 0.1em;
  border-bottom-left-radius: 0.1em;
  border-bottom-right-radius: 0.1em;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo img {
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo:hover img {
  -webkit-transform: scale(1.1);
  transform: scale(1.1);
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo .foxplay--header-sub-nav-promo-inner {
  width: 100%;
  height: 100%;
  position: absolute;
  z-index: 1;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo .foxplay--header-sub-nav-promo-inner img {
  width: 100%;
  display: block;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo .red-play {
  font-size: 0.75em;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo footer {
  width: 101%;
  height: 101%;
  position: absolute;
  left: 0;
  bottom: 0;
  z-index: 1;
  padding: 0.8em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  background: -webkit-gradient(linear, left top, left bottom, from(rgba(0, 0, 0, 0)), to(black));
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0) 0%, black 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#a6000000', GradientType=0);
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo footer .foxplay--header-sub-nav-promo-footer-wrap {
  position: absolute;
  left: 1em;
  bottom: 1em;
  text-align: left;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo footer .foxplay--header-sub-nav-promo-footer-wrap span {
  color: #FFFFFF;
  font-size: 1.2em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.2em;
}

.foxplay--header-sub-nav .foxplay--header-sub-nav-promo footer .foxplay--header-sub-nav-promo-footer-wrap i {
  color: #ed2c24;
  font-size: 0.7em;
  font-weight: 500;
  display: block;
}

.foxplay--main-slider {
  opacity: 0;
  height: 33.3em;
  position: relative;
  margin-top: 3em;
}

.foxplay--main-slider .owl-carousel,
.foxplay--main-slider .owl-stage-outer,
.foxplay--main-slider .owl-stage,
.foxplay--main-slider .owl-item,
.foxplay--main-slider .owl-item .item {
  height: 100%;
}

.foxplay--main-slider .red-play {
  font-size: 1.8em;
}

.foxplay--main-slider .foxplay--main-slider-overlay {
  width: 100%;
  height: 100%;
  background: url(/images/foxplay--slider-overlay-background.png?870d2d049ed13e886e975a1a80b67feb) no-repeat top center;
  background-size: cover;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 1;
  -webkit-backface-visibility: hidden;
          backface-visibility: hidden;
  opacity: 0.8;
}

.foxplay--main-slider .foxplay--main-slider-image {
  width: 100%;
  height: 100%;
  background-position: top center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative;
  -webkit-transform: scale(1);
          transform: scale(1);
}

.foxplay--main-slider .foxplay--main-slider-text {
  width: 100%;
  max-width: 25em;
  position: absolute;
  padding: 0;
  z-index: 5;
  top: 9rem;
}

.foxplay--main-slider .foxplay--main-slider-text h3 {
  color: #FFFFFF;
  font-size: 3.8em;
  font-weight: 700;
  display: block;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information * {
  display: inline-block;
  vertical-align: middle;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information span {
  font-size: 1em;
  font-weight: 500;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information .foxplay--main-slider-season {
  color: #ed2c24;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information .foxplay--badge-new {
  background: #ed2c24;
  color: #FFFFFF;
  font-size: 0.62em;
  font-weight: 600;
  line-height: 0.7em;
  padding: 0.55em;
  margin: 0.8em 0;
  margin-right: 2em;
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
}

.foxplay--main-slider .foxplay--main-slider-text p {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 200;
  line-height: 140%;
  display: block;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action {
  margin-top: 1.4em;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a {
  color: #FFFFFF;
  text-decoration: none;
  font-weight: 500;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a .foxplay--ui-button-play {
  display: inline-block;
  vertical-align: middle;
  position: relative;
  margin: 0.4em 1em 0 0.4em;
  font-size: 0.8em;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a span {
  font-size: 0.9em;
  font-weight: 700;
  display: inline-block;
  vertical-align: middle;
  margin-top: 0.5em;
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

.foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action a span:hover {
  opacity: 0.6;
}

.foxplay--main-slider .foxplay--main-slider-text > * {
  opacity: 0;
  position: relative;
  left: 5rem;
}

.foxplay--main-slider .owl-dots {
  position: absolute;
  right: 0.8rem;
  bottom: 1rem;
  z-index: 1;
  display: none;
}

.foxplay--main-slider .owl-dots .owl-dot {
  width: 7px;
  height: 7px;
  background: #D8D8D8;
  opacity: 0.3;
  margin-left: 5px;
  border: 0;
  outline: 0;
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
}

.foxplay--main-slider .owl-dots .owl-dot.active {
  background: #ed2c24;
  opacity: 1;
}

.foxplay--main-slider-thumb {
  width: 100%;
  max-width: 50%;
  margin: 0 auto;
  margin-top: 0em;
  opacity: 0;
}

.foxplay--main-slider-thumb .owl-item {
  opacity: 0.7;
  position: relative;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--main-slider-thumb .owl-item.active.center,
.foxplay--main-slider-thumb .owl-item:hover {
  opacity: 1;
}

.foxplay--main-slider-thumb .owl-item .owl-thumb-item-bar {
  content: '';
  width: auto;
  height: 2px;
  background: #ed2c24;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 3;
  display: block;
  opacity: 0;
}

.foxplay--main-slider-thumb .owl-item.active.center .owl-thumb-item-bar {
  opacity: 1;
}

main {
  margin: 7.3em 0 3em 0;
  display: block;
}

main.foxplay--video-play {
  margin: 3em 0 3em 0;
}

main.foxplay--video-play .foxplay--data-container .foxplay--video-container {
  height: auto;
  background: #000000;
  padding: 0;
}

main.foxplay--video-play .foxplay--data-container .foxplay--video-container .foxplay--video-container-inner .foxplay--main-player {
  padding: 0;
}

main.foxplay--video-play.player-skin .container:first-child {
  width: 100%;
  max-width: 100%;
}

main.foxplay--video-play.player-skin .container:first-child .foxplay--video-container {
  height: 585px;
}

.foxplay--home main {
  margin: 1em 0;
}

.foxplay--content-title {
  width: 100%;
  margin: 1em 0;
}

.foxplay--content-title h2 {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 500;
  letter-spacing: 0.1em;
  display: inline-block;
  padding-bottom: 0.5em;
  border-bottom: 0.02em solid #ed2c24;
}

.foxplay--owl-type-one {
  margin-bottom: 1em;
}

.foxplay--owl-type-one .owl-stage-outer {
  padding: 1.13em 0;
  margin: -0.5em -3.5rem -0.5em -3.5rem;
  -webkit-transition: all 0.23s ease-in-out;
  transition: all 0.23s ease-in-out;
}

.foxplay--owl-type-one .owl-stage-outer::before {
  content: '';
  width: 5em;
  height: 100%;
  background-image: -webkit-gradient(linear, left top, right top, color-stop(5%, #161616), to(rgba(24, 25, 26, 0)));
  background-image: linear-gradient(90deg, #161616 5%, rgba(24, 25, 26, 0));
  position: absolute;
  left: -1px;
  top: 0;
  z-index: 1;
}

.foxplay--owl-type-one .owl-stage-outer::after {
  content: '';
  width: 5em;
  height: 100%;
  background-image: -webkit-gradient(linear, right top, left top, color-stop(5%, #161616), to(rgba(24, 25, 26, 0)));
  background-image: linear-gradient(-90deg, #161616 5%, rgba(24, 25, 26, 0));
  position: absolute;
  right: -1px;
  top: 0;
  z-index: 1;
}

.foxplay--owl-type-one .owl-stage-outer .owl-stage {
  padding-left: 3.5rem;
  padding-right: 3.5rem;
  -webkit-transition: all 0.2s cubic-bezier(0.19, 1, 0.22, 1);
  transition: all 0.2s cubic-bezier(0.19, 1, 0.22, 1);
}

.foxplay--owl-type-one .owl-stage-outer .owl-stage .owl-item {
  overflow: hidden;
  border: 1px solid transparent;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
  border-top-left-radius: 0.1em;
  border-top-right-radius: 0.1em;
  border-bottom-left-radius: 0.1em;
  border-bottom-right-radius: 0.1em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--owl-type-one .owl-stage-outer .owl-stage .owl-item img {
  width: 100%;
  margin: 0;
  padding: 0;
  border-top-left-radius: 0.1em;
  border-top-right-radius: 0.1em;
  border-bottom-left-radius: 0.1em;
  border-bottom-right-radius: 0.1em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  display: block;
}

.foxplay--owl-type-one .owl-stage-outer .owl-stage .owl-item.move-left {
  -webkit-transform: translateX(-2em);
          transform: translateX(-2em);
}

.foxplay--owl-type-one .owl-stage-outer .owl-stage .owl-item.move-right {
  -webkit-transform: translateX(2em);
          transform: translateX(2em);
}

.foxplay--owl-type-one .owl-stage-outer .owl-stage .owl-item.owl-active {
  -webkit-transform: scale(1.2);
          transform: scale(1.2);
  position: relative;
  z-index: 1;
  border: 1px solid #ed2c24;
}

.foxplay--owl-type-one .red-play {
  font-size: 0.75em;
}

.foxplay--owl-type-one .item {
  position: relative;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--owl-type-one .item:hover .foxplay--owl-type-one-information {
  opacity: 1;
}

.foxplay--owl-type-one .foxplay--owl-type-one-information {
  width: 100%;
  height: 101%;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 3;
  opacity: 0;
  -webkit-transition: all 0.3s cubic-bezier(0.19, 1, 0.22, 1);
  transition: all 0.3s cubic-bezier(0.19, 1, 0.22, 1);
}

.foxplay--owl-type-one .foxplay--owl-type-one-information footer {
  width: 101%;
  height: 101%;
  position: absolute;
  left: 0;
  bottom: 0;
  z-index: 1;
  padding: 0.8em;
  background: -webkit-gradient(linear, left top, left bottom, from(rgba(0, 0, 0, 0)), to(black));
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0) 0%, black 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#a6000000', GradientType=0);
}

.foxplay--owl-type-one .foxplay--owl-type-one-information footer .foxplay--footer-wrap {
  position: absolute;
  left: 1em;
  bottom: 1em;
}

.foxplay--owl-type-one .foxplay--owl-type-one-information footer .foxplay--footer-wrap span {
  color: #FFFFFF;
  font-size: 0.7em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.2em;
}

.foxplay--owl-type-one .foxplay--owl-type-one-information footer .foxplay--footer-wrap i {
  color: #ed2c24;
  font-size: 0.5em;
  font-weight: 500;
  display: block;
}

.foxplay--owl-type-one .foxplay--owl-type-one-information footer i.icon {
  color: #FFFFFF;
  font-size: 0.7rem;
  position: absolute;
  right: 1rem;
  bottom: 1rem;
  display: none;
}

.foxplay--owl-type-one .owl-dots {
  position: absolute;
  right: 0;
  top: -1.9em;
  z-index: 1;
}

.foxplay--owl-type-one .owl-dots .owl-dot {
  width: 7px;
  height: 7px;
  background: #D8D8D8;
  opacity: 0.3;
  margin-left: 5px;
  border: 0;
  outline: 0;
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
}

.foxplay--owl-type-one .owl-dots .owl-dot.active {
  background: #ed2c24;
  opacity: 1;
}

.foxplay--owl-type-two .owl-stage-outer {
  margin: -0.5em -3.5em 0.5em -3.5em;
}

.foxplay--owl-type-two .owl-stage-outer::before {
  content: '';
  width: 5em;
  height: 100%;
  background-image: -webkit-gradient(linear, left top, right top, color-stop(5%, #161616), to(rgba(24, 25, 26, 0)));
  background-image: linear-gradient(90deg, #161616 5%, rgba(24, 25, 26, 0));
  position: absolute;
  left: -1px;
  top: 0;
  z-index: 1;
}

.foxplay--owl-type-two .owl-stage-outer::after {
  content: '';
  width: 5em;
  height: 100%;
  background-image: -webkit-gradient(linear, right top, left top, color-stop(5%, #161616), to(rgba(24, 25, 26, 0)));
  background-image: linear-gradient(-90deg, #161616 5%, rgba(24, 25, 26, 0));
  position: absolute;
  right: -1px;
  top: 0;
  z-index: 1;
}

.foxplay--owl-type-two .owl-stage-outer .owl-stage {
  padding: 1.2em 3.5em 1.4em 3.5em;
}

.foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item {
  overflow: hidden;
  border: 1px solid transparent;
  -webkit-transition: all 0.23s ease-in-out;
  transition: all 0.23s ease-in-out;
  border-top-left-radius: 0.1em;
  border-top-right-radius: 0.1em;
  border-bottom-left-radius: 0.1em;
  border-bottom-right-radius: 0.1em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item img {
  width: 100%;
  display: block;
  border-top-left-radius: 0.1em;
  border-top-right-radius: 0.1em;
  border-bottom-left-radius: 0.1em;
  border-bottom-right-radius: 0.1em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item.move-left {
  -webkit-transform: translateX(-2em);
          transform: translateX(-2em);
}

.foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item.move-right {
  -webkit-transform: translateX(2em);
          transform: translateX(2em);
}

.foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item.owl-active {
  -webkit-transform: scale(1.1);
          transform: scale(1.1);
  position: relative;
  z-index: 1;
  border: 1px solid #ed2c24;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--owl-type-two .red-play {
  font-size: 1.4em;
}

.foxplay--owl-type-two .item {
  position: relative;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--owl-type-two .item:hover .foxplay--owl-type-two-information {
  opacity: 1;
}

.foxplay--owl-type-two .foxplay--owl-type-two-information {
  width: 100%;
  height: 101%;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 3;
  opacity: 0;
  -webkit-transition: all 0.35s cubic-bezier(0.19, 1, 0.22, 1);
  transition: all 0.35s cubic-bezier(0.19, 1, 0.22, 1);
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.foxplay--owl-type-two .foxplay--owl-type-two-information footer {
  width: 101%;
  height: 100%;
  position: absolute;
  left: 0;
  bottom: 0;
  z-index: -1;
  padding: 0.8em;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  background: -webkit-gradient(linear, left top, left bottom, from(rgba(0, 0, 0, 0)), to(black));
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0) 0%, black 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#a6000000', GradientType=0);
}

.foxplay--owl-type-two .foxplay--owl-type-two-information footer .foxplay--footer-wrap {
  position: absolute;
  left: 1.5em;
  bottom: 1.5em;
}

.foxplay--owl-type-two .foxplay--owl-type-two-information footer .foxplay--footer-wrap span {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.3em;
}

.foxplay--owl-type-two .foxplay--owl-type-two-information footer .foxplay--footer-wrap i {
  color: #ed2c24;
  font-size: 0.7em;
  font-weight: 500;
  display: block;
}

.foxplay--owl-type-two .owl-dots {
  position: absolute;
  right: 0;
  top: -1.9em;
  z-index: 1;
}

.foxplay--owl-type-two .owl-dots .owl-dot {
  width: 7px;
  height: 7px;
  background: #D8D8D8;
  opacity: 0.3;
  margin-left: 5px;
  border: 0;
  outline: 0;
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
}

.foxplay--owl-type-two .owl-dots .owl-dot.active {
  background: #ed2c24;
  opacity: 1;
}

.owl-prev {
  width: 1.7em;
  height: 1.7em;
  background: rgba(12, 12, 12, 0.5) !important;
  outline: 0;
  padding: 0.8em;
  position: absolute;
  left: -0.8em;
  top: 50%;
  margin-top: -0.85em;
  z-index: 3;
  -webkit-box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
}

.owl-prev.disabled {
  display: none;
}

.owl-prev:hover {
  background: #0c0c0c !important;
}

.owl-prev::after {
  content: 'H';
  font-size: 0.6em;
  font-family: 'FOXPLAY';
  margin: -0.1em 0 0 -0.1em;
  display: inline-block;
}

.owl-prev span {
  display: none;
}

.owl-next {
  width: 1.7em;
  height: 1.7em;
  background: rgba(12, 12, 12, 0.5) !important;
  outline: 0;
  padding: 0.8em;
  position: absolute;
  right: -0.9em;
  top: 50%;
  margin-top: -0.85em;
  z-index: 3;
  -webkit-box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  border-top-left-radius: 3em;
  border-top-right-radius: 3em;
  border-bottom-left-radius: 3em;
  border-bottom-right-radius: 3em;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
}

.owl-next.disabled {
  display: none;
}

.owl-next:hover {
  background: #0c0c0c !important;
}

.owl-next::after {
  content: 'G';
  font-size: 0.6em;
  font-family: 'FOXPLAY';
  margin: 0.1em 0 0 0.1em;
  display: inline-block;
}

.owl-next span {
  display: none;
}

footer.foxplay--footer {
  background: rgba(12, 12, 12, 0.3);
  border-top: 1px solid rgba(255, 255, 255, 0.1);
  padding: 3em 0 0 0;
}

footer.foxplay--footer .foxplay--brand {
  float: left;
}

footer.foxplay--footer .foxplay--brand a {
  display: block;
  text-decoration: none;
}

footer.foxplay--footer .foxplay--brand .icon-logo-fox {
  color: #ed2c24;
  font-size: 3.3em;
  display: inline-block;
  vertical-align: middle;
  margin: -0.3em -0.2em 0 0;
}

footer.foxplay--footer .foxplay--brand .icon-logo-play {
  color: #FFFFFF;
  font-size: 3.3em;
  display: inline-block;
  vertical-align: middle;
  position: relative;
  margin: -0.27em -0.2em 0 0;
}

footer.foxplay--footer .foxplay--brand span {
  color: #FFFFFF;
  font-size: 0.6em;
  font-weight: 400;
  display: block;
  margin-top: -1em;
  margin-left: 1em;
}

footer.foxplay--footer .icon-logo-fox-original {
  color: #FC2112;
  font-size: 3.3em;
  display: inline-block;
  vertical-align: middle;
  margin-left: 0.7rem;
}

footer.foxplay--footer h4 a {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 800;
  display: block;
  margin-bottom: 1.4em;
  text-decoration: none;
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

footer.foxplay--footer h4 a:hover {
  opacity: 0.7;
}

footer.foxplay--footer nav {
  display: block;
}

footer.foxplay--footer nav a {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 300;
  display: block;
  margin-bottom: 1em;
  text-decoration: none;
  position: relative;
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

footer.foxplay--footer nav a::before {
  content: '';
  width: 2px;
  height: 2px;
  background: #ed2c24;
  position: absolute;
  left: -1em;
  top: 0.4em;
}

footer.foxplay--footer nav a:hover {
  opacity: 0.7;
}

footer.foxplay--footer .foxplay--footer-bottom-bar {
  display: block;
  padding: 1.5em;
  margin-top: 2em;
  border-top: 1px solid rgba(255, 255, 255, 0.1);
}

footer.foxplay--footer .foxplay--footer-bottom-bar:last-child {
  margin-top: 0;
}

footer.foxplay--footer .foxplay--footer-bottom-bar span {
  color: #676767;
  font-size: 0.65em;
  display: block;
}

footer.foxplay--footer .foxplay--footer-bottom-bar ul {
  width: auto;
  display: inline-block;
}

footer.foxplay--footer .foxplay--footer-bottom-bar ul li {
  display: inline-block;
  vertical-align: middle;
  margin: 0 1em;
}

footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li a {
  display: block;
}

footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li img {
  height: 23px;
  display: block;
}

footer.foxplay--footer .icon-app-store {
  color: #FFFFFF;
  background: rgba(12, 12, 12, 0.3);
  margin-bottom: 1em;
  display: inline-block;
  height: 2.77em;
  line-height: 2.27em;
}

footer.foxplay--footer .icon-app-store::before {
  font-size: 7em;
  height: 0.27em;
  line-height: 0.27em;
  display: inline-block;
  overflow: hidden;
  padding: 0.06em 0.13em;
  -webkit-box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  border-top-left-radius: 0.4rem;
  border-top-right-radius: 0.4rem;
  border-bottom-left-radius: 0.4rem;
  border-bottom-right-radius: 0.4rem;
}

footer.foxplay--footer .icon-google-play {
  color: #FFFFFF;
  background: rgba(12, 12, 12, 0.3);
  margin-bottom: 1em;
  display: inline-block;
}

footer.foxplay--footer .icon-google-play::before {
  font-size: 7em;
  height: 0.27em;
  line-height: 0.27em;
  display: inline-block;
  overflow: hidden;
  padding: 0.06em 0.13em;
  -webkit-box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.5);
  border-top-left-radius: 0.4rem;
  border-top-right-radius: 0.4rem;
  border-bottom-left-radius: 0.4rem;
  border-bottom-right-radius: 0.4rem;
}

footer.foxplay--footer .foxplay--social-buttons a {
  font-size: 1em;
  color: #FFFFFF;
  display: inline-block;
  vertical-align: middle;
  margin-right: 0.8em;
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

footer.foxplay--footer .foxplay--social-buttons a:hover {
  opacity: 0.7;
}

.foxplay--data-container .foxplay--video-container {
  height: 100%;
  min-height: 410px;
  overflow: hidden;
  margin-bottom: 2em;
  position: relative;
}

.foxplay--data-container .foxplay--video-container.playerSkin {
  min-height: 640px;
}

.foxplay--data-container .foxplay--video-container .foxplay--video-container-inner {
  width: 100%;
  max-width: 860px;
  min-height: 620px;
  margin: 15px auto 0 auto;
  position: relative;
  z-index: 1;
}

.foxplay--data-container .foxplay--video-container .foxplay--video-container-inner.playerSkin {
  min-height: auto;
}

.foxplay--data-container .foxplay--video-container .foxplay--video-container-inner.full-width {
  max-width: 960px;
}

.foxplay--data-container .foxplay--video-container .foxplay--video-container-inner .foxplay--main-player {
  padding-top: 2.8rem;
}

.foxplay--data-container .foxplay--video-container #playerSkin {
  width: 100%;
  height: 100%;
  position: absolute;
  left: 0;
  top: 0;
  z-index: 0;
  background-position: top center !important;
}

.foxplay--data-container .foxplay--video-container #playerSkin a {
  width: 100%;
  height: 100%;
  display: block;
}

.foxplay--data-container .foxplay--video-container .foxplay--column-ad {
  position: absolute;
  top: 0;
  z-index: 2;
}

.foxplay--data-container .foxplay--video-container .foxplay--column-ad.column-left {
  left: -180px;
}

.foxplay--data-container .foxplay--video-container .foxplay--column-ad.column-right {
  right: -180px;
}

.foxplay--data-container .foxplay--program h1 {
  color: #FFFFFF;
  font-size: 2em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.5em;
}

.foxplay--data-container .foxplay--program .foxplay--program-information {
  margin-bottom: 1em;
}

.foxplay--data-container .foxplay--program .foxplay--program-information * {
  display: inline-block;
  vertical-align: middle;
}

.foxplay--data-container .foxplay--program .foxplay--program-information span {
  font-size: 1em;
  font-weight: 500;
}

.foxplay--data-container .foxplay--program .foxplay--program-information .foxplay--program-season {
  color: #ed2c24;
}

.foxplay--data-container .foxplay--program .foxplay--program-information .foxplay--badge-new {
  background: #ed2c24;
  color: #FFFFFF;
  font-size: 0.62em;
  font-weight: 700;
  line-height: 0.62em;
  padding: 0.55em;
  margin: 0 10px;
  border-top-left-radius: 20px;
  border-top-right-radius: 20px;
  border-bottom-left-radius: 20px;
  border-bottom-right-radius: 20px;
}

.foxplay--data-container .foxplay--program p {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 200;
  display: block;
  margin-bottom: 1em;
  line-height: 1.5em;
}

.foxplay--data-container .foxplay--program .hidden-full-text {
  display: none;
}

.foxplay--data-container .foxplay--program h6 {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.6em;
}

.foxplay--data-container .foxplay--program span {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 200;
  display: block;
  margin-bottom: 1.5em;
  line-height: 1.4em;
}

.foxplay--data-container .foxplay--program a {
  color: #FFFFFF;
}

.foxplay--data-container .foxplay--program-action {
  margin-bottom: 2em;
}

.foxplay--data-container .foxplay--program-action sup {
  color: #FFFFFF;
  font-size: 0.7em;
  display: inline-block;
  vertical-align: middle;
  margin-left: 1em;
}

.foxplay--data-container .foxplay--program-action sup strong {
  font-weight: 700;
}

.foxplay--data-container .foxplay--program-action .foxplay--ui-button {
  font-size: 0.7em;
  padding: 0.9em 0.8em;
}

.foxplay--data-container .foxplay--tweetarea {
  width: 100%;
  background: #1b1b1b;
  padding: 7%;
  display: inline-block;
  text-align: center;
}

.foxplay--data-container .foxplay--tweetarea .icon {
  color: #4499da;
  font-size: 3em;
  display: inline-block;
  vertical-align: middle;
  margin-right: 20px;
  line-height: 0;
}

.foxplay--data-container .foxplay--tweetarea a {
  background: #4499da;
  padding: 3% 12%;
  display: inline-block;
  vertical-align: middle;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
  text-decoration: none;
  color: #FFFFFF;
  font-size: 1.2rem;
  font-weight: 400;
  text-align: center;
}

.foxplay--data-container .foxplay--tweetarea a strong {
  font-size: 1.4rem;
  display: block;
  font-weight: 800;
}

.foxplay--data-container .foxplay--program-extras {
  width: 100%;
  margin: 2em 0 0 0;
  display: inline-block;
}

.foxplay--data-container .foxplay--program-extras header {
  width: 100%;
  display: inline-block;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
}

.foxplay--data-container .foxplay--program-extras header a {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 400;
  text-decoration: none;
  display: inline-block;
  vertical-align: bottom;
  margin-right: 1em;
  padding: 10px 0;
  position: relative;
  opacity: 0.3;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--data-container .foxplay--program-extras header a::after {
  width: 100%;
  height: 1px;
  background: transparent;
  content: '';
  position: absolute;
  left: 0;
  bottom: 0;
}

.foxplay--data-container .foxplay--program-extras header a:hover {
  opacity: 1;
}

.foxplay--data-container .foxplay--program-extras header a.active {
  opacity: 1;
}

.foxplay--data-container .foxplay--program-extras header a.active::after {
  background: #ed2c24;
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content {
  width: 100%;
  margin: 1.5em 0 0 0;
  display: inline-block;
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content h3 {
  color: #FFFFFF;
  font-size: 1.4em;
  font-weight: 700;
  margin-bottom: 0.8em;
  display: block;
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content p {
  color: #FFFFFF;
  font-size: 0.9em;
  display: block;
  margin-bottom: 0.8em;
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content nav a {
  background: transparent;
  color: #FFFFFF;
  font-size: 0.7em;
  display: inline-block;
  margin-right: 0.8em;
  text-decoration: none;
  padding: 10px;
  border-top-left-radius: 20px;
  border-top-right-radius: 20px;
  border-bottom-left-radius: 20px;
  border-bottom-right-radius: 20px;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
  -webkit-box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.1);
  box-shadow: 0px 0px 0px 1px rgba(255, 255, 255, 0.1);
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content nav a.active {
  background: #FFFFFF;
  color: #161616;
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content nav a:hover {
  background: #FFFFFF;
  color: #161616;
  -webkit-box-shadow: 0px 0px 0px 1px white;
  box-shadow: 0px 0px 0px 1px white;
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content nav a.red {
  background: #ed2c24;
  color: #FFFFFF;
  -webkit-box-shadow: 0px 0px 0px 0px #ed2c24;
  box-shadow: 0px 0px 0px 0px #ed2c24;
}

.foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content nav a.red:hover {
  -webkit-box-shadow: 0px 0px 0px 0px #ed2c24;
  box-shadow: 0px 0px 0px 0px #ed2c24;
}

.foxplay--grid-view {
  width: 100%;
  display: inline-block;
  margin: 1.5em 0;
}

.foxplay--grid-view .foxplay--grid-view-item {
  width: 18.72%;
  min-height: 12em;
  margin-right: 1.6%;
  margin-bottom: 1.6%;
  float: left;
  overflow: hidden;
}

.foxplay--grid-view .foxplay--grid-view-item a {
  text-decoration: none;
}

.foxplay--grid-view .foxplay--grid-view-item:nth-child(5n) {
  margin-right: 0;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content {
  position: relative;
  overflow: hidden;
  border: 1px solid transparent;
  -webkit-transition: all 0.28s ease-in-out;
  transition: all 0.28s ease-in-out;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content .foxplay--grid-view-item-content-fly {
  width: 100%;
  height: 100%;
  background: rgba(12, 12, 12, 0.8);
  position: absolute;
  left: 0;
  top: 0;
  z-index: 1;
  padding: 1em;
  opacity: 0;
  -webkit-transition: all 0.28s ease-in-out;
  transition: all 0.28s ease-in-out;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content .foxplay--grid-view-item-content-fly span {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 500;
  display: block;
  margin-bottom: 0.5rem;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content .foxplay--grid-view-item-content-fly p {
  color: #FFFFFF;
  font-size: 0.7em;
  font-weight: 300;
  line-height: 1rem;
  display: block;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer {
  width: 101%;
  height: 101%;
  position: absolute;
  left: 0;
  bottom: -1px;
  z-index: 1;
  padding: 0.8em;
  background: -webkit-gradient(linear, left top, left bottom, from(rgba(0, 0, 0, 0)), to(black));
  background: linear-gradient(to bottom, rgba(0, 0, 0, 0) 0%, black 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#a6000000', GradientType=0);
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap {
  position: absolute;
  left: 1em;
  bottom: 1em;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap span {
  color: #FFFFFF;
  font-size: 0.7em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.2em;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap i {
  color: #ed2c24;
  font-size: 0.5em;
  font-weight: 500;
  display: block;
}

.foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer i.icon {
  color: #FFFFFF;
  font-size: 0.7rem;
  position: absolute;
  right: 1rem;
  bottom: 1rem;
  display: none;
}

.foxplay--grid-view .foxplay--grid-view-item .red-play {
  display: none;
}

.foxplay--grid-view .foxplay--grid-view-item:hover .foxplay--grid-view-item-content {
  border-color: #ed2c24;
}

.foxplay--grid-view .foxplay--grid-view-item:hover .foxplay--grid-view-item-content-fly {
  opacity: 1;
}

.foxplay--grid-view .foxplay--grid-view-item:hover img {
  -webkit-transform: scale(1.1);
          transform: scale(1.1);
}

.foxplay--grid-view .foxplay--grid-view-item:hover .red-play {
  display: block;
  font-size: 1.4em;
}

.foxplay--grid-view .foxplay--grid-view-item:hover .red-play i {
  margin-top: -0.1em;
}

.foxplay--grid-view .foxplay--grid-view-item:hover .red-play::after {
  width: 2.3em;
  height: 2.3em;
  margin: -1.15em 0 0 -1.15em;
}

.foxplay--grid-view .foxplay--grid-view-item img {
  width: 100%;
  display: block;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -webkit-transition: all 0.8s cubic-bezier(0.17, 0.04, 0.03, 0.94);
  transition: all 0.8s cubic-bezier(0.17, 0.04, 0.03, 0.94);
}

.foxplay--grid-view .foxplay--grid-view-item i {
  color: #FFFFFF;
  font-size: 0.75em;
  font-weight: 500;
  line-height: 1.2em;
  display: block;
  margin-top: 1em;
}

.foxplay--grid-view.column-view-4 .foxplay--grid-view-item {
  width: 23.72%;
  margin-right: 1.6%;
}

.foxplay--grid-view.column-view-4 .foxplay--grid-view-item:nth-child(4n) {
  margin-right: 0;
}

.foxplay--grid-view.auto-height .foxplay--grid-view-item {
  min-height: auto;
}

.foxplay--data-container {
  width: 100%;
  display: inline-block;
}

.foxplay--data-container aside {
  background: rgba(0, 0, 0, 0.9);
  padding: 3em 2.5em;
  border-top-left-radius: 0.2em;
  border-top-right-radius: 0.2em;
  border-bottom-left-radius: 0.2em;
  border-bottom-right-radius: 0.2em;
}

.foxplay--data-container aside h6 {
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 500;
  display: block;
  margin-bottom: 1.5em;
}

.foxplay--data-container aside h6 a {
  color: #FFFFFF;
  text-decoration: none;
}

.foxplay--data-container aside h6.has-link {
  margin-top: 2em;
}

.foxplay--data-container aside .divider {
  width: 100%;
  height: 1px;
  background: rgba(255, 255, 255, 0.1);
  display: block;
  margin: 2em 0;
}

.foxplay--data-container aside nav {
  display: block;
}

.foxplay--data-container aside nav a {
  color: #FFFFFF;
  font-size: 0.75em;
  font-weight: 500;
  display: block;
  margin-bottom: 1.5em;
  opacity: 0.3;
  position: relative;
  text-decoration: none;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--data-container aside nav a:hover {
  opacity: 1;
}

.foxplay--data-container aside nav a.active {
  opacity: 1;
}

.foxplay--data-container aside nav a.active::before {
  content: 'G';
  color: #ed2c24;
  font-size: 0.5em;
  font-family: 'FOXPLAY';
  position: absolute;
  left: -3em;
  top: 0.5em;
  z-index: 1;
}

.foxplay--data-container .foxplay--category-promo {
  width: 100%;
  overflow: hidden;
  position: relative;
  background-position: right top;
  background-repeat: no-repeat;
  background-size: cover;
  border-top-left-radius: 0.2em;
  border-top-right-radius: 0.2em;
  border-bottom-left-radius: 0.2em;
  border-bottom-right-radius: 0.2em;
}

.foxplay--data-container .foxplay--category-promo img {
  width: 100%;
  display: block;
}

.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-overlay {
  width: 100%;
  height: 101%;
  background-image: -webkit-gradient(linear, left top, right top, color-stop(30%, #000), to(rgba(24, 25, 26, 0)));
  background-image: linear-gradient(90deg, #000 30%, rgba(24, 25, 26, 0));
  position: absolute;
  left: 0;
  top: 0;
  z-index: 1;
}

.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information {
  width: 60%;
  position: relative;
  z-index: 2;
  padding: 3em;
}

.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information h1 {
  color: #FFFFFF;
  font-size: 2em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.4em;
}

.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information p {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 300;
  display: block;
  margin-bottom: 1.5em;
  line-height: 1.5em;
}

.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information p a {
  color: #FFFFFF;
  margin-right: 0.25em;
}

.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information p:last-child {
  margin-bottom: 0;
}

.foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information span {
  color: #FFFFFF;
  font-size: 0.85em;
  font-weight: 700;
  display: block;
  margin-bottom: 0.6em;
}

.foxplay--data-container .foxplay--category-promo .red-play {
  left: auto;
  right: 10em;
  font-size: 1.4em;
  z-index: 2;
}

.foxplay--data-container .foxplay--breadcrumbs {
  width: 49.5%;
  display: inline-block;
  vertical-align: middle;
}

.foxplay--data-container .foxplay--breadcrumbs h1 {
  color: #FFFFFF;
  font-size: 1.2em;
  display: block;
}

.foxplay--data-container .foxplay--breadcrumbs i {
  color: #FFFFFF;
  font-size: 0.7em;
  font-weight: 300;
  display: inline-block;
  vertical-align: middle;
  margin-top: 0.25em;
}

.foxplay--data-container .foxplay--breadcrumbs i strong {
  color: #ed2c24;
}

.foxplay--data-container .foxplay--breadcrumbs .foxplay--dropdown {
  display: inline-block;
  vertical-align: middle;
  margin-left: 1em;
}

.foxplay--mobile-navigation {
  width: 100%;
  height: 100%;
  background: #111212;
  position: fixed;
  left: -100%;
  top: 0;
  z-index: 4;
  padding: 6.3em 4em 4em 4em;
  -webkit-transition: all 0.4s cubic-bezier(0.17, 0.04, 0.03, 0.94);
  transition: all 0.4s cubic-bezier(0.17, 0.04, 0.03, 0.94);
}

.foxplay--mobile-navigation.active {
  left: 0;
}

.foxplay--mobile-navigation span {
  color: #FFFFFF;
  font-size: 1.4em;
  font-weight: 900;
  display: block;
  text-decoration: none;
  margin: 1.5em 0;
  position: relative;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--mobile-navigation ul {
  padding-bottom: 1em;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
}

.foxplay--mobile-navigation ul li {
  display: block;
  margin-bottom: 1.2em;
}

.foxplay--mobile-navigation ul li > a {
  color: #FFFFFF;
  font-size: 1.4em;
  font-weight: 900;
  display: block;
  text-decoration: none;
  margin: 1.5em 0;
  position: relative;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--mobile-navigation ul li.has-child > a::after {
  content: 'I';
  color: #ed2c24;
  font-size: 0.5em;
  font-family: 'FOXPLAY';
  position: absolute;
  right: 0;
  top: 0.5em;
}

.foxplay--mobile-navigation ul li.active > a::after {
  content: 'J';
}

.foxplay--mobile-navigation ul li nav {
  display: none;
  border-top: 1px solid rgba(255, 255, 255, 0.1);
  margin: 2em 0;
  padding: 2em 0 0 0;
}

.foxplay--mobile-navigation ul li nav h6 {
  color: #FFFFFF;
  font-size: 1.2em;
  font-weight: 600;
  display: block;
  text-decoration: none;
  margin-bottom: 0.85em;
  opacity: .9;
  position: relative;
}

.foxplay--mobile-navigation ul li nav a {
  color: #FFFFFF;
  font-size: 1.2em;
  font-weight: 400;
  display: block;
  text-decoration: none;
  margin-bottom: 0.85em;
  opacity: 0.5;
  position: relative;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--mobile-navigation ul li nav a:hover,
.foxplay--mobile-navigation ul li nav a.active {
  opacity: 1;
}

.foxplay--mobile-navigation ul li nav a:hover:before,
.foxplay--mobile-navigation ul li nav a.active:before {
  content: 'G';
  color: #ed2c24;
  font-size: 0.5em;
  font-family: 'FOXPLAY';
  position: absolute;
  left: -3em;
  top: 0.6em;
  z-index: 1;
}

.foxplay--mobile-navigation .foxplay--mobile-navigation-corporate-links {
  margin: 3em 0;
  padding: 0 1em;
}

.foxplay--mobile-navigation .foxplay--mobile-navigation-corporate-links nav {
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -ms-flex-wrap: wrap;
      flex-wrap: wrap;
}

.foxplay--mobile-navigation .foxplay--mobile-navigation-corporate-links nav a {
  width: 50%;
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 300;
  -webkit-box-flex: 1;
      -ms-flex-positive: 1;
          flex-grow: 1;
  text-decoration: none;
  margin-bottom: 1.5em;
  position: relative;
}

.foxplay--mobile-navigation .foxplay--mobile-navigation-corporate-links nav a::before {
  content: "";
  width: 2px;
  height: 2px;
  background: #ed2c24;
  position: absolute;
  left: -1em;
  top: 0.4em;
}

.foxplay--mobile-navigation .foxplay--social-buttons a {
  font-size: 1.6em;
  color: #FFFFFF;
  display: inline-block;
  vertical-align: middle;
  margin-right: 1.2em;
  -webkit-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

.foxplay--mobile-navigation .foxplay--social-buttons a:hover {
  opacity: 0.7;
}

.foxplay--mobile-navigation .outgoing-url {
  color: #ed2c24;
  font-size: 4em;
  text-decoration: none;
  margin-right: 1.5em;
  margin-top: 0.5em;
  display: inline-block;
  vertical-align: middle;
}

.video-js.vjs-foxplay-skin .vjs-big-play-button {
  overflow: visible;
  cursor: pointer;
  -webkit-transform: scale(0.8);
          transform: scale(0.8);
  border-top-left-radius: 20em;
  border-top-right-radius: 20em;
  border-bottom-left-radius: 20em;
  border-bottom-right-radius: 20em;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
}

.video-js.vjs-foxplay-skin .vjs-big-play-button .vjs-control-text {
  position: absolute;
  width: 6.4rem;
  height: 6.4rem;
  background: transparent;
  z-index: 0;
  left: 0;
  top: 0;
  border-radius: 100em;
  clip: unset;
  text-indent: -9999px;
  -webkit-transform: scale(1.2);
          transform: scale(1.2);
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
  -webkit-backface-visibility: hidden;
  backface-visibility: hidden;
  -webkit-box-shadow: 0px 0px 0px 1px #ed2c24;
  box-shadow: 0px 0px 0px 1px #ed2c24;
}

.video-js.vjs-foxplay-skin .vjs-big-play-button::before {
  color: #ed2c24 !important;
}

.video-js.vjs-foxplay-skin .vjs-big-play-button:hover {
  -webkit-transform: scale(1.1);
          transform: scale(1.1);
}

.video-js.vjs-foxplay-skin .vjs-big-play-button:hover .vjs-control-text {
  -webkit-transform: scale(0.7);
          transform: scale(0.7);
}

.video-js.vjs-foxplay-skin .vjs-volume-bar {
  bottom: 0em !important;
}

.video-js.vjs-foxplay-skin .vjs-menu {
  bottom: 4.5em;
}

.static-ad-banner {
  margin-top: 1em;
}

.static-ad-banner.desktop {
  display: block;
}

.static-ad-banner.mobile {
  display: none;
}

.vjs-loading-spinner {
  border: 0;
  outline: 0;
  width: 70px;
  margin-top: -75px;
  -webkit-animation-name: spinner;
  -webkit-animation-timing-function: linear;
  -webkit-animation-iteration-count: infinite;
  -webkit-animation-duration: 2s;
  animation-name: spinner;
  animation-timing-function: linear;
  animation-iteration-count: infinite;
  animation-duration: 2s;
  -webkit-transform-style: preserve-3d;
  transform-style: preserve-3d;
  -webkit-transform-origin: 50% 50%;
          transform-origin: 50% 50%;
}

.vjs-loading-spinner::before {
  display: none;
}

.vjs-loading-spinner::after {
  display: none;
}

.vjs-loading-spinner .icon {
  color: #ed2c24;
  font-size: 8em;
}

.foxplay--user-action {
  width: 100%;
  display: inline-block;
  border-top-left-radius: 0.3em;
  border-top-right-radius: 0.3em;
  border-bottom-left-radius: 0.3em;
  border-bottom-right-radius: 0.3em;
}

.foxplay--user-action .container {
  width: 100%;
}

.foxplay--user-action i {
  font-size: 0.8em;
  font-weight: 300;
  display: block;
  opacity: 0.7;
  line-height: 1.4em;
}

.foxplay--user-action header {
  width: 100%;
  display: block;
  margin-top: 1.5em;
}

.foxplay--user-action header h6 {
  color: #FFFFFF;
  font-size: 1.8em;
  font-weight: 300;
  display: inline-block;
}

.foxplay--user-action header span {
  float: right;
  color: #FFFFFF;
  font-size: 1.8em;
  font-weight: 300;
  text-decoration: none;
}

.foxplay--user-action header span sup {
  color: #5b5b5b;
  font-size: 1rem;
}

.foxplay--user-action section {
  margin: 2em 0;
}

.foxplay--user-action label {
  width: 100%;
  display: block;
  margin-bottom: 1em;
  position: relative;
}

.foxplay--user-action label.label-mid {
  width: 48.5%;
  float: left;
  margin-right: 3%;
}

.foxplay--user-action label.label-mid.no-margin-right {
  margin-right: 0;
}

.foxplay--user-action label.auto {
  width: auto;
  max-width: 150px;
  display: inline-block;
  vertical-align: middle;
  margin-right: 0.5em;
}

.foxplay--user-action label.auto input {
  width: auto;
}

.foxplay--user-action label.auto .foxplay--dropdown {
  width: auto;
}

.foxplay--user-action label.label-error textarea {
  border-color: #ed2c24;
}

.foxplay--user-action label.label-error input[type="text"],
.foxplay--user-action label.label-error input[type="password"],
.foxplay--user-action label.label-error input[type="email"],
.foxplay--user-action label.label-error .icheckbox,
.foxplay--user-action label.label-error .icheckbox-text {
  border-color: #ed2c24;
}

.foxplay--user-action label.label-error .icheckbox-text,
.foxplay--user-action label.label-error .icheckbox-text a {
  color: #ed2c24;
}

.foxplay--user-action label.label-error::after {
  content: 'W';
  color: #ed2c24;
  position: absolute;
  right: 0.5em;
  top: 0.7em;
  z-index: 2;
  font-size: 1.2em;
  font-family: 'FOXPLAY';
}

.foxplay--user-action label.label-error .foxplay--dropdown {
  border-color: #ed2c24 !important;
}

.foxplay--user-action label.label-error .foxplay--dropdown::after {
  display: none !important;
}

.foxplay--user-action label.label-error.none-icon::after {
  display: none;
}

.foxplay--user-action label.no-icon {
  text-align: left;
}

.foxplay--user-action label.no-icon::after {
  display: none;
}

.foxplay--user-action label .row-line {
  display: inline-block;
  vertical-align: middle;
  margin-right: 1em;
}

.foxplay--user-action label .row-line input[type="reset"] {
  min-width: 120px !important;
  margin: 0 !important;
}

.foxplay--user-action label .row-line input[type="submit"] {
  min-width: 120px;
}

.foxplay--user-action label input[type="text"],
.foxplay--user-action label input[type="password"],
.foxplay--user-action label input[type="email"] {
  width: 100%;
  background: transparent;
  padding: 0.6em 2em;
  text-align: left;
  display: block;
  outline: none;
  border: 1px solid #5b5b5b;
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 300;
  font-family: 'Saira', sans-serif;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--user-action label textarea {
  width: 100%;
  height: 100px;
  background: transparent;
  padding: 0.6em 2em;
  text-align: left;
  display: block;
  outline: none;
  border: 1px solid #5b5b5b;
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 300;
  line-height: 1.2em;
  font-family: 'Saira', sans-serif;
  border-top-left-radius: 1em;
  border-top-right-radius: 1em;
  border-bottom-left-radius: 1em;
  border-bottom-right-radius: 1em;
}

.foxplay--user-action label input[type="text"].icon-card {
  background: url(/images/foxplay--icon-card.svg?7a3f6794fb88623b8ff1cec773c64278) no-repeat 2em center;
  padding-left: 5em;
}

.foxplay--user-action label input[type="text"].icon-lock {
  background: url(/images/foxplay--icon-lock.svg?c4c212a8b04b2e9914a028e19d9da915) no-repeat 94% center;
  background-size: 10px;
}

.foxplay--user-action label input[type="submit"] {
  width: 100%;
  background: #ed2c24;
  padding: 0.85em 1em;
  text-align: center;
  display: block;
  outline: none;
  border: 1px solid #ed2c24;
  cursor: pointer;
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 900;
  font-family: 'Saira', sans-serif;
  -webkit-appearance: button;
  -moz-appearance: button;
  appearance: button;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
}

.foxplay--user-action label input[type="submit"]:hover {
  opacity: 0.8;
}

.foxplay--user-action label .form-notify {
  padding: 15px;
  border: 1px solid #5b5b5b;
  -webkit-box-sizing: border-box;
          box-sizing: border-box;
  border-radius: 10px;
}

.foxplay--user-action label .foxplay--dropdown.dark-theme {
  display: block;
  background: transparent;
  border: 1px solid #5b5b5b;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--user-action label .foxplay--dropdown.dark-theme button {
  font-family: 'Saira';
}

.foxplay--user-action label .foxplay--dropdown.dark-theme button::after {
  color: #FFFFFF;
  top: 1.8em;
}

.foxplay--user-action label .icheckbox {
  width: 1.2em;
  height: 1.2em;
  display: inline-block;
  vertical-align: middle;
  margin-right: 10px;
  border: 1px solid #5b5b5b;
  text-align: center;
  border-top-left-radius: 2px;
  border-top-right-radius: 2px;
  border-bottom-left-radius: 2px;
  border-bottom-right-radius: 2px;
}

.foxplay--user-action label .icheckbox input {
  left: 0;
  top: 0;
}

.foxplay--user-action label .icheckbox.checked .iCheck-helper {
  background: transparent !important;
  opacity: 1 !important;
  text-decoration: none;
}

.foxplay--user-action label .icheckbox.checked .iCheck-helper::before {
  content: 'V';
  color: #ed2c24;
  font-family: 'FOXPLAY';
  font-size: 0.6em;
  display: block;
  margin: 0.6em 0 0 0;
}

.foxplay--user-action label .iradio {
  width: 1.2em;
  height: 1.2em;
  display: inline-block;
  vertical-align: middle;
  margin-right: 10px;
  border: 1px solid #5b5b5b;
  text-align: center;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--user-action label .iradio input {
  left: 0;
  top: 0;
}

.foxplay--user-action label .iradio.checked .iCheck-helper {
  background: transparent !important;
  opacity: 1 !important;
  text-decoration: none;
}

.foxplay--user-action label .iradio.checked .iCheck-helper::before {
  content: '';
  width: 0.6em;
  height: 0.6em;
  background: #ed2c24;
  display: block;
  margin: 0.3em 0 0 0.3em;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--user-action label .icheckbox-text {
  width: 80%;
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 300;
  line-height: 1.2em;
  display: inline-block;
  vertical-align: top;
}

.foxplay--user-action label .icheckbox-text a {
  color: #FFFFFF;
  font-weight: 700;
}

.foxplay--user-action footer {
  text-align: center;
}

.foxplay--user-action footer i {
  display: inline-block;
  vertical-align: middle;
}

.foxplay--user-action footer i a {
  color: #FFFFFF;
  font-size: 1.1em;
  font-weight: 300;
  display: inline-block;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--user-action footer i a:hover {
  opacity: 0.8;
}

.foxplay--user-action footer span.divider {
  width: 1px;
  height: 30px;
  background: #FFFFFF;
  display: inline-block;
  vertical-align: middle;
  margin: 0 1.2em;
  opacity: 0.1;
}

.foxplay--user-action footer .foxplay--user-action-button {
  width: 12.5rem;
  display: inline-block;
  margin-top: 1.5em;
  margin-right: 3.2%;
  padding: 1em;
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 900;
  text-decoration: none;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--user-action footer .foxplay--user-action-button:last-child {
  margin-right: 0;
}

.foxplay--user-action footer .foxplay--user-action-button.facebook {
  background: #3B5893;
}

.foxplay--user-action footer .foxplay--user-action-button.twitter {
  background: #4CAEE7;
}

.foxplay--user-action footer .foxplay--user-action-button:hover {
  opacity: 0.8;
}

.foxplay--user-action .fancybox-button.fancybox-close-small {
  background: #ed2c24;
  opacity: 1;
  top: 2em;
  right: 2em;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--user-action .fancybox-button.fancybox-close-small:hover {
  opacity: 0.8;
}

.mCustomScrollBox {
  height: 90vh;
}

.foxplay--page-404 h1 {
  color: #FFFFFF;
  font-size: 4em;
  font-weight: 700;
  display: block;
  margin-top: 1em;
  margin-bottom: 1em;
  text-align: left;
}

.foxplay--page-404 .foxplay--404-tv img {
  width: auto;
  max-width: 100%;
  display: block;
}

.ima-controls-div {
  height: 2.6em !important;
}

.ima-controls-div.ima-controls-div-showing {
  height: 5.4em !important;
}

.foxPlayer_ima-countdown-div.ima-countdown-div,
.foxPlayer_ima-seek-bar-div.ima-seek-bar-div {
  width: 96% !important;
  margin: 0 2% !important;
}

.ima-fullscreen-div {
  top: 1.233em !important;
  right: 0.3em !important;
}

.ima-mute-div {
  top: 1.233em !important;
  right: 6em !important;
}

.ima-slider-div {
  top: 1.93em !important;
  right: 2.63em !important;
}

.ima-play-pause-div {
  left: 0.2em !important;
  top: 1.133em !important;
}

.foxPlay_ima-controls-part {
  background: #191919;
  padding: 1.6em 2.4em;
  position: absolute;
  left: 2%;
  bottom: 8em;
  text-align: center;
}

.foxPlay_ima-controls-part i {
  display: block;
  margin-bottom: 0.3em;
  color: #FFFFFF;
  font-weight: 700;
  font-size: 1.2em;
}

.foxPlay_ima-controls-part span {
  width: 15px;
  height: 3px;
  background: #A1A1A1;
  display: inline-block;
  margin: 0 0.25em;
}

.foxPlay_ima-controls-part span:first-child {
  background: #FFD601;
}

.foxplay--program-text-fix-area {
  overflow: hidden;
  position: relative;
  margin-bottom: 1em;
  z-index: 0;
}

.foxplay--program-text-fix-area.active {
  height: auto;
}

.foxplay--program-text-fix-area.active p {
  display: none;
}

.foxplay--program-text-fix-area.active p.hidden-full-text {
  display: block;
}

.foxplay--program-text-fix-area-expander {
  width: 100%;
  height: auto;
  background: -webkit-gradient(linear, left bottom, left top, color-stop(40%, #161616), to(rgba(24, 25, 26, 0)));
  background: linear-gradient(0deg, #161616 40%, rgba(24, 25, 26, 0));
  border: 0;
  outline: 0;
  display: block;
  margin: -5em 0 1em 0;
  padding: 4em 0 0 0;
  cursor: pointer;
  text-align: left;
  position: relative;
  z-index: 1;
  color: #FFFFFF;
  font-size: 0.85em;
  font-weight: 300;
  text-decoration: underline;
  display: block;
  letter-spacing: 2px;
}

.foxplay--program-text-fix-area-expander::after {
  content: 'I';
  color: #FFFFFF;
  font-size: 0.8em;
  font-family: 'FOXPLAY';
  margin-left: 1em;
  text-decoration: none;
}

.foxplay--program-text-fix-area-expander.active {
  margin: -2em 0 1em 0;
  padding: 1em 0 0 0;
}

.foxplay--program-text-fix-area-expander.active::after {
  content: 'J';
}

.pagination {
  display: block;
  text-align: right;
  margin: 1.2em 0;
}

.pagination li {
  display: inline-block;
  margin-right: 8px;
}

.pagination li a {
  width: 20px;
  height: 20px;
  line-height: 20px;
  color: #FFFFFF;
  font-size: 12px;
  font-weight: 400;
  display: block;
  padding: 5px;
  -webkit-text-decoration: navajowhite;
          text-decoration: navajowhite;
  text-align: center;
  border: 1px solid rgba(255, 255, 255, 0.2);
  border-top-left-radius: 4px;
  border-top-right-radius: 4px;
  border-bottom-left-radius: 4px;
  border-bottom-right-radius: 4px;
}

.pagination li.current a {
  border-color: transparent;
  background: #FFFFFF;
  color: #000000;
}

.foxplay--data-content {
  margin-top: 0;
  opacity: 1;
}

body.foxplay--home .foxplay--data-content {
  margin-top: 4em;
  opacity: 0;
}

body.foxplay--home header.foxplay--header {
  margin-top: -6em;
}

body.foxplay--home .foxplay--preloader {
  display: block;
}

.col-4 .advertising {
  display: inline-block;
}

/* -------------------------- LOGIN BOX -------------------------- */

main.foxplay--user-area {
  margin: 4.3em 0 0 0;
  display: block;
}

.foxplay--user-action header {
  margin-top: 0;
}

.foxplay--login-container {
  background: #151515;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -ms-flex-wrap: wrap;
      flex-wrap: wrap;
  -webkit-box-orient: horizontal;
  -webkit-box-direction: normal;
      -ms-flex-direction: row;
          flex-direction: row;
  -webkit-box-pack: start;
      -ms-flex-pack: start;
          justify-content: flex-start;
  -webkit-box-align: stretch;
      -ms-flex-align: stretch;
          align-items: stretch;
}

.foxplay--login-container .foxplay--login-container-col {
  width: 50%;
  height: auto;
  padding: 5em;
  background-repeat: no-repeat;
  background-position: top center;
  background-size: contain;
}

.foxplay--login-container .foxplay--login-container-col img {
  width: auto;
  max-width: 100%;
  display: inline-block;
  margin-bottom: 4em;
}

.foxplay--login-container .foxplay--login-container-col h4 {
  color: #FFFFFF;
  font-size: 1.8em;
  font-weight: 700;
  display: block;
  margin-bottom: 1em;
}

.foxplay--login-container span {
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 300;
  display: inline-block;
  margin-bottom: 0.8em;
}

.foxplay--login-container span i {
  color: #ed2c24;
  font-size: 1em;
  display: inline-block;
  vertical-align: middle;
  margin-right: 1em;
}

.foxplay--login-container span strong {
  font-weight: 700;
}

.foxplay--login-container span a {
  color: #FFFFFF;
}

.foxplay--login-container .invalid-feedback {
  display: block;
  text-align: left;
}

.foxplay--login-container .invalid-feedback strong {
  font-weight: 300;
  font-size: 0.9rem;
  color: red;
  display: block;
  margin-top: 1rem;
  margin-left: 0;
}

.foxplay--login-container .foxplay--user-action {
  max-width: 700px;
  text-align: left;
}

.foxplay--login-container .foxplay--user-action footer {
  text-align: center;
}

.foxplay--login-container.login .foxplay--user-action {
  max-width: 400px;
  text-align: center;
}

.foxplay--login-container.login .foxplay--user-action footer {
  text-align: center;
}

.foxplay--login-container .foxplay--dropdown.dark-theme {
  display: block;
  background: transparent;
  border: 1px solid #5b5b5b;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--login-container .foxplay--dropdown.dark-theme button {
  font-family: 'Saira';
}

.foxplay--login-container .foxplay--dropdown.dark-theme button::after {
  color: #FFFFFF;
  top: 1.8em;
}

.foxplay--login-container .foxplay--user-action-result {
  display: none;
}

.foxplay--login-container .foxplay--user-action-result img {
  width: auto;
  max-width: 100%;
  display: inline-block;
  margin-bottom: 2em;
}

.foxplay--login-container .foxplay--user-action-result h4 {
  color: #FFFFFF;
  font-size: 1.6em;
  font-weight: 600;
  display: block;
  margin-bottom: 0.4em;
}

.foxplay--login-container .foxplay--user-action-result .foxplay--user-action-result-button {
  margin-top: 3em;
}

.foxplay--login-container .foxplay--user-action-result.visible {
  display: block;
}

.foxplay--user-area-container {
  width: 100%;
  margin: 4em 0 0 0;
  display: inline-block;
}

.foxplay--user-area-container header {
  width: 100%;
  display: inline-block;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
}

.foxplay--user-area-container header a {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 400;
  text-decoration: none;
  display: inline-block;
  vertical-align: bottom;
  margin-right: 1em;
  padding: 10px 0;
  position: relative;
  opacity: 0.3;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--user-area-container header a::after {
  width: 100%;
  height: 1px;
  background: transparent;
  content: '';
  position: absolute;
  left: 0;
  bottom: 0;
}

.foxplay--user-area-container header a:hover {
  opacity: 1;
}

.foxplay--user-area-container header a.active {
  opacity: 1;
}

.foxplay--user-area-container header a.active::after {
  background: #ed2c24;
}

.foxplay--user-area-container .foxplay--user-area-content {
  margin: 3em 0;
}

.foxplay--user-area-container .foxplay--user-area-content .divider {
  width: 100%;
  height: 1px;
  background: rgba(255, 255, 255, 0.1);
  margin: 2em 0;
}

.foxplay--user-area-container .foxplay--user-area-content table tr td {
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 300;
  padding-bottom: 1em;
  vertical-align: top;
}

.foxplay--user-area-container .foxplay--user-area-content table tr td a {
  color: #ed2c24;
  font-size: 0.9em;
  text-decoration: none;
  margin: -0.6em 0 0 2em;
  display: inline-block;
  vertical-align: middle;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
}

.foxplay--user-area-container .foxplay--user-area-content table tr td a:hover {
  text-shadow: 1px 0px 10px #ed2c24;
}

.foxplay--user-area-container .foxplay--user-area-content table tr td:first-child {
  opacity: 0.4;
}

.foxplay--user-area-container .foxplay--user-area-content table tr td:nth-child(2) {
  padding: 0 0.5em;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-action-button {
  width: auto !important;
  min-width: 150px !important;
  padding: 1em !important;
  font-weight: 900 !important;
  -webkit-box-shadow: 0px 0px 0px 1px #ed2c24 !important;
          box-shadow: 0px 0px 0px 1px #ed2c24 !important;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-action {
  max-width: 768px;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row {
  width: 100%;
  display: inline-block;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row span {
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 600;
  display: block;
  margin-bottom: 0.4em;
  float: left;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row p {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 300;
  display: block;
  float: left;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .foxplay--user-area-content-row-action-button {
  float: right;
  margin: -1em 0 0 1.4em !important;
  font-size: 0.8em !important;
  -webkit-box-shadow: 0px 0px 0px 1px #ed2c24 !important;
          box-shadow: 0px 0px 0px 1px #ed2c24 !important;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .foxplay--user-area-content-row-action-link {
  color: #ed2c24;
  font-size: 0.8em;
  text-decoration: none;
  margin: 0.4em 0 0 2em;
  float: right;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
}

.foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .foxplay--user-area-content-row-action-link:hover {
  text-shadow: 1px 0px 10px #ed2c24;
}

.foxplay--tab {
  width: 100%;
  display: inline-block;
}

.foxplay--tab header {
  width: 100%;
  display: inline-block;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  margin-bottom: 2em;
}

.foxplay--tab header a {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 400;
  text-decoration: none;
  display: inline-block;
  vertical-align: bottom;
  margin-right: 1em;
  padding: 10px 0;
  position: relative;
  opacity: 0.3;
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.foxplay--tab header a::after {
  width: 100%;
  height: 1px;
  background: transparent;
  content: '';
  position: absolute;
  left: 0;
  bottom: 0;
}

.foxplay--tab header a:hover {
  opacity: 1;
}

.foxplay--tab header a.active {
  opacity: 1;
}

.foxplay--tab header a.active::after {
  background: #ed2c24;
}

.foxplay--tab .foxplay--tab-container .foxplay--tab-content-information {
  position: relative;
  margin-bottom: 2em;
}

.foxplay--tab .foxplay--tab-container .foxplay--tab-content-information span {
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 600;
  display: block;
  margin-bottom: 0.3em;
}

.foxplay--tab .foxplay--tab-container .foxplay--tab-content-information p {
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 300;
  display: block;
}

.foxplay--tab .foxplay--tab-container .foxplay--tab-content-information img {
  position: absolute;
  right: 0;
  top: 0;
}

.foxplay--tab .foxplay--tab-container h5 {
  font-size: 1.6em;
  font-weight: 300;
  display: block;
  margin-bottom: 0.8em;
}

.foxplay--tab .foxplay--tab-container span.notice {
  margin-top: 1em;
  color: #ed2c24;
  font-size: 1em;
  font-weight: 600;
  display: block;
}

.foxplay--tab .foxplay--tab-container .foxplay--tab-content {
  display: none;
}

.foxplay--tab .foxplay--tab-container .foxplay--user-area-action-button {
  width: auto;
  background: transparent;
  padding: 0.85em 1em;
  text-align: center;
  display: inline-block;
  outline: none;
  border: 1px solid #ed2c24;
  cursor: pointer;
  margin-top: 1.4em;
  color: #FFFFFF;
  font-size: 1em;
  font-weight: 900;
  font-family: 'Saira', sans-serif;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
  -webkit-transition: all 0.2s ease-in-out;
  transition: all 0.2s ease-in-out;
}

.foxplay--tab .foxplay--tab-container .foxplay--user-area-action-button:hover {
  opacity: 0.8;
}

/* -------------------------- LOGIN BOX -------------------------- */

.foxplay--alert-message {
  width: 100%;
  padding: 1em 0;
  position: fixed;
  left: 0;
  top: auto;
  margin-top: -3px;
  z-index: 9;
  color: #FFFFFF;
  font-size: 0.8em;
  text-align: center;
}

.foxplay--alert-message.error {
  background: #ed2c24;
}

.foxplay--alert-message.success {
  background: #199e1d;
}

.foxplay--payment-countdown {
  display: none;
}

.foxplay--payment-countdown.visible {
  display: block;
}

.foxplay--payment-countdown .foxplay--payment-countdown-inner {
  position: relative;
  background: #000000;
  display: inline-block;
  text-align: center;
  margin-bottom: 2rem;
  padding: 5px;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--payment-countdown .foxplay--payment-countdown-inner .circlebar {
  background: #131313;
  border-top-left-radius: 10em;
  border-top-right-radius: 10em;
  border-bottom-left-radius: 10em;
  border-bottom-right-radius: 10em;
}

.foxplay--payment-countdown .foxplay--payment-countdown-inner .circlebar .loader-bg {
  border-color: #641917;
}

.foxplay--payment-countdown .foxplay--payment-countdown-inner .circlebar .loader-bg .text {
  color: #ed2c24 !important;
  font-size: 1.4em !important;
  font-weight: 600 !important;
}

.foxplay--payment-countdown .foxplay--payment-countdown-inner .circlebar .loader-spinner {
  border-color: #ed2c24;
}

.foxplay--payment-countdown .foxplay--payment-countdown-inner .circlebar .spinner-holder-two {
  -webkit-transition: all 0.4s ease-in-out;
  transition: all 0.4s ease-in-out;
}

.fancybox-content {
  width: 760px;
  background: #131313;
}

.fancybox-content .fancybox-button.fancybox-close-small {
  display: none;
}

.fancybox-content .fancybox-iframe {
  background: #161616;
}

.fancybox-slide--iframe .fancybox-content.lightbox {
  width: 100%;
  max-width: 886px;
  max-height: 500px;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
  margin: auto;
  background: transparent;
}

.fancybox-slide--iframe .fancybox-content.lightbox body {
  margin: 0;
}

.fancybox-slide--iframe .fancybox-content.payment {
  max-width: 700px;
  max-height: 420px;
}

.foxplay--ui-text-scheme h2 {
  color: #FFFFFF;
  font-size: 1.6em;
  font-weight: 700;
  display: block;
  margin-bottom: 1em;
  line-height: 1.6;
}

.foxplay--ui-text-scheme h4 {
  color: #FFFFFF;
  font-size: 1.2em;
  font-weight: 700;
  display: block;
  margin: 2.4em 0 1em 0;
  line-height: 1.2;
}

.foxplay--ui-text-scheme p {
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 300;
  display: block;
  margin-bottom: 1em;
  line-height: 1.4;
}

.foxplay--ui-text-scheme a {
  color: #ed2c24;
}

.foxplay--ui-text-scheme ul {
  padding: 0 0 0 2em;
  margin: 2em 0;
}

.foxplay--ui-text-scheme ul li {
  width: 100%;
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 300;
  margin-bottom: 1em;
  line-height: 1.4;
}

.foxplay--ui-text-scheme ul.circle li {
  list-style-type: disc;
  list-style-position: inside;
}

.foxplay--ui-text-scheme table {
  width: 100%;
  max-width: 600px;
  margin: 2.4em 0;
  overflow-x: auto;
  border-collapse: collapse;
  border-spacing: 0;
  table-layout: fixed;
}

.foxplay--ui-text-scheme table tr {
  width: 100%;
}

.foxplay--ui-text-scheme table tr th {
  background: rgba(0, 0, 0, 0.5);
  padding: 1em;
  border-right: 1px solid #161616;
  color: #FFFFFF;
  font-size: 0.9em;
  font-weight: 600;
  text-align: left;
}

.foxplay--ui-text-scheme table tr td {
  padding: 0.8em 1em;
  border: 1px solid rgba(51, 51, 51, 0.3);
  margin: -1px -1px -1px 0;
  color: #FFFFFF;
  font-size: 0.8em;
  font-weight: 300;
  text-align: left;
  line-height: 1.4;
}

/* -------------------------- FOX TIME ROW START -------------------------- */

.fox-time-bar {
  width: 100%;
  height: 3px;
  background: rgba(255, 255, 255, 0.5);
  position: absolute;
  left: 0;
  bottom: 0;
  z-index: 3;
  -webkit-backface-visibility: hidden;
          backface-visibility: hidden;
}

.fox-time-bar .fox-time-bar-line {
  width: 0;
  height: 3px;
  background: #ed2c24;
  position: relative;
  -webkit-transition: all 0.7s ease-out;
  transition: all 0.7s ease-out;
}

/* -------------------------- FOX TIME ROW END -------------------------- */

/* -------------------------- IE FIX -------------------------- */

body.foxplay--body-ie *::-ms-clear {
  display: none;
}

body.foxplay--body-ie header.foxplay--header .foxplay--brand img {
  max-height: 30px;
}

body.foxplay--body-ie header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close {
  margin-top: 1.2em;
}

body.foxplay--body-ie .vjs-foxplay-skin.video-js .vjs-button.vjs-control::before,
body.foxplay--body-ie .video-js.vjs-foxplay-skin .vjs-control.vjs-button::before {
  font-size: 20px !important;
}

/* -------------------------- IE FIX -------------------------- */

.fancybox-container.fit-to-screen {
  width: 100% !important;
  height: 100% !important;
  padding: 0 !important;
  left: 0 !important;
  top: 0 !important;
  position: fixed !important;
}

.fancybox-container.fit-to-screen .fancybox-slide,
.fancybox-container.fit-to-screen .fancybox-content,
.fancybox-container.fit-to-screen .fancybox-inner {
  width: 100% !important;
  height: 100% !important;
  padding: 0 !important;
}

/* -------------------------- @MEDIA QUERIES -------------------------- */

@media screen and (max-width: 1560px) {
  .foxplay--data-container .foxplay--tweetarea .icon {
    font-size: 3em;
  }

  .foxplay--data-container .foxplay--tweetarea a {
    font-size: 1rem;
  }

  .foxplay--data-container .foxplay--tweetarea a strong {
    font-size: 1.2rem;
  }
}

@media screen and (max-width: 1366px) {
  .foxplay--grid-view .foxplay--grid-view-item {
    width: 32.22% !important;
    margin-right: 1.6% !important;
  }

  .foxplay--grid-view .foxplay--grid-view-item:nth-child(3n) {
    margin-right: 0 !important;
  }

  .foxplay--grid-view-item-content-fly {
    padding: 0.7em !important;
  }

  .foxplay--grid-view-item-content-fly span {
    font-size: 1em !important;
  }

  .foxplay--grid-view-item-content-fly p {
    font-size: 0.8em !important;
    line-height: 1.4em !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item {
    width: 18.72% !important;
    min-height: auto;
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(6n) {
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(5n) {
    margin-right: 0 !important;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li {
    width: 12%;
    margin-bottom: 1em;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li img {
    height: 20px;
  }

  .foxplay--main-slider-thumb {
    max-width: 75%;
    margin-top: -1em !important;
  }

  .foxplay--user-action label.auto {
    width: 48%;
    max-width: 100%;
    margin-right: 0;
    float: left;
  }

  .foxplay--user-action label.auto:nth-child(2n) {
    margin-left: 4%;
  }
}

@media screen and (max-width: 1160px) {
  body {
    font-size: 16px !important;
  }

  .owl-left {
    left: 1em;
  }

  .owl-right {
    right: 1em;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close {
    margin-top: 0.75em;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close i {
    font-size: 1em;
  }

  .foxplay--main-slider-thumb {
    max-width: 85%;
  }

  .foxplay--user-action section label.label-mid {
    width: 100%;
    margin-right: 0;
  }

  header.foxplay--header .foxplay--header-action {
    margin-top: 1.75em;
  }
}

@media screen and (max-width: 1060px) {
  body {
    font-size: 14px !important;
  }

  .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap span {
    font-size: 0.9em;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close {
    padding: 1em 1em 0.8em 1em;
  }

  .foxplay--column-ad {
    display: none;
  }
}

@media screen and (max-width: 1015px) {
  #playerSkin {
    display: none;
  }

  .foxplay--data-container .foxplay--video-container {
    height: auto !important;
    max-height: auto;
    min-height: auto;
  }

  .foxplay--data-container .foxplay--video-container .foxplay--video-container-inner .foxplay--main-player {
    padding-top: 0;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item {
    width: 23.72% !important;
    min-height: auto;
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(5n) {
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(4n) {
    margin-right: 0 !important;
  }

  header.foxplay--header .foxplay--header-action {
    margin-top: 1.7em;
  }

  header.foxplay--header .foxplay--header-action .foxplay--header-action-user,
  header.foxplay--header .foxplay--header-action .foxplay--header-action-user a span {
    margin-left: 0;
  }

  .foxplay--data-container .foxplay--tweetarea .icon {
    margin-right: 0px;
    margin-bottom: 20px;
  }

  .foxplay--data-container .foxplay--tweetarea a {
    display: block;
    max-width: 90%;
  }
}

@media screen and (max-width: 925px) {
  body {
    font-size: 12px !important;
  }

  .foxplay--grid-view-item-content-fly {
    display: none;
  }

  main.foxplay--video-play.player-skin .container:first-child {
    width: 90%;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close {
    margin-top: 0.9em;
  }

  .fancybox-button {
    width: 38px;
    height: 38px;
  }

  .foxplay--login-container .foxplay--login-container-col {
    width: 100%;
  }

  .foxplay--login-container .foxplay--login-container-col:first-child {
    padding-bottom: 0;
  }

  .foxplay--user-action {
    /*padding: 4em 2em;*/
  }

  .foxplay--user-action header h6 {
    font-size: 2em;
  }

  .foxplay--user-action header p {
    font-size: 1.4em;
  }

  .foxplay--user-action header span {
    font-size: 2em;
  }

  .foxplay--user-action section {
    margin: 2.5em 0;
  }

  .foxplay--user-action section label {
    margin-bottom: 1.5em;
  }

  .foxplay--user-action section label input[type="text"],
  .foxplay--user-action section label input[type="email"],
  .foxplay--user-action section label input[type="password"] {
    padding: 0.5em 1em;
    font-size: 1.4em;
  }

  .foxplay--user-action section label input[type="submit"] {
    font-size: 1.4em;
  }

  .foxplay--user-action section label .icheckbox {
    width: 20px;
    height: 20px;
  }

  .foxplay--user-action section label .icheckbox.checked .iCheck-helper::before {
    font-size: 0.8em;
    margin: 4px 0 0 3px;
  }

  .foxplay--user-action section label .icheckbox-text {
    font-size: 1.2em;
  }

  .foxplay--user-action footer i a {
    font-size: 1.2em;
  }

  .foxplay--user-action footer span.seperator {
    font-size: 1.4em;
  }

  .foxplay--user-action footer .foxplay--user-action-button {
    width: 14.5em;
    font-size: 1.2em;
  }

  .foxplay--login-container span {
    font-size: 1.2em;
  }

  .foxplay--login-container .foxplay--dropdown.dark-theme button {
    font-size: 1.2em;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li {
    width: 14%;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li img {
    height: 20px;
  }

  .foxplay--user-action section label.label-error::after {
    font-size: 1.6em;
  }

  .hidden-925 {
    display: none;
  }

  header.foxplay--header .foxplay--header-action .search {
    margin-top: -0.4em;
  }

  .form-notify {
    font-size: 1.1em !important;
  }
}

@media screen and (min-width: 860px) and (max-width: 1366px) {
  .foxplay--main-slider {
    height: 410px;
  }
}

@media screen and (max-width: 860px) {
  main.foxplay--video-play {
    margin: 5.3em 0 3em 0;
  }

  header.foxplay--header {
    background: #161616;
  }

  header.foxplay--header .col-12 {
    text-align: center;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-header input {
    padding: 1.9em 0;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close {
    margin-top: 1.2em;
  }

  header.foxplay--header .foxplay-hamburger {
    display: block;
    background: transparent;
    border: 0;
    outline: 0;
    cursor: pointer;
    float: left;
    margin-top: 1.8em;
    padding: 0;
  }

  header.foxplay--header .foxplay-hamburger i {
    color: #FFFFFF;
    font-size: 2em;
  }

  header.foxplay--header .foxplay-hamburger.active {
    margin-top: 2.2em;
  }

  header.foxplay--header .foxplay-hamburger.active i {
    font-size: 1.5em;
  }

  header.foxplay--header .foxplay-hamburger.active i:before {
    content: 'H';
  }

  header.foxplay--header .foxplay--brand {
    display: inline-block;
    float: none;
    position: relative;
    margin: 1.6em 0;
    -webkit-transition: all 0.4s cubic-bezier(0.17, 0.04, 0.03, 0.94);
    transition: all 0.4s cubic-bezier(0.17, 0.04, 0.03, 0.94);
  }

  header.foxplay--header .foxplay--brand img {
    max-width: 8em;
    margin-right: 0;
  }

  header.foxplay--header .foxplay--brand .icon-logo-fox {
    font-size: 4em;
  }

  header.foxplay--header .foxplay--brand .icon-logo-play {
    margin-right: 0;
    padding: 0;
    font-size: 4em;
  }

  header.foxplay--header .foxplay--brand .icon-logo-play::after {
    display: none;
  }

  header.foxplay--header.active .foxplay--header-action {
    opacity: 0;
    visibility: hidden;
  }

  header.foxplay--header header.foxplay--header .foxplay--header-action .foxplay--button {
    margin-top: -0.4em;
  }

  header.foxplay--header .foxplay--nav {
    display: none;
  }

  header.foxplay--header .foxplay--header-action {
    margin-top: 1.6em;
  }

  header.foxplay--header .foxplay--header-action .outgoing-url {
    display: none;
  }

  header.foxplay--header .foxplay--header-action .search {
    margin-top: 0.2em;
  }

  header.foxplay--header .foxplay--header-action .search .icon {
    font-size: 1.6em;
  }

  header.foxplay--header .foxplay--header-action .foxplay--button {
    width: 1.2em;
    height: 1.3em;
    line-height: 1.3em;
    min-width: auto;
    overflow: hidden;
    text-indent: -9999px;
    border-top-left-radius: 10em;
    border-top-right-radius: 10em;
    border-bottom-left-radius: 10em;
    border-bottom-right-radius: 10em;
  }

  header.foxplay--header .foxplay--header-action .foxplay--button::after {
    content: 'T';
    font-family: 'FOXPLAY';
    color: #FFFFFF;
    font-size: 1.2em;
    text-indent: 0;
    float: left;
  }

  .foxplay--data-container .foxplay--breadcrumbs span {
    font-size: 1.4em;
  }

  .foxplay--data-container .foxplay--breadcrumbs i {
    font-size: 1em;
  }

  .load-more.foxplay--ui-button.transparent {
    font-size: 1em;
  }

  .foxplay--data-container aside h6 {
    font-size: 1em;
  }

  .foxplay--data-container aside nav a {
    font-size: 0.9em;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar span {
    font-size: 0.9em;
  }

  .foxplay--main-slider {
    margin-top: 5.2em;
    height: 375px;
  }

  .foxplay--main-slider .container {
    position: absolute;
    top: auto;
    bottom: 0;
  }

  .foxplay--main-slider .foxplay--main-slider-text {
    max-width: 90%;
    top: auto;
    bottom: 2rem;
    padding: 0;
    margin: 0 auto;
    position: relative;
  }

  .foxplay--main-slider .foxplay--main-slider-text h3 {
    font-size: 2.2em;
  }

  .foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information span {
    font-size: 1em;
  }

  .foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information .foxplay--badge-new {
    font-size: 0.68em;
  }

  .foxplay--main-slider .foxplay--main-slider-text p,
  .foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-time,
  .foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-text-action {
    display: none;
  }

  .foxplay--main-slider .owl-thumbs {
    display: none;
  }

  .foxplay--main-slider .owl-dots,
  .foxplay--main-slider .owl-dots.disabled {
    margin: 1% 2%;
    display: block;
  }

  .foxplay--main-slider-thumb {
    display: none;
  }

  footer.foxplay--footer {
    padding: 0;
    font-size: 13px;
  }

  footer.foxplay--footer .col {
    width: 96.12%;
  }

  footer.foxplay--footer .foxplay--brand {
    float: left;
  }

  footer.foxplay--footer .fox--brand {
    margin-top: -0.75rem;
    margin-left: 2em;
  }

  footer.foxplay--footer .clearfix {
    display: none;
  }

  footer.foxplay--footer nav {
    display: none;
  }

  footer.foxplay--footer .col-3 {
    padding: 2.4em 0;
    margin-bottom: 2.4em;
  }

  footer.foxplay--footer .col-3:first-child {
    border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  }

  footer.foxplay--footer .col-2 {
    width: 46% !important;
  }

  footer.foxplay--footer .col-2:nth-child(3) {
    display: none;
  }

  footer.foxplay--footer .col-2.col-foxplay--app-links {
    float: right;
    margin-bottom: 1em;
  }

  footer.foxplay--footer .col-2.col-foxplay--app-links h4 {
    display: none;
  }

  footer.foxplay--footer .col-2.col-foxplay--app-links a i {
    margin-bottom: 1em;
    margin-right: 1em;
  }

  footer.foxplay--footer .col-foxplay--social-buttons {
    text-align: center;
    border-top: 1px solid rgba(255, 255, 255, 0.1);
    margin-bottom: 0;
    position: relative;
  }

  footer.foxplay--footer .col-foxplay--social-buttons a {
    font-size: 1.4em;
  }

  footer.foxplay--footer .col-foxplay--social-buttons a:last-child {
    margin: 0;
  }

  footer.foxplay--footer .col-foxplay--social-buttons h4 {
    display: none;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar {
    margin: 0;
    padding: 2.4em 0;
    text-align: center;
  }

  .foxplay--owl-type-one .owl-stage-outer {
    margin: -0.5em -2em -0.5em 0;
  }

  .foxplay--owl-type-one .owl-stage-outer .owl-stage {
    padding-right: 2em;
    padding-left: 0;
  }

  .foxplay--owl-type-two .owl-stage-outer {
    margin: -0.5em -2em -0.5em 0;
  }

  .foxplay--owl-type-two .owl-stage-outer .owl-stage {
    padding-right: 2em;
    padding-left: 0;
  }

  .foxplay--owl-type-one .owl-stage-outer .owl-stage .owl-item:hover {
    -webkit-transform: scale(1) !important;
            transform: scale(1) !important;
    border-color: 0;
  }

  .foxplay--owl-type-two .owl-stage-outer .owl-stage .owl-item:hover {
    -webkit-transform: scale(1) !important;
            transform: scale(1) !important;
    border-color: 0;
  }

  .owl-carousel .owl-dots .owl-dot {
    width: 4px;
    height: 4px;
  }

  .foxplay--header-sub-nav {
    display: none;
  }

  .static-ad-banner {
    display: none;
  }

  .foxplay--data-container .foxplay--video-container .foxplay--video-container-inner {
    min-height: auto;
  }

  .foxplay--data-container .col-4 .right {
    text-align: left !important;
  }

  .foxplay--mobile-navigation .outgoing-url {
    font-size: 1.6em;
    margin-top: 2em;
    color: #FFFFFF;
  }

  .foxplay--mobile-navigation .outgoing-url strong {
    color: #ed2c24;
  }

  header.foxplay--header .foxplay--header-action .foxplay--header-action-user {
    margin: -0.4em 0 0 0.5em;
  }

  header.foxplay--header .foxplay--header-action .foxplay--header-action-user a i {
    display: none;
  }

  header.foxplay--header .foxplay--header-action .foxplay--header-action-user a span {
    width: 2.6em;
    height: 2.6em;
    line-height: 2.6em;
  }

  .foxplay--user-action label .iradio.checked .iCheck-helper::before {
    width: 0.5em;
    height: 0.5em;
    margin: 0.35em 0 0 0.35em;
  }

  header.foxplay--header .foxplay--header-action .foxplay--button {
    margin-top: -0.4em;
  }

  .auth header.foxplay--header .foxplay--brand {
    width: 85px;
    margin-right: 0px !important;
  }

  .foxplay--alert-message {
    margin-top: 2px;
  }
}

@media screen and (max-width: 768px) {
  main {
    margin: 6.3em 0 3em 0;
  }

  .foxplay--page-404 .foxplay--button {
    font-size: 1.3em;
    margin-bottom: 5em;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li img {
    height: auto;
  }
}

@media screen and (max-width: 767px) {
  .foxplay--grid-view .foxplay--grid-view-item {
    width: 49.12% !important;
    margin-bottom: 4%;
    min-height: auto;
    margin-right: 1.6% !important;
    /*&:hover {

                .red-play::after {
                    width: 2.6em;
                    height: 2.6em;
                    margin: -1.3em 0 0 -1.3em;
                }
            }*/
  }

  .foxplay--grid-view .foxplay--grid-view-item:nth-child(2n) {
    margin-right: 0 !important;
  }

  .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap {
    left: 1.5em;
    bottom: 1.5em;
  }

  .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap span {
    font-size: 1.3em;
  }

  .foxplay--grid-view.column-view-4 .foxplay--grid-view-item {
    width: 49.12% !important;
    margin-bottom: 4%;
    min-height: auto;
    margin-right: 1.6% !important;
  }

  .foxplay--grid-view.column-view-4 .foxplay--grid-view-item:nth-child(2n) {
    margin-right: 0 !important;
  }

  .foxplay--grid-view.column-view-4 .foxplay--grid-view-item i {
    font-size: 1em;
  }

  .foxplay--data-container aside {
    display: none;
  }

  .foxplay--data-container aside h6 {
    content: '';
    font-size: 1.6em;
    margin-bottom: 0;
    position: relative;
    cursor: pointer;
    display: none;
  }

  .foxplay--data-container aside h6:first-child {
    display: block;
  }

  .foxplay--data-container aside h6:first-child::after {
    content: 'I';
    position: absolute;
    right: 0;
    color: #ed2c24;
    font-size: 0.7em;
    font-family: 'FOXPLAY';
    margin-top: 0.4em;
  }

  .foxplay--data-container aside .divider {
    display: none;
  }

  .foxplay--data-container aside nav {
    display: none;
  }

  .foxplay--data-container aside nav a {
    font-size: 1.1em;
  }

  .foxplay--data-container aside.active h6 {
    margin-bottom: 2em;
    display: block;
  }

  .foxplay--data-container aside.active nav {
    display: block;
  }

  .foxplay--data-container aside.active .divider {
    display: block;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information h1 {
    font-size: 2.5em;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information p {
    font-size: 1em;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information span {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--category-action-row {
    margin: 2.5em 0;
  }

  .foxplay--data-container .foxplay--category-action-row .foxplay--breadcrumbs span {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--category-action-row .foxplay--breadcrumbs i {
    font-size: 1em;
    margin-top: 0;
  }

  .foxplay--data-container .foxplay--ui-button.transparent {
    font-size: 1.1em;
  }

  .foxplay--data-container .foxplay--program-action {
    text-align: left;
    margin: 2em 0;
  }

  .foxplay--data-container .foxplay--program-action sup {
    margin-left: 0;
    margin-right: 1em;
    font-size: 1em;
  }

  .foxplay--data-container .foxplay--program h1 {
    font-size: 3.2em;
  }

  .foxplay--data-container .foxplay--program h6 {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--program p {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--program span {
    font-size: 1.2em;
    line-height: 1.4em;
  }

  .foxplay--data-container .foxplay--program sup {
    font-size: 1em;
  }

  .foxplay--data-container .foxplay--program .foxplay--program-information span {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--program .foxplay--program-information i {
    font-size: 0.82em;
  }

  .foxplay--data-container .foxplay--program-extras header a {
    font-size: 1.4em;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--grid-view .foxplay--grid-view-item {
    width: 49.2%;
    margin-right: 1.6% !important;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--grid-view .foxplay--grid-view-item:nth-child(2n) {
    margin-right: 0 !important;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--grid-view .foxplay--grid-view-item i {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content .foxplay--grid-view-item-content-fly span {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content .foxplay--grid-view-item-content-fly p {
    font-size: 1em;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content .foxplay--dropdown {
    display: block;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--program-extras-content nav {
    display: none;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar span {
    font-size: 0.8em;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item {
    width: 32.22% !important;
    min-height: auto;
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(4n) {
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(3n) {
    margin-right: 0 !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-information span,
  .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap span {
    font-size: 1em;
  }

  .foxplay--search-content-result-information .col-6 {
    width: 46%;
  }

  .foxplay--search-content-result .mCustomScrollBox {
    height: 75vh !important;
  }

  .foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row p {
    float: none;
    display: block;
    margin-bottom: 3em;
  }

  .foxplay--user-area-container .foxplay--user-area-content .foxplay--user-area-content-row .foxplay--user-area-content-row-action-link {
    float: none;
    display: block;
    margin: 0 0 1em 0;
  }

  .foxplay--data-container .foxplay--breadcrumbs h1 {
    font-size: 1.6em;
  }

  .foxplay--dropdown button {
    font-size: 0.85em;
    padding: 1.2em 3em 1.2em 1.7em;
  }

  .foxplay--grid-view .foxplay--grid-view-item:hover .foxplay--grid-view-item-content .red-play i::before {
    line-height: 2.4rem;
  }

  .foxplay--data-container .foxplay--category-action-row {
    margin: 0.5em 0;
  }

  .foxplay--data-container .foxplay--tweetarea .icon {
    font-size: 5em;
    margin-bottom: 0;
    margin-right: 10px;
  }

  .foxplay--data-container .foxplay--tweetarea a {
    display: inline-block;
    padding: 2% 13%;
  }
}

@media screen and (max-width: 640px) {
  .video-js.vjs-foxplay-skin .vjs-big-play-button .vjs-control-text {
    width: 5.1rem;
    height: 5.1rem;
  }

  .foxplay--data-container .foxplay--category-promo {
    background-size: cover;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information {
    width: 70%;
    padding: 2em;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information h1 {
    font-size: 1.8em !important;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information p {
    font-size: 0.8em;
    display: none;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information p:first-of-type {
    display: block !important;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information span {
    display: none;
  }

  .static-ad-banner.desktop {
    display: none;
  }

  .static-ad-banner.mobile {
    display: block;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-header .foxplay--search-content-close {
    padding: 0.8em 0.8em 0.6em 0.8em;
    margin-top: 1.5em;
  }

  .mCustomScrollBox {
    height: 85vh;
  }

  .foxplay--search-content {
    height: 100%;
  }

  .foxplay--main-slider .foxplay--main-slider-text > * {
    opacity: 1;
    left: 0;
  }

  .foxplay--user-area-container header {
    padding-bottom: 2em;
  }

  .foxplay--user-area-container header a {
    display: block;
    float: none !important;
    padding: 7px 0;
  }

  .foxplay--user-area-container header a::after {
    display: none;
  }
}

@media screen and (max-width: 600px) {
  footer.foxplay--footer {
    padding-bottom: 150px;
  }
}

@media screen and (max-width: 545px) {
  header.foxplay--header .foxplay--mobile-navigation {
    padding: 7em 4em;
  }

  .foxplay--main-slider .foxplay--main-slider-text {
    max-width: 95%;
    padding: 0;
    bottom: 2.6em;
  }

  .foxplay--main-slider .owl-dots,
  .foxplay--main-slider .owl-dots.disabled {
    margin-bottom: 0.5em;
  }

  .container {
    width: 95%;
  }

  .foxplay--owl-type-one .owl-stage-outer {
    margin: -0.5em 0em -0.5em 0;
  }

  .foxplay--owl-type-one .owl-stage-outer .owl-stage {
    padding-right: 0em;
  }

  .foxplay--owl-type-one .owl-dots {
    top: -1.65em;
  }

  .foxplay--owl-type-two .owl-stage-outer {
    margin: -0.5em 0em -0.5em 0;
  }

  .foxplay--owl-type-two .owl-stage-outer .owl-stage {
    padding-right: 0em;
  }

  .foxplay--owl-type-two .owl-dots {
    top: -1.65em;
  }

  .owl-prev {
    width: 2.4em;
    height: 2.4em;
    left: 1em;
  }

  .owl-prev::after {
    font-size: 0.8em;
  }

  .owl-next {
    width: 2.4em;
    height: 2.4em;
    right: 1em;
  }

  .owl-next::after {
    font-size: 0.8em;
  }

  .foxplay--grid-view.column-view-4 .foxplay--grid-view-item {
    width: 49.2%;
  }

  .foxplay--grid-view.column-view-4 .foxplay--grid-view-item:nth-child(5n) {
    margin-right: 1.6% !important;
  }

  .foxplay--grid-view.column-view-4 .foxplay--grid-view-item:nth-child(4n) {
    margin-right: 0;
  }

  .foxplay--grid-view.column-view-4 .foxplay--grid-view-item:nth-child(2n) {
    margin-right: 0 !important;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-information {
    width: 70%;
  }

  .foxplay--data-container .foxplay--category-promo .foxplay--category-promo-overlay {
    width: 101%;
    background-image: -webkit-gradient(linear, left bottom, left top, color-stop(15%, #000), to(rgba(24, 25, 26, 0)));
    background-image: linear-gradient(0deg, #000 15%, rgba(24, 25, 26, 0));
  }

  .foxplay--data-container .foxplay--program-extras header a {
    font-size: 0.95em;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--grid-view-item {
    width: 100% !important;
    margin-bottom: 7%;
  }

  .foxplay--data-container .foxplay--program-extras .foxplay--grid-view-item:hover .foxplay--grid-view-item-content .foxplay--grid-view-item-content-fly {
    display: none;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-information span {
    font-size: 0.9em;
  }

  .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap {
    left: 1em;
    bottom: 1em;
  }

  .foxplay--grid-view .foxplay--grid-view-item .foxplay--grid-view-item-content footer .foxplay--footer-wrap span {
    font-size: 1em;
  }

  .foxplay--data-container .foxplay--program h1 {
    font-size: 2.6em;
  }

  .foxplay--data-container .foxplay--program span {
    font-size: 1em;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item {
    width: 49.12% !important;
    min-height: auto;
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(3n) {
    margin-right: 1.6% !important;
  }

  header.foxplay--header .foxplay--search-content .foxplay--search-content-result .foxplay--search-content-result-list .foxplay--grid-view .foxplay--grid-view-item:nth-child(2n) {
    margin-right: 0 !important;
  }

  .foxplay--data-container .foxplay--category-action-row .foxplay--breadcrumbs i {
    float: right;
    margin-bottom: 1em;
  }

  .foxplay--dropdown {
    width: 100%;
    max-width: 160px;
  }

  .foxplay--dropdown button {
    width: 100%;
    font-size: 1em;
    padding: 1em 3em 1em 1.7em;
  }

  .foxplay--data-container .foxplay--breadcrumbs .foxplay--dropdown {
    margin-left: 0;
  }

  header.foxplay--header .foxplay-hamburger {
    margin-top: 1.8em;
  }

  header.foxplay--header .foxplay--header-action {
    margin-top: 1.6em;
  }

  .foxplay--page-404 h1 {
    font-size: 2.6em;
    margin-bottom: 0.8em;
    line-height: 1.3em;
  }

  .foxplay--page-404 .foxplay--button {
    font-size: 1em;
    margin-bottom: 5em;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li {
    width: 22%;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar .foxplay--footer-channel-logos li img {
    height: 15px;
    display: inline-block;
  }

  .foxplay--login-container .foxplay--login-container-col {
    padding: 4em 2em;
  }

  .foxplay--login-container .foxplay--login-container-col h4 {
    font-size: 1.7em;
  }

  .foxplay--login-container .foxplay--user-action {
    padding: 4em 0;
  }

  .foxplay--tab .foxplay--tab-container .foxplay--tab-content-information img {
    position: static;
    margin-top: 2em;
    margin-bottom: 0em;
  }

  .foxplay--user-action header span,
  .foxplay--user-action header h6 {
    font-size: 1.6em;
  }

  .foxplay--user-action header span sup {
    font-size: 0.8rem;
  }

  .foxplay--user-action label.auto {
    width: 100%;
    margin-left: 0 !important;
    margin-right: 0 !important;
  }

  .foxplay--user-action label input[type="text"].icon-card {
    background-position: 1em center;
    padding-left: 3.5em;
  }

  .foxplay--login-container .foxplay--dropdown.dark-theme button {
    padding-left: 1.1em;
  }

  .foxplay--tab header a {
    font-size: 1.2em;
  }

  .foxplay--user-action label input[type="text"],
  .foxplay--user-action label input[type="password"],
  .foxplay--user-action label input[type="email"] {
    line-height: 2;
  }
}

@media screen and (max-width: 400px) {
  .foxplay--main-slider .foxplay--main-slider-text h3 {
    font-size: 1.6em;
  }

  .foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information {
    margin: 0.4em 0;
  }

  .foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information span {
    font-size: 0.9em;
  }

  .foxplay--main-slider .foxplay--main-slider-text .foxplay--main-slider-information .foxplay--badge-new {
    font-size: 0.6em;
  }

  .foxplay--mobile-navigation .foxplay--social-buttons a {
    font-size: 1.2em;
  }

  .foxplay--mobile-navigation .foxplay--mobile-navigation-corporate-links nav a {
    width: 100%;
  }

  footer.foxplay--footer .foxplay--footer-bottom-bar span {
    font-size: 0.65em;
  }

  .fancybox-button {
    width: 34px;
    height: 34px;
  }

  .foxplay--login-container span {
    font-size: 1em;
  }

  .foxplay--dropdown button {
    min-width: auto;
  }

  .foxplay--ui-text-scheme h2 {
    font-size: 1.6em;
    line-height: 1.6;
  }

  .foxplay--ui-text-scheme h4 {
    font-size: 1.2em;
    line-height: 1.2;
  }

  .foxplay--ui-text-scheme p {
    font-size: 1.1em;
    line-height: 1.5;
  }

  .foxplay--ui-text-scheme ul {
    padding: 0 0 0 1em;
  }

  .foxplay--ui-text-scheme ul li {
    font-size: 1.1em;
    line-height: 1.4;
  }

  .foxplay--ui-text-scheme table {
    max-width: 300px;
  }

  .foxplay--ui-text-scheme table tr th {
    padding: 0.8em;
    font-size: 1.1em;
  }

  .foxplay--ui-text-scheme table tr td {
    padding: 0.6em 0.8em;
    font-size: 1.1em;
    line-height: 1.4;
  }

  .foxplay--breadcrumbs:nth-child(1) {
    width: 35%;
  }

  .foxplay--breadcrumbs:nth-child(2) {
    width: 63%;
  }

  .foxplay--data-container .foxplay--breadcrumbs h1 {
    font-size: 1.2em;
  }

  .foxplay--data-container .foxplay--tweetarea .icon {
    font-size: 3.8em;
  }

  .foxplay--data-container .foxplay--tweetarea a {
    font-size: 14px;
  }

  .foxplay--data-container .foxplay--tweetarea a strong {
    font-size: 18px;
  }
}

/* -------------------------- @MEDIA QUERIES -------------------------- */
