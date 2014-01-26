<<<<<<< HEAD
TechCipher.Plugins.Planetics
============================

Using Google Analytics API and PlanetaryJS to show various pings around the world for a website.

Uses following dependencies

- Google APIs Client Library 1.7.0-beta (https://www.nuget.org/packages/Google.Apis/)
- planetaryjs (http://planetaryjs.com/)


Look at the following articles for more details of implementation
- http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-1
- http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-2


Notes
=====
Install using Nuget Package (https://www.nuget.org/packages/TechCipher.Plugins.Planetics/)

Issues
======

Make sure youe web.config have following entries

	assemblyIdentity name="System.Web.WebPages" publicKeyToken="31bf3856ad364e35"
	bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0"

	assemblyIdentity name="System.Web.WebPages.Razor" publicKeyToken="31bf3856ad364e35"
	bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0"
=======





<!DOCTYPE html>
<html>
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>TechCipher.Plugins.Planetics/README.md at master · saifmd4u/TechCipher.Plugins.Planetics</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub" />
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub" />
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png" />
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png" />
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png" />
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png" />
    <link rel="logo" type="image/svg" href="https://github-media-downloads.s3.amazonaws.com/github-logo.svg" />
    <meta property="fb:app_id" content="1401488693436528"/>
    <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="saifmd4u/TechCipher.Plugins.Planetics" name="twitter:title" /><meta content="TechCipher.Plugins.Planetics - Planet Pings - Google Analytics API and PlanetaryJS" name="twitter:description" /><meta content="https://0.gravatar.com/avatar/cfe7cc00754fd77a96b3886b66a1ecce?d=https%3A%2F%2Fidenticons.github.com%2F0dd3c63dc560214bbd805de7052bb8ac.png&amp;r=x&amp;s=400" name="twitter:image:src" />
<meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://0.gravatar.com/avatar/cfe7cc00754fd77a96b3886b66a1ecce?d=https%3A%2F%2Fidenticons.github.com%2F0dd3c63dc560214bbd805de7052bb8ac.png&amp;r=x&amp;s=400" property="og:image" /><meta content="saifmd4u/TechCipher.Plugins.Planetics" property="og:title" /><meta content="https://github.com/saifmd4u/TechCipher.Plugins.Planetics" property="og:url" /><meta content="TechCipher.Plugins.Planetics - Planet Pings - Google Analytics API and PlanetaryJS" property="og:description" />

    <meta name="hostname" content="github-fe129-cp1-prd.iad.github.net">
    <meta name="ruby" content="ruby 2.1.0p0-github-tcmalloc (60139581e1) [x86_64-linux]">
    <link rel="assets" href="https://github.global.ssl.fastly.net/">
    <link rel="conduit-xhr" href="https://ghconduit.com:25035/">
    <link rel="xhr-socket" href="/_sockets" />
    


    <meta name="msapplication-TileImage" content="/windows-tile.png" />
    <meta name="msapplication-TileColor" content="#ffffff" />
    <meta name="selected-link" value="repo_source" data-pjax-transient />
    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="561CA5F8:60F2:68D1D3A:52E45E2A" name="octolytics-dimension-request_id" /><meta content="2925798" name="octolytics-actor-id" /><meta content="saifmd4u" name="octolytics-actor-login" /><meta content="8ccb873b2e5d74cec1a4ab3d5890c31067d3b468b7937a1e6f832b33226e18c4" name="octolytics-actor-hash" />
    

    
    
    <link rel="icon" type="image/x-icon" href="/favicon.ico" />

    <meta content="authenticity_token" name="csrf-param" />
<meta content="JEInz6e8jyRFKxIxCq8Yx4HVBQ8bgLVL/K6WOTbfZRo=" name="csrf-token" />

    <link href="https://github.global.ssl.fastly.net/assets/github-0b74c0d513f0f7d77565949aaecf3586f0c31d3e.css" media="all" rel="stylesheet" type="text/css" />
    <link href="https://github.global.ssl.fastly.net/assets/github2-af039511df63dfcc7976ec9300f39bf6db2db3e8.css" media="all" rel="stylesheet" type="text/css" />
    


      <script src="https://github.global.ssl.fastly.net/assets/frameworks-2086b76396d7018acf390457357b14121f3e16f3.js" type="text/javascript"></script>
      <script async="async" defer="defer" src="https://github.global.ssl.fastly.net/assets/github-30488bbb23652710dfbb3e19ba5aab359bf614bb.js" type="text/javascript"></script>
      
      <meta http-equiv="x-pjax-version" content="a7348885444e3e63b34413007ffff9d9">

        <link data-pjax-transient rel='permalink' href='/saifmd4u/TechCipher.Plugins.Planetics/blob/5e83e7676ad9dbf2efb89aa274ad13eb7b083778/README.md'>

  <meta name="description" content="TechCipher.Plugins.Planetics - Planet Pings - Google Analytics API and PlanetaryJS" />

  <meta content="2925798" name="octolytics-dimension-user_id" /><meta content="saifmd4u" name="octolytics-dimension-user_login" /><meta content="16055254" name="octolytics-dimension-repository_id" /><meta content="saifmd4u/TechCipher.Plugins.Planetics" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="16055254" name="octolytics-dimension-repository_network_root_id" /><meta content="saifmd4u/TechCipher.Plugins.Planetics" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/saifmd4u/TechCipher.Plugins.Planetics/commits/master.atom" rel="alternate" title="Recent Commits to TechCipher.Plugins.Planetics:master" type="application/atom+xml" />

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <div class="wrapper">
      
      
      
      


      <div class="header header-logged-in true">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/">
  <span class="mega-octicon octicon-mark-github"></span>
</a>

    
    <a href="/notifications" class="notification-indicator tooltipped downwards" data-gotokey="n" title="You have no unread notifications">
        <span class="mail-status all-read"></span>
</a>

      <div class="command-bar js-command-bar  in-repository">
          <form accept-charset="UTF-8" action="/search" class="command-bar-form" id="top_search_form" method="get">

<input type="text" data-hotkey="/ s" name="q" id="js-command-bar-field" placeholder="Search or type a command" tabindex="1" autocapitalize="off"
    
    data-username="saifmd4u"
      data-repo="saifmd4u/TechCipher.Plugins.Planetics"
      data-branch="master"
      data-sha="444dd7998461d80a958bfaf558e0e376c75ed718"
  >

    <input type="hidden" name="nwo" value="saifmd4u/TechCipher.Plugins.Planetics" />

    <div class="select-menu js-menu-container js-select-menu search-context-select-menu">
      <span class="minibutton select-menu-button js-menu-target">
        <span class="js-select-button">This repository</span>
      </span>

      <div class="select-menu-modal-holder js-menu-content js-navigation-container">
        <div class="select-menu-modal">

          <div class="select-menu-item js-navigation-item js-this-repository-navigation-item selected">
            <span class="select-menu-item-icon octicon octicon-check"></span>
            <input type="radio" class="js-search-this-repository" name="search_target" value="repository" checked="checked" />
            <div class="select-menu-item-text js-select-button-text">This repository</div>
          </div> <!-- /.select-menu-item -->

          <div class="select-menu-item js-navigation-item js-all-repositories-navigation-item">
            <span class="select-menu-item-icon octicon octicon-check"></span>
            <input type="radio" name="search_target" value="global" />
            <div class="select-menu-item-text js-select-button-text">All repositories</div>
          </div> <!-- /.select-menu-item -->

        </div>
      </div>
    </div>

  <span class="octicon help tooltipped downwards" title="Show command bar help">
    <span class="octicon octicon-question"></span>
  </span>


  <input type="hidden" name="ref" value="cmdform">

</form>
        <ul class="top-nav">
          <li class="explore"><a href="/explore">Explore</a></li>
            <li><a href="https://gist.github.com">Gist</a></li>
            <li><a href="/blog">Blog</a></li>
          <li><a href="https://help.github.com">Help</a></li>
        </ul>
      </div>

    


  <ul id="user-links">
    <li>
      <a href="/saifmd4u" class="name">
        <img alt="Saif Mohammad" height="20" src="https://1.gravatar.com/avatar/cfe7cc00754fd77a96b3886b66a1ecce?d=https%3A%2F%2Fidenticons.github.com%2F0dd3c63dc560214bbd805de7052bb8ac.png&amp;r=x&amp;s=140" width="20" /> saifmd4u
      </a>
    </li>

      <li class="new-menu dropdown-toggle js-menu-container">
        <a href="#" class="js-menu-target tooltipped downwards" title="Create new…">
          <span class="octicon octicon-plus"></span>
          <span class="dropdown-arrow"></span>
        </a>

        <div class="js-menu-content">
        </div>
      </li>

      <li>
        <a href="/settings/profile" id="account_settings"
          class="tooltipped downwards"
          aria-label="Account settings "
          title="Account settings ">
          <span class="octicon octicon-tools"></span>
        </a>
      </li>
      <li>
        <a class="tooltipped downwards" href="/logout" data-method="post" id="logout" title="Sign out" aria-label="Sign out">
          <span class="octicon octicon-log-out"></span>
        </a>
      </li>

  </ul>

<div class="js-new-dropdown-contents hidden">
  

<ul class="dropdown-menu">
  <li>
    <a href="/new"><span class="octicon octicon-repo-create"></span> New repository</a>
  </li>
  <li>
    <a href="/organizations/new"><span class="octicon octicon-organization"></span> New organization</a>
  </li>



    <li class="section-title">
      <span title="saifmd4u/TechCipher.Plugins.Planetics">This repository</span>
    </li>
      <li>
        <a href="/saifmd4u/TechCipher.Plugins.Planetics/issues/new"><span class="octicon octicon-issue-opened"></span> New issue</a>
      </li>
      <li>
        <a href="/saifmd4u/TechCipher.Plugins.Planetics/settings/collaboration"><span class="octicon octicon-person-add"></span> New collaborator</a>
      </li>
</ul>

</div>


    
  </div>
</div>

      

      




          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        

<ul class="pagehead-actions">

    <li class="subscription">
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="authenticity_token" type="hidden" value="JEInz6e8jyRFKxIxCq8Yx4HVBQ8bgLVL/K6WOTbfZRo=" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="16055254" />

    <div class="select-menu js-menu-container js-select-menu">
      <a class="social-count js-social-count" href="/saifmd4u/TechCipher.Plugins.Planetics/watchers">
        1
      </a>
      <span class="minibutton select-menu-button with-count js-menu-target" role="button" tabindex="0">
        <span class="js-select-button">
          <span class="octicon octicon-eye-unwatch"></span>
          Unwatch
        </span>
      </span>

      <div class="select-menu-modal-holder">
        <div class="select-menu-modal subscription-menu-modal js-menu-content">
          <div class="select-menu-header">
            <span class="select-menu-title">Notification status</span>
            <span class="octicon octicon-remove-close js-menu-close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-list js-navigation-container" role="menu">

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_included" name="do" type="radio" value="included" />
                <h4>Not watching</h4>
                <span class="description">You only receive notifications for conversations in which you participate or are @mentioned.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye-watch"></span>
                  Watch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input checked="checked" id="do_subscribed" name="do" type="radio" value="subscribed" />
                <h4>Watching</h4>
                <span class="description">You receive notifications for all conversations in this repository.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye-unwatch"></span>
                  Unwatch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_ignore" name="do" type="radio" value="ignore" />
                <h4>Ignoring</h4>
                <span class="description">You do not receive any notifications for conversations in this repository.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-mute"></span>
                  Stop ignoring
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

</form>
    </li>

  <li>
  

  <div class="js-toggler-container js-social-container starring-container ">
    <a href="/saifmd4u/TechCipher.Plugins.Planetics/unstar"
      class="minibutton with-count js-toggler-target star-button starred upwards"
      title="Unstar this repository" data-remote="true" data-method="post" rel="nofollow">
      <span class="octicon octicon-star-delete"></span><span class="text">Unstar</span>
    </a>

    <a href="/saifmd4u/TechCipher.Plugins.Planetics/star"
      class="minibutton with-count js-toggler-target star-button unstarred upwards"
      title="Star this repository" data-remote="true" data-method="post" rel="nofollow">
      <span class="octicon octicon-star"></span><span class="text">Star</span>
    </a>

      <a class="social-count js-social-count" href="/saifmd4u/TechCipher.Plugins.Planetics/stargazers">
        0
      </a>
  </div>

  </li>


        <li>
          <a href="/saifmd4u/TechCipher.Plugins.Planetics/fork" class="minibutton with-count js-toggler-target fork-button lighter upwards" title="Fork this repo" rel="nofollow" data-method="post">
            <span class="octicon octicon-git-branch-create"></span><span class="text">Fork</span>
          </a>
          <a href="/saifmd4u/TechCipher.Plugins.Planetics/network" class="social-count">0</a>
        </li>


</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="repo-label"><span>public</span></span>
          <span class="mega-octicon octicon-repo"></span>
          <span class="author">
            <a href="/saifmd4u" class="url fn" itemprop="url" rel="author"><span itemprop="title">saifmd4u</span></a>
          </span>
          <span class="repohead-name-divider">/</span>
          <strong><a href="/saifmd4u/TechCipher.Plugins.Planetics" class="js-current-repository js-repo-home-link">TechCipher.Plugins.Planetics</a></strong>

          <span class="page-context-loader">
            <img alt="Octocat-spinner-32" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      

      <div class="repository-with-sidebar repo-container  ">

        <div class="repository-sidebar">
            

<div class="sunken-menu vertical-right repo-nav js-repo-nav js-repository-container-pjax js-octicon-loaders">
  <div class="sunken-menu-contents">
    <ul class="sunken-menu-group">
      <li class="tooltipped leftwards" title="Code">
        <a href="/saifmd4u/TechCipher.Plugins.Planetics" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-gotokey="c" data-pjax="true" data-selected-links="repo_source repo_downloads repo_commits repo_tags repo_branches /saifmd4u/TechCipher.Plugins.Planetics">
          <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
          <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

        <li class="tooltipped leftwards" title="Issues">
          <a href="/saifmd4u/TechCipher.Plugins.Planetics/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-gotokey="i" data-selected-links="repo_issues /saifmd4u/TechCipher.Plugins.Planetics/issues">
            <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
            <span class='counter'>0</span>
            <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
</a>        </li>

      <li class="tooltipped leftwards" title="Pull Requests">
        <a href="/saifmd4u/TechCipher.Plugins.Planetics/pulls" aria-label="Pull Requests" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-gotokey="p" data-selected-links="repo_pulls /saifmd4u/TechCipher.Plugins.Planetics/pulls">
            <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull Requests</span>
            <span class='counter'>0</span>
            <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>


        <li class="tooltipped leftwards" title="Wiki">
          <a href="/saifmd4u/TechCipher.Plugins.Planetics/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="repo_wiki /saifmd4u/TechCipher.Plugins.Planetics/wiki">
            <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
            <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
</a>        </li>
    </ul>
    <div class="sunken-menu-separator"></div>
    <ul class="sunken-menu-group">

      <li class="tooltipped leftwards" title="Pulse">
        <a href="/saifmd4u/TechCipher.Plugins.Planetics/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="pulse /saifmd4u/TechCipher.Plugins.Planetics/pulse">
          <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
          <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

      <li class="tooltipped leftwards" title="Graphs">
        <a href="/saifmd4u/TechCipher.Plugins.Planetics/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="repo_graphs repo_contributors /saifmd4u/TechCipher.Plugins.Planetics/graphs">
          <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
          <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

      <li class="tooltipped leftwards" title="Network">
        <a href="/saifmd4u/TechCipher.Plugins.Planetics/network" aria-label="Network" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-selected-links="repo_network /saifmd4u/TechCipher.Plugins.Planetics/network">
          <span class="octicon octicon-git-branch"></span> <span class="full-word">Network</span>
          <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>
    </ul>


      <div class="sunken-menu-separator"></div>
      <ul class="sunken-menu-group">
        <li class="tooltipped leftwards" title="Settings">
          <a href="/saifmd4u/TechCipher.Plugins.Planetics/settings"
            class="sunken-menu-item" data-pjax aria-label="Settings">
            <span class="octicon octicon-tools"></span> <span class="full-word">Settings</span>
            <img alt="Octocat-spinner-32" class="mini-loader" height="16" src="https://github.global.ssl.fastly.net/images/spinners/octocat-spinner-32.gif" width="16" />
          </a>
        </li>
      </ul>
  </div>
</div>

              <div class="only-with-full-nav">
                

  

<div class="clone-url "
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=push">
  <h3><strong>HTTPS</strong> clone URL</h3>
  <div class="clone-url-box">
    <input type="text" class="clone js-url-field"
           value="https://github.com/saifmd4u/TechCipher.Plugins.Planetics.git" readonly="readonly">

    <span class="js-zeroclipboard url-box-clippy minibutton zeroclipboard-button" data-clipboard-text="https://github.com/saifmd4u/TechCipher.Plugins.Planetics.git" data-copied-hint="copied!" title="copy to clipboard"><span class="octicon octicon-clippy"></span></span>
  </div>
</div>

  

<div class="clone-url open"
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=push">
  <h3><strong>SSH</strong> clone URL</h3>
  <div class="clone-url-box">
    <input type="text" class="clone js-url-field"
           value="git@github.com:saifmd4u/TechCipher.Plugins.Planetics.git" readonly="readonly">

    <span class="js-zeroclipboard url-box-clippy minibutton zeroclipboard-button" data-clipboard-text="git@github.com:saifmd4u/TechCipher.Plugins.Planetics.git" data-copied-hint="copied!" title="copy to clipboard"><span class="octicon octicon-clippy"></span></span>
  </div>
</div>

  

<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=push">
  <h3><strong>Subversion</strong> checkout URL</h3>
  <div class="clone-url-box">
    <input type="text" class="clone js-url-field"
           value="https://github.com/saifmd4u/TechCipher.Plugins.Planetics" readonly="readonly">

    <span class="js-zeroclipboard url-box-clippy minibutton zeroclipboard-button" data-clipboard-text="https://github.com/saifmd4u/TechCipher.Plugins.Planetics" data-copied-hint="copied!" title="copy to clipboard"><span class="octicon octicon-clippy"></span></span>
  </div>
</div>


<p class="clone-options">You can clone with
      <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>,
      <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>,
      or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <span class="octicon help tooltipped upwards" title="Get help on which URL is right for you.">
    <a href="https://help.github.com/articles/which-remote-url-should-i-use">
    <span class="octicon octicon-question"></span>
    </a>
  </span>
</p>


  <a href="github-windows://openRepo/https://github.com/saifmd4u/TechCipher.Plugins.Planetics" class="minibutton sidebar-button">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>

                <a href="/saifmd4u/TechCipher.Plugins.Planetics/archive/master.zip"
                   class="minibutton sidebar-button"
                   title="Download this repository as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          


<!-- blob contrib key: blob_contributors:v21:b0c7d4a76b9a7374d9d83e086ec3f164 -->

<p title="This is a placeholder element" class="js-history-link-replace hidden"></p>

<a href="/saifmd4u/TechCipher.Plugins.Planetics/find/master" data-pjax data-hotkey="t" class="js-show-file-finder" style="display:none">Show File Finder</a>

<div class="file-navigation">
  

<div class="select-menu js-menu-container js-select-menu" >
  <span class="minibutton select-menu-button js-menu-target" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    role="button" aria-label="Switch branches or tags" tabindex="0">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax>

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-remove-close js-menu-close"></span>
      </div> <!-- /.select-menu-header -->

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Find or create a branch…" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Find or create a branch…">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div><!-- /.select-menu-tabs -->
      </div><!-- /.select-menu-filters -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <div class="select-menu-item js-navigation-item selected">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/saifmd4u/TechCipher.Plugins.Planetics/blob/master/README.md"
                 data-name="master"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text js-select-button-text css-truncate-target"
                 title="master">master</a>
            </div> <!-- /.select-menu-item -->
        </div>

          <form accept-charset="UTF-8" action="/saifmd4u/TechCipher.Plugins.Planetics/branches" class="js-create-branch select-menu-item select-menu-new-item-form js-navigation-item js-new-item-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="authenticity_token" type="hidden" value="JEInz6e8jyRFKxIxCq8Yx4HVBQ8bgLVL/K6WOTbfZRo=" /></div>
            <span class="octicon octicon-git-branch-create select-menu-item-icon"></span>
            <div class="select-menu-item-text">
              <h4>Create branch: <span class="js-new-item-name"></span></h4>
              <span class="description">from ‘master’</span>
            </div>
            <input type="hidden" name="name" id="name" class="js-new-item-value">
            <input type="hidden" name="branch" id="branch" value="master" />
            <input type="hidden" name="path" id="path" value="README.md" />
          </form> <!-- /.select-menu-item -->

      </div> <!-- /.select-menu-list -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

    </div> <!-- /.select-menu-modal -->
  </div> <!-- /.select-menu-modal-holder -->
</div> <!-- /.select-menu -->

  <div class="breadcrumb">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/saifmd4u/TechCipher.Plugins.Planetics" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">TechCipher.Plugins.Planetics</span></a></span></span><span class="separator"> / </span><strong class="final-path">README.md</strong> <span class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="README.md" data-copied-hint="copied!" title="copy to clipboard"><span class="octicon octicon-clippy"></span></span>
  </div>
</div>


  <div class="commit file-history-tease">
    <img alt="Saif Mohammad" class="main-avatar" height="24" src="https://1.gravatar.com/avatar/cfe7cc00754fd77a96b3886b66a1ecce?d=https%3A%2F%2Fidenticons.github.com%2F0dd3c63dc560214bbd805de7052bb8ac.png&amp;r=x&amp;s=140" width="24" />
    <span class="author"><a href="/saifmd4u" rel="author">saifmd4u</a></span>
    <time class="js-relative-date" datetime="2014-01-25T16:57:33-08:00" title="2014-01-25 16:57:33">January 25, 2014</time>
    <div class="commit-title">
        <a href="/saifmd4u/TechCipher.Plugins.Planetics/commit/5e83e7676ad9dbf2efb89aa274ad13eb7b083778" class="message" data-pjax="true" title="Update README.md">Update README.md</a>
    </div>

    <div class="participation">
      <p class="quickstat"><a href="#blob_contributors_box" rel="facebox"><strong>1</strong> contributor</a></p>
      
    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="Saif Mohammad" height="24" src="https://1.gravatar.com/avatar/cfe7cc00754fd77a96b3886b66a1ecce?d=https%3A%2F%2Fidenticons.github.com%2F0dd3c63dc560214bbd805de7052bb8ac.png&amp;r=x&amp;s=140" width="24" />
            <a href="/saifmd4u">saifmd4u</a>
          </li>
      </ul>
    </div>
  </div>

<div id="files" class="bubble">
  <div class="file">
    <div class="meta">
      <div class="info">
        <span class="icon"><b class="octicon octicon-file-text"></b></span>
        <span class="mode" title="File Mode">file</span>
          <span>31 lines (19 sloc)</span>
        <span>1.088 kb</span>
      </div>
      <div class="actions">
        <div class="button-group">
            <a class="minibutton tooltipped leftwards"
               href="github-windows://openRepo/https://github.com/saifmd4u/TechCipher.Plugins.Planetics?branch=master&amp;filepath=README.md" title="Open this file in GitHub for Windows">
                <span class="octicon octicon-device-desktop"></span> Open
            </a>
                <a class="minibutton"
                   href="/saifmd4u/TechCipher.Plugins.Planetics/edit/master/README.md"
                   data-method="post" rel="nofollow" data-hotkey="e">Edit</a>
          <a href="/saifmd4u/TechCipher.Plugins.Planetics/raw/master/README.md" class="button minibutton " id="raw-url">Raw</a>
            <a href="/saifmd4u/TechCipher.Plugins.Planetics/blame/master/README.md" class="button minibutton ">Blame</a>
          <a href="/saifmd4u/TechCipher.Plugins.Planetics/commits/master/README.md" class="button minibutton " rel="nofollow">History</a>
        </div><!-- /.button-group -->
          <a class="minibutton danger empty-icon tooltipped downwards"
             href="/saifmd4u/TechCipher.Plugins.Planetics/delete/master/README.md"
             title=""
             data-method="post" data-test-id="delete-blob-file" rel="nofollow">
          Delete
        </a>
      </div><!-- /.actions -->
    </div>
      
  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a name="techcipherpluginsplanetics" class="anchor" href="#techcipherpluginsplanetics"><span class="octicon octicon-link"></span></a>TechCipher.Plugins.Planetics</h1>

<p>Using Google Analytics API and PlanetaryJS to show various pings around the world for a website.</p>

<p>Uses following dependencies</p>

<ul>
<li>Google APIs Client Library 1.7.0-beta (<a href="https://www.nuget.org/packages/Google.Apis/">https://www.nuget.org/packages/Google.Apis/</a>)</li>
<li>planetaryjs (<a href="http://planetaryjs.com/">http://planetaryjs.com/</a>)</li>
</ul><p>Look at the following articles for more details of implementation</p>

<ul>
<li><a href="http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-1">http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-1</a></li>
<li><a href="http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-2">http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-2</a></li>
</ul><h1>
<a name="notes" class="anchor" href="#notes"><span class="octicon octicon-link"></span></a>Notes</h1>

<p>Install using Nuget Package (<a href="https://www.nuget.org/packages/TechCipher.Plugins.Planetics/">https://www.nuget.org/packages/TechCipher.Plugins.Planetics/</a>)</p>

<h1>
<a name="issues" class="anchor" href="#issues"><span class="octicon octicon-link"></span></a>Issues</h1>

<p>Make sure youe web.config have following entries</p>

<pre><code>assemblyIdentity name="System.Web.WebPages" publicKeyToken="31bf3856ad364e35"
bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0"

assemblyIdentity name="System.Web.WebPages.Razor" publicKeyToken="31bf3856ad364e35"
bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0"
</code></pre></article>
  </div>

  </div>
</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" class="js-jump-to-line" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" class="js-jump-to-line-form">
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="button">Go</button>
  </form>
</div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer">
    <ul class="site-footer-links right">
      <li><a href="https://status.github.com/">Status</a></li>
      <li><a href="http://developer.github.com">API</a></li>
      <li><a href="http://training.github.com">Training</a></li>
      <li><a href="http://shop.github.com">Shop</a></li>
      <li><a href="/blog">Blog</a></li>
      <li><a href="/about">About</a></li>

    </ul>

    <a href="/">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
    </a>

    <ul class="site-footer-links">
      <li>&copy; 2014 <span title="0.04009s from github-fe129-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="/site/terms">Terms</a></li>
        <li><a href="/site/privacy">Privacy</a></li>
        <li><a href="/security">Security</a></li>
        <li><a href="/contact">Contact</a></li>
    </ul>
  </div><!-- /.site-footer -->
</div><!-- /.container -->


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-fullscreen-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="js-fullscreen-contents" placeholder="" data-suggester="fullscreen_suggester"></textarea>
          <div class="suggester-container">
              <div class="suggester fullscreen-suggester js-navigation-container" id="fullscreen_suggester"
                 data-url="/saifmd4u/TechCipher.Plugins.Planetics/suggestions/commit">
              </div>
          </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped leftwards" title="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped leftwards"
      title="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-remove-close close js-ajax-error-dismiss"></a>
      Something went wrong with that request. Please try again.
    </div>

  </body>
</html>

>>>>>>> Images
